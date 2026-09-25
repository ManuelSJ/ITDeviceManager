using System;
using System.Collections.Generic;
using System.Text;

namespace ITDeviceManager
{
    public class RebootStatus
    {
        public bool IsRebootRequired { get; set; }

        public bool IsCheckSuccessful { get; set; }

        public string Reason { get; set; } = "";

    }
}
