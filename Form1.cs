namespace ITDeviceManager
{
    public partial class MainForm : Form
    {
        private DemoDeviceProvider demoProvider = new DemoDeviceProvider();
        private List<Device> unavailableDevices = new List<Device>();

        public MainForm()
        {
            InitializeComponent();

            cmbInterval.SelectedItem = "6 horas";
            lblScanStatus.Text = "Listo para consultar";
            lblNextScan.Text = "Próxima consulta: --:--";
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            List<Device> devices = demoProvider.GetDevices();

            unavailableDevices = devices.Where(d => d.Status == DeviceStatus.Unknown).ToList();
            lblUnavailableDetails.Text = $"Equipos no disponibles: {unavailableDevices.Count}";

            lblConfiguredCount.Text = devices.Count.ToString();

            int checkedDevices = devices.Count(d => d.Status != DeviceStatus.Unknown);
            lblCheckedCount.Text = checkedDevices.ToString();

            int pendingDevices = devices.Count(d => d.Status == DeviceStatus.Pending);
            lblPendingCount.Text = pendingDevices.ToString();

            int unavailableCount = devices.Count(d => d.Status == DeviceStatus.Unknown);
            lblUnavailableCount.Text = unavailableCount.ToString();

            dgvPendingDevices.Rows.Clear();

            foreach (Device device in devices)
            {
                if (device.Status == DeviceStatus.Pending)
                {
                    dgvPendingDevices.Rows.Add(
                        device.Name,
                        device.Address,
                        $"{device.Uptime.Days} días",
                        device.Reason,
                        device.LastCheck
                     );
                }
            }
        }

        private void btnViewUnavailable_Click(object sender, EventArgs e)
        {
            UnavailableDevicesForm form = new UnavailableDevicesForm(unavailableDevices);

            form.ShowDialog(this);
        }
    }
}
