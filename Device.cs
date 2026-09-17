using System;
using System.Collections.Generic;
using System.Text;

namespace ITDeviceManager
{
    public class Device
    {
        public string Name { get; set; } = "";
        public string Address { get; set; } = "";
        public DeviceStatus Status { get; set; } = DeviceStatus.Unknown;
        public DateTime? LastCheck { get; set; }
        public TimeSpan Uptime { get; set; }
        public string Reason { get; set; } = "";
    }
}
