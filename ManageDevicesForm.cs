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

            ApplyTheme();

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

        private void ApplyTheme()
        {
            AppTheme theme = ThemeManager.CurrentTheme;

            if (theme == AppTheme.Dark)
            {
                // Fondo principal
                BackColor = Color.FromArgb(18, 20, 24);

                // Textos
                lblTitle.ForeColor = Color.White;
                lblInstructions.ForeColor = Color.White;
                lblDevices.ForeColor = Color.White;

                // Panel y campo de texto
                pnlDevices.BackColor = Color.FromArgb(38, 41, 46);

                txtDevices.BackColor = Color.FromArgb(38, 41, 46);
                txtDevices.ForeColor = Color.White;

                // Botones
                Color buttonBackground = Color.FromArgb(45, 49, 55);
                Color buttonBorder = Color.FromArgb(70, 75, 82);

                btnAdd.BackColor = buttonBackground;
                btnClear.BackColor = buttonBackground;
                btnImport.BackColor = buttonBackground;

                btnAdd.ForeColor = Color.White;
                btnClear.ForeColor = Color.White;
                btnImport.ForeColor = Color.White;

                btnAdd.FlatAppearance.BorderColor = buttonBorder;
                btnClear.FlatAppearance.BorderColor = buttonBorder;
                btnImport.FlatAppearance.BorderColor = buttonBorder;
            }
            else
            {
                // Restaurar fondo original
                BackColor = Color.FromArgb(25, 43, 70);

                // Textos originales
                lblTitle.ForeColor = Color.White;
                lblInstructions.ForeColor = Color.White;
                lblDevices.ForeColor = Color.White;

                // Panel y campo de texto
                pnlDevices.BackColor = Color.White;

                txtDevices.BackColor = Color.White;
                txtDevices.ForeColor = Color.Black;

                // Botones originales
                btnAdd.BackColor = Color.White;
                btnClear.BackColor = Color.White;
                btnImport.BackColor = Color.White;

                btnAdd.ForeColor = Color.Black;
                btnClear.ForeColor = Color.Black;
                btnImport.ForeColor = Color.Black;

                Color originalBorder = Color.FromArgb(190, 225, 245);

                btnAdd.FlatAppearance.BorderColor = originalBorder;
                btnClear.FlatAppearance.BorderColor = originalBorder;
                btnImport.FlatAppearance.BorderColor = originalBorder;
            }
        }
        private void UpdateButtonStyle(Button button)
        {
            bool isDark = ThemeManager.CurrentTheme == AppTheme.Dark;

            if (button.Enabled)
            {
                if (isDark)
                {
                    button.BackColor = Color.FromArgb(45, 49, 55);
                    button.ForeColor = Color.White;
                    button.FlatAppearance.BorderColor = Color.FromArgb(70, 75, 82);
                }
                else
                {
                    button.BackColor = Color.White;
                    button.ForeColor = Color.Black;
                    button.FlatAppearance.BorderColor = Color.FromArgb(190, 225, 245);
                }
            }
            else
            {
                if (isDark)
                {
                    button.BackColor = Color.FromArgb(32, 35, 40);
                    button.ForeColor = Color.FromArgb(120, 125, 130);
                    button.FlatAppearance.BorderColor = Color.FromArgb(55, 60, 65);
                }
                else
                {
                    button.BackColor = Color.FromArgb(225, 225, 225);
                    button.ForeColor = Color.Gray;
                    button.FlatAppearance.BorderColor = Color.FromArgb(170, 170, 170);
                }
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
