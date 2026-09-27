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

        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        public ManageDevicesForm()
        {
            InitializeComponent();
            pnlDevices.Region = Region.FromHrgn(
              CreateRoundRectRgn(0, 0, pnlDevices.Width, pnlDevices.Height, 15, 15)
            );

            LoadConfiguredDevices();

            btnAdd.EnabledChanged += Button_EnabledChanged;
            btnClear.EnabledChanged += Button_EnabledChanged;
            btnImport.EnabledChanged += Button_EnabledChanged;
            

            UpdateButtonStyle(btnAdd);
            UpdateButtonStyle(btnClear);
            UpdateButtonStyle(btnImport);
           
        }

        private void UpdateButtonStyle(Button button)
        {
            if (button.Enabled)
            {
                button.BackColor = Color.White;
                button.ForeColor = Color.Black;
                button.FlatAppearance.BorderColor = Color.FromArgb(190, 225, 245);
            }
            else
            {
                button.BackColor = Color.FromArgb(225, 225, 225);
                button.ForeColor = Color.Gray;
                button.FlatAppearance.BorderColor = Color.FromArgb(170, 170, 170);
            }
        }

        private void Button_EnabledChanged(object? sender, EventArgs e)
        {
            if (sender is Button button)
            {
                UpdateButtonStyle(button);
            }
        }

        private void txtDevice_TextChanged(object sender, EventArgs e)
        {
            string[] devices = txtDevices.Lines.Where(line => !string.IsNullOrWhiteSpace(line)).ToArray();

            int deviceCount = devices.Length;

            lblDevices.Text = $"Equipos ({deviceCount})";

            btnAdd.Enabled = true;
            btnClear.Enabled = deviceCount > 0;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
           
            txtDevices.ReadOnly = false;
            txtDevices.Clear();

            btnImport.Enabled = true;
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            if (openFileDialogDevices.ShowDialog() == DialogResult.OK)
            {
                string contenido = File.ReadAllText(openFileDialogDevices.FileName);

                MessageBox.Show(
    $"Archivo: {openFileDialogDevices.FileName}\n\n" +
    $"Existe: {File.Exists(openFileDialogDevices.FileName)}\n" +
    $"Tamaño: {new FileInfo(openFileDialogDevices.FileName).Length} bytes\n\n" +
    $"Contenido:\n{contenido}"
);

                txtDevices.Text = contenido;
            }
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            List<ConfiguredDevice> devices = txtDevices.Lines
                .Where(line => !string.IsNullOrWhiteSpace(line))
                .Select(line => new ConfiguredDevice
                {
                    Identifier = line.Trim()
                })
                .DistinctBy(
                    device => device.Identifier,
                    StringComparer.OrdinalIgnoreCase)
                .ToList();

            configurationService.SaveDevices(devices);

            DialogResult = DialogResult.OK;
            Close();
        }

        private void LoadConfiguredDevices()
        {
            List<ConfiguredDevice> devices =
                configurationService.LoadDevices();

            if (devices.Count == 0)
            {
                btnAdd.Enabled = true;
                btnClear.Enabled = false;
                btnImport.Enabled = true;
                return;
            }

            txtDevices.Lines = devices
                .Select(device => device.Identifier)
                .ToArray();

            btnAdd.Enabled = false;
            btnImport.Enabled = true;
            btnClear.Enabled = true;
        }

    }
}
