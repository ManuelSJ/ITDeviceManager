using System;
using System.Collections.Generic;
using System.Text;
using System.Management;
using System.Net;

namespace ITDeviceManager
{
    public class WindowsDeviceQueryService : IDeviceQueryService
    {
        private readonly WindowsUpdateStatusService windowsUpdateStatusService = new WindowsUpdateStatusService();

        public async Task<Device> CheckDeviceAsync(
    ConfiguredDevice configuredDevice)
        {
            return await Task.Run(() =>
            {
                string identifier = configuredDevice.Identifier;

                try
                {
                    ManagementScope scope =
                        new ManagementScope(
                            $@"\\{identifier}\root\cimv2");

                    scope.Connect();

                    ObjectQuery query =
                        new ObjectQuery(
                            "SELECT CSName, LastBootUpTime FROM Win32_OperatingSystem");

                    using ManagementObjectSearcher searcher =
                        new ManagementObjectSearcher(scope, query);

                    foreach (ManagementObject result in searcher.Get())
                    {
                        string computerName =
                            result["CSName"]?.ToString() ?? identifier;

                        string address = ResolveAddress(identifier);

                        string? bootTimeValue =
                            result["LastBootUpTime"]?.ToString();

                        DateTime bootTime =
                            ManagementDateTimeConverter.ToDateTime(bootTimeValue);

                        RebootStatus rebootStatus =
                            windowsUpdateStatusService.GetRebootStatus(identifier);

                        return new Device
                        {
                            Name = computerName,
                            Address = address,

                            Status = !rebootStatus.IsCheckSuccessful
                                ? DeviceStatus.Unverified
                                : rebootStatus.IsRebootRequired
                                    ? DeviceStatus.Pending
                                    : DeviceStatus.Ok,

                            LastCheck = DateTime.Now,
                            Uptime = DateTime.Now - bootTime,

                            Reason = rebootStatus.Reason,
                            RebootReasonType = rebootStatus.ReasonType
                        };
                    }

                    return CreateUnavailableDevice(
                        identifier,
                        "No se obtuvo información del sistema operativo.");
                }
                catch (Exception ex)
                {
                    return CreateUnavailableDevice(
                        identifier,
                        ex.Message);
                }
            });
        }

        private static string ResolveAddress(string identifier)
        {
            if (IPAddress.TryParse(identifier, out _))
            {
                return identifier;
            }

            try
            {
                IPAddress? address = Dns.GetHostAddresses(identifier)
                    .FirstOrDefault(ip =>
                        ip.AddressFamily ==
                        System.Net.Sockets.AddressFamily.InterNetwork);

                return address?.ToString() ?? identifier;
            }
            catch
            {
                return identifier;
            }
        }


        private static Device CreateUnavailableDevice(
        string identifier,
         string reason)
        {
            return new Device
            {
                Name = identifier,
                Address = ResolveAddress(identifier),
                Status = DeviceStatus.Unknown,
                LastCheck = DateTime.Now,
                Reason = reason
            };
        }
    }
}
