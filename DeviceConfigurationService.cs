using System;
using System.Collections.Generic;
using System.Text;

namespace ITDeviceManager
{
    internal class DeviceConfigurationService
    {
        private readonly string filePath;
        public DeviceConfigurationService()
        {
            string appDataPath = Environment.GetFolderPath(
                Environment.SpecialFolder.LocalApplicationData);

            string appFolder = Path.Combine(appDataPath, "ITDeviceManager");

            Directory.CreateDirectory(appFolder);

            filePath = Path.Combine(appFolder, "devices.json");
        }


        public void SaveDevices(List<ConfiguredDevice> devices)
        {
            string json = System.Text.Json.JsonSerializer.Serialize(
                devices,
                new System.Text.Json.JsonSerializerOptions
                {
                    WriteIndented = true
                });

            File.WriteAllText(filePath, json);
        }

        public List<ConfiguredDevice> LoadDevices()

        {
            if (!File.Exists(filePath))
            {
                return new List<ConfiguredDevice>();
            }

            string json = File.ReadAllText(filePath);

            List<ConfiguredDevice>? devices =
                System.Text.Json.JsonSerializer.Deserialize<List<ConfiguredDevice>>(json);

            return devices ?? new List<ConfiguredDevice>();
        }
        public void ClearDevices()
        {
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
        }

    }

    }
