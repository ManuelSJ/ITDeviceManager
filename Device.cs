using System;
using System.Collections.Generic;
using System.Text;

namespace ITDeviceManager
{
    internal class Device
    {
        public string Name { get; set; } = "";
        public string Adress { get; set; } = "";
        public DeviceStatus Status { get; set; } = DeviceStatus.Unknowm;
        public DateTime? LastCheck { get; set; }
        public TimeSpan Uptime { get; set; }
        public string Reason { get; set; } = "";
    }
}
