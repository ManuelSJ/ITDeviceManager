using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Win32;

namespace ITDeviceManager
{
    public class WindowsUpdateStatusService
    {
        public RebootStatus GetRebootStatus(string computerName)
        {
            try
            {

                using RegistryKey remoteRegistry =
                    RegistryKey.OpenRemoteBaseKey(
                        RegistryHive.LocalMachine,
                        computerName);

                using RegistryKey? rebootRequiredKey =
                    remoteRegistry.OpenSubKey(
                        @"SOFTWARE\Microsoft\Windows\CurrentVersion\WindowsUpdate\Auto Update\RebootRequired");

                using RegistryKey? componentBasedServicingKey =
                   remoteRegistry.OpenSubKey(
                        @"SOFTWARE\Microsoft\Windows\CurrentVersion\Component Based Servicing\RebootPending");

                using RegistryKey? sessionManagerKey =
                   remoteRegistry.OpenSubKey(
                        @"SYSTEM\CurrentControlSet\Control\Session Manager");

                bool hasPendingFileRename =
                    sessionManagerKey?.GetValue("PendingFileRenameOperations") != null;

                if (rebootRequiredKey != null)
                {
                    return new RebootStatus
                    {
                        IsRebootRequired = true,
                        IsCheckSuccessful = true,
                        Reason = "Reinicio pendiente por Windows Update"
                    };
                }

                if (componentBasedServicingKey != null)
                {
                    return new RebootStatus
                    {
                        IsRebootRequired = true,
                        IsCheckSuccessful = true,
                        Reason = "Reinicio pendiente por mantenimiento de Windows"
                    };
                }

                if (hasPendingFileRename)
                {
                    return new RebootStatus
                    {
                        IsRebootRequired = true,
                        IsCheckSuccessful = true,
                        Reason = "Operación de archivos pendiente"
                    };
                }

                return new RebootStatus
                {
                    IsRebootRequired = false,
                    IsCheckSuccessful = true,
                    Reason = ""
                };

            }

            catch
            {
                return new RebootStatus
                {
                    IsRebootRequired = false,
                    IsCheckSuccessful = false,
                    Reason = "No fue posible verificar el estado de reinicio"
                };
            }
        }
    }
}
