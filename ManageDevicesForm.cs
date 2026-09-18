using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ITDeviceManager
{
    public partial class ManageDevicesForm : Form
    {
        private readonly DeviceConfigurationService configurationService = new DeviceConfigurationService();

        public ManageDevicesForm()
        {
            InitializeComponent();

            LoadConfiguredDevices();
        }

        private void lblDevices_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtDevice_TextChanged(object sender, EventArgs e)
        {
            string[] devices = txtDevices.Lines.Where(line => !string.IsNullOrWhiteSpace(line)).ToArray();

            int deviceCount = devices.Length;

            lblDevices.Text = $"Equipos ({deviceCount})";

            btnAdd.Enabled = deviceCount > 0;
            btnClear.Enabled = deviceCount > 0;
            btnContinue.Enabled = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            configurationService.ClearDevices();

            txtDevices.ReadOnly = false;
            txtDevices.Clear();

            btnImport.Enabled = true;
            btnContinue.Enabled = false;
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            if (openFileDialogDevices.ShowDialog() == DialogResult.OK)
            {
                txtDevices.Text = File.ReadAllText(openFileDialogDevices.FileName);
            }
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            List<ConfiguredDevice> devices = txtDevices.Lines.Where(line => !string.IsNullOrWhiteSpace(line)).Select(line => new ConfiguredDevice
            {
                Identifier = line.Trim()
            })
                .DistinctBy(device => device.Identifier,
                            StringComparer.OrdinalIgnoreCase)
                .ToList();

            configurationService.SaveDevices(devices);


            btnAdd.Enabled = false;
            btnImport.Enabled = false;
            btnContinue.Enabled = true;

        }

        private void LoadConfiguredDevices()
        {
            List<ConfiguredDevice> devices =
                configurationService.LoadDevices();

            if (devices.Count == 0)
            {
                return;
            }

            txtDevices.Lines = devices
                .Select(device => device.Identifier)
                .ToArray();

            btnAdd.Enabled = false;
            btnImport.Enabled = false;
            btnClear.Enabled = true;
            btnContinue.Enabled = true;
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
