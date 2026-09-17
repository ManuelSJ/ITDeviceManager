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

            foreach (Device device in devices)
            {
                dgvUnavailableDevices.Rows.Add(
                    device.Name,
                    device.Address
                );
            }
        }

        private void UnavailableDevicesForm_Load(object sender, EventArgs e)
        {

        }
    }
}
