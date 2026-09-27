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
    }
}
