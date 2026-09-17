using System;
using System.Collections.Generic;
using System.Text;

namespace ITDeviceManager
{
    internal class DemoDeviceProvider
    {
        public List<Device> GetDevices()
        {
            List<Device> devices = new List<Device>();

            Device device1 = new Device();

            device1.Name = "PC-DEMO-01";
            device1.Address = "192.0.2.10";
            device1.Status = DeviceStatus.Ok;

            devices.Add(device1);

            Device device2 = new Device();

            device2.Name = "PC-DEMO-02";
            device2.Address = "192.0.2.11";
            device2.Status = DeviceStatus.Pending;
            device2.LastCheck = DateTime.Now;
            device2.Uptime = TimeSpan.FromDays(32);
            device2.Reason = "Actualización pendiente";

            devices.Add(device2);

            Device device3 = new Device();

            device3.Name = "PC-DEMO-03";
            device3.Address = "192.0.2.12";
            device3.Status = DeviceStatus.Unknown;
            device3.Reason = "No fue posible consultar el equipo";

            devices.Add(device3);

            return devices;
        }
    }
}
