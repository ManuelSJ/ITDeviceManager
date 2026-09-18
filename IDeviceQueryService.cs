using System;
using System.Collections.Generic;
using System.Text;

namespace ITDeviceManager
{
    internal interface IDeviceQueryService
    {
        Task<Device> CheckDeviceAsync(ConfiguredDevice configuredDevice);
    }

}
