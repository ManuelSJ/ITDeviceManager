using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ITDeviceManager
{
    public partial class UnavailableDevicesForm : Form
    {
        public UnavailableDevicesForm(List<Device> devices)
        {
            InitializeComponent();

            ApplyTheme();

            dgvUnavailableDevices.Resize += (s, e) =>
            {
                ApplyRoundedCorners(dgvUnavailableDevices, 20);
            };

            ApplyRoundedCorners(dgvUnavailableDevices, 20);

            foreach (Device device in devices)
            {
                dgvUnavailableDevices.Rows.Add(
                    device.Name,
                    device.Address
                );
            }


            dgvUnavailableDevices.ClearSelection();
            dgvUnavailableDevices.CurrentCell = null;

            dgvUnavailableDevices.SelectionChanged += (s, e) =>
            {
                dgvUnavailableDevices.ClearSelection();
                dgvUnavailableDevices.CurrentCell = null;
            };

        }

    [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr CreateRoundRectRgn(
             int nLeftRect,
             int nTopRect,
             int nRightRect,
             int nBottomRect,
             int nWidthEllipse,
             int nHeightEllipse
             );

        private void ApplyRoundedCorners(Control control, int radius)
        {
            control.Region = Region.FromHrgn(
                CreateRoundRectRgn(
                    0,
                    0,
                    control.Width,
                    control.Height,
                    radius,
                    radius
                )
            );
        }

        private void ApplyTheme()
        {
            bool isDark = ThemeManager.CurrentTheme == AppTheme.Dark;

            dgvUnavailableDevices.EnableHeadersVisualStyles = false;

            if (isDark)
            {
                // Fondo del formulario
                BackColor = Color.FromArgb(18, 20, 24);

                // Fondo de la tabla
                dgvUnavailableDevices.BackgroundColor = Color.FromArgb(30, 32, 36);
                dgvUnavailableDevices.GridColor = Color.FromArgb(55, 60, 65);

                // Encabezados
                dgvUnavailableDevices.ColumnHeadersDefaultCellStyle.BackColor =
                    Color.FromArgb(45, 48, 54);

                dgvUnavailableDevices.ColumnHeadersDefaultCellStyle.ForeColor =
                    Color.White;

                dgvUnavailableDevices.ColumnHeadersDefaultCellStyle.SelectionBackColor =
                    Color.FromArgb(45, 48, 54);

                dgvUnavailableDevices.ColumnHeadersDefaultCellStyle.SelectionForeColor =
                    Color.White;

                // Filas
                dgvUnavailableDevices.DefaultCellStyle.BackColor =
                    Color.FromArgb(38, 41, 46);

                dgvUnavailableDevices.DefaultCellStyle.ForeColor =
                    Color.White;

                dgvUnavailableDevices.DefaultCellStyle.SelectionBackColor =
                    Color.FromArgb(55, 60, 65);

                dgvUnavailableDevices.DefaultCellStyle.SelectionForeColor =
                    Color.White;

                // Filas alternadas
                dgvUnavailableDevices.AlternatingRowsDefaultCellStyle.BackColor =
                    Color.FromArgb(38, 41, 46);
            }
            else
            {
                // Fondo del formulario
                BackColor = Color.White;

                // Fondo original de la tabla
                dgvUnavailableDevices.BackgroundColor = Color.White;
                dgvUnavailableDevices.GridColor = Color.White;

                // Encabezados originales
                dgvUnavailableDevices.ColumnHeadersDefaultCellStyle.BackColor =
                    Color.FromArgb(190, 225, 245);

                dgvUnavailableDevices.ColumnHeadersDefaultCellStyle.ForeColor =
                    Color.Black;

                dgvUnavailableDevices.ColumnHeadersDefaultCellStyle.SelectionBackColor =
                    Color.FromArgb(190, 225, 245);

                dgvUnavailableDevices.ColumnHeadersDefaultCellStyle.SelectionForeColor =
                    SystemColors.HighlightText;

                // Filas originales
                dgvUnavailableDevices.DefaultCellStyle.BackColor =
                    Color.FromArgb(245, 248, 250);

                dgvUnavailableDevices.DefaultCellStyle.ForeColor =
                    Color.FromArgb(51, 51, 51);

                dgvUnavailableDevices.DefaultCellStyle.SelectionBackColor =
                    Color.WhiteSmoke;

                dgvUnavailableDevices.DefaultCellStyle.SelectionForeColor =
                    Color.Black;

                // Filas alternadas
                dgvUnavailableDevices.AlternatingRowsDefaultCellStyle.BackColor =
                    Color.FromArgb(245, 248, 250);
            }
        }
    }
}
