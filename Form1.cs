namespace ITDeviceManager
{
    public partial class MainForm : Form
    {
        private DemoDeviceProvider demoProvider = new DemoDeviceProvider();
        private List<Device> unavailableDevices = new List<Device>();
        private bool isScanning = false;

        public MainForm()
        {
            InitializeComponent();

            cmbInterval.SelectedItem = "6 horas";
            ConfigureMonitoringTimer();

            lblScanStatus.Text = "Listo para consultar";
        }

        private void ConfigureMonitoringTimer()
        {
            string selectedInterval = cmbInterval.SelectedItem.ToString();

            int hours = int.Parse(selectedInterval.Split(' ')[0]);

            monitoringTimer.Interval = (int)TimeSpan.FromHours(hours).TotalMilliseconds;

            DateTime nextScan = DateTime.Now.AddHours(hours);

            lblNextScan.Text = $"Próxima consulta: {nextScan:hh:mm tt}";

            monitoringTimer.Start();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private async Task ScanDevicesAsync()
        {

            if (isScanning)
            {
                return;
            }

            isScanning = true;

            try
            {
                lblScanStatus.Text = "Consultando equipos...";
                prgScan.Value = 0;
                btnScan.Enabled = false;

                List<Device> devices = demoProvider.GetDevices();

                lblCheckedCount.Text = "0";
                int processedDevices = 0;

                lblPendingCount.Text = "0";
                dgvPendingDevices.Rows.Clear();

                lblUnavailableCount.Text = "0";
                lblUnavailableDetails.Text = "Equipos no disponibles: 0";
                unavailableDevices.Clear();

                foreach (Device device in devices)
                {
                    await Task.Delay(1000);

                    processedDevices++;

                    if (device.Status != DeviceStatus.Unknown)
                    {
                        lblCheckedCount.Text =
                            (int.Parse(lblCheckedCount.Text) + 1).ToString();
                    }

                    if (device.Status == DeviceStatus.Pending)
                    {
                        lblPendingCount.Text =
                            (int.Parse(lblPendingCount.Text) + 1).ToString();

                        dgvPendingDevices.Rows.Add(
                            device.Name,
                            device.Address,
                            $"{device.Uptime.Days} días",
                            device.Reason,
                            device.LastCheck
                        );
                    }

                    if (device.Status == DeviceStatus.Unknown)
                    {
                        unavailableDevices.Add(device);

                        lblUnavailableCount.Text = unavailableDevices.Count.ToString();

                        lblUnavailableDetails.Text =
                            $"Equipos no disponibles: {unavailableDevices.Count}";
                    }

                    int progress = processedDevices * 100 / devices.Count;
                    prgScan.Value = progress;
                }

                lblConfiguredCount.Text = devices.Count.ToString();

                prgScan.Value = 100;
                lblScanStatus.Text = "Consulta completada ✓";

                ConfigureMonitoringTimer();
            }
            finally
            {
                isScanning = false;
                btnScan.Enabled = true;
            }
        }

        private async void btnScan_Click(object sender, EventArgs e)
        {
            await ScanDevicesAsync();
        }


        private void btnViewUnavailable_Click(object sender, EventArgs e)
        {
            UnavailableDevicesForm form = new UnavailableDevicesForm(unavailableDevices);

            form.ShowDialog(this);
        }

        private void cmbInterval_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConfigureMonitoringTimer();
        }

        private async void monitoringTimer_Tick(object sender, EventArgs e)
        {
            await ScanDevicesAsync();
        }

        private async void MainForm_Shown(object sender, EventArgs e)
        {
            await ScanDevicesAsync();
        }
    }
}
