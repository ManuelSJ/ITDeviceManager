using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Win32;

namespace ITDeviceManager
{
    public class WindowsUpdateStatusService
    {
        public bool IsRebootRequired(string computerName)
        {
            using RegistryKey remoteRegistry =
                RegistryKey.OpenRemoteBaseKey(
                    RegistryHive.LocalMachine,
                    computerName);

            using RegistryKey? rebootRequiredKey =
                remoteRegistry.OpenSubKey(
                    @"SOFTWARE\Microsoft\Windows\CurrentVersion\WindowsUpdate\Auto Update\RebootRequired");

            return rebootRequiredKey != null;
        }
    }
}
