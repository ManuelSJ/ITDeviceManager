using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;

namespace ITDeviceManager
{
    public partial class MainForm : Form
    {
        private readonly DeviceConfigurationService configurationService = new DeviceConfigurationService();
        private readonly WindowsDeviceQueryService deviceQueryService = new WindowsDeviceQueryService();

        private List<Device> unavailableDevices = new List<Device>();
        private bool isScanning = false;

        public MainForm()
        {
            InitializeComponent();

           

            dgvPendingDevices.Resize += (s, e) =>
            {
                ApplyRoundedCorners(dgvPendingDevices, 20);
            };

            ApplyRoundedCorners(dgvPendingDevices, 20);

            dgvPendingDevices.ClearSelection();
            dgvPendingDevices.CurrentCell = null;

            dgvPendingDevices.SelectionChanged += (s, e) =>
            {
                dgvPendingDevices.ClearSelection();
                dgvPendingDevices.CurrentCell = null;
            };

            dgvPendingDevices.GotFocus += (s, e) =>
            {
                pnlMain.Focus();
            };

            cmbInterval.SelectedItem = "6 horas";
            ConfigureMonitoringTimer();

            lblScanStatus.Text = "Listo para consultar";
        }

        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(
            IntPtr hWnd,
            int Msg,
            IntPtr wParam,
            IntPtr lParam);

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTION = 0x2;

        private void ApplyRoundedCorners(Control control, int radius)
        {
            Rectangle bounds = new Rectangle(0, 0, control.Width, control.Height);
            using GraphicsPath path = new GraphicsPath();

            int diameter = radius * 2;

            path.AddArc(bounds.X, bounds.Y, diameter, diameter, 180, 90);
            path.AddArc(bounds.Right - diameter, bounds.Y, diameter, diameter, 270, 90);
            path.AddArc(bounds.Right - diameter, bounds.Bottom - diameter, diameter, diameter, 0, 90);
            path.AddArc(bounds.X, bounds.Bottom - diameter, diameter, diameter, 90, 90);
            path.CloseFigure();

            control.Region?.Dispose();
            control.Region = new Region(path);
        }

        private void ConfigureMonitoringTimer()
        {
            string? selectedInterval = cmbInterval.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(selectedInterval))
            {
                return;
            }

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

                List<ConfiguredDevice> configuredDevices = configurationService.LoadDevices();

                cardConfigured.CardValue = configuredDevices.Count.ToString();

                cardChecked.CardValue = "0";
                int processedDevices = 0;
                int checkedDevices = 0;
                int pendingDevices = 0;

                cardPending.CardValue = "0";
                dgvPendingDevices.Rows.Clear();

                cardUnavailable.CardValue = "0";
                unavailableDevices.Clear();

                foreach (ConfiguredDevice configuredDevice in configuredDevices)
                {
                    Device device;

                    try
                    {
                        device = await deviceQueryService.CheckDeviceAsync(configuredDevice);
                    }
                    catch
                    {
                        device = new Device
                        {
                            Name = configuredDevice.Identifier,
                            Address = configuredDevice.Identifier,
                            Status = DeviceStatus.Unknown,
                            LastCheck = DateTime.Now,
                            Reason = "No fue posible consultar el equipo"
                        };
                    }

                    processedDevices++;

                    if (device.Status != DeviceStatus.Unknown)
                    {
                        checkedDevices++;
                        cardChecked.CardValue = processedDevices.ToString();
                    }




                    if (device.Status == DeviceStatus.Pending)
                    {
                        pendingDevices++;
                        cardPending.CardValue = pendingDevices.ToString();

                        dgvPendingDevices.Rows.Add(
                           device.Name ?? string.Empty,
                           device.Address ?? string.Empty,
                           $"{device.Uptime.Days} días",
                           device.Reason ?? string.Empty,
                           device.LastCheck?.ToString("dd/MM/yyyy HH:mm") ?? string.Empty


                        );
                    }

                    if (device.Status == DeviceStatus.Unverified)
                    {
                        dgvPendingDevices.Rows.Add(
                            device.Name ?? string.Empty,
                            device.Address ?? string.Empty,
                            $"{device.Uptime.Days} días",
                            device.Reason ?? string.Empty,
                            device.LastCheck?.ToString("dd/MM/yyyy HH:mm") ?? string.Empty
                        );
                    }

                    if (device.Status == DeviceStatus.Unknown)
                    {
                        unavailableDevices.Add(device);

                        cardUnavailable.CardValue = unavailableDevices.Count.ToString();

                    }

                    int progress = processedDevices * 100 / configuredDevices.Count;
                    prgScan.Value = progress;
                }

                prgScan.Value = 100;

                if (checkedDevices == 0 && unavailableDevices.Count > 0)
                {
                    lblScanStatus.Text = "No fue posible completar la consulta";
                }
                else if (pendingDevices == 0 && checkedDevices > 0)
                {
                    lblScanStatus.Text = "Sin equipos pendientes actualmente ✓";
                }
                else
                {
                    lblScanStatus.Text = "Consulta completada ✓";
                }

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

        private async void btnManageDevices_Click(object sender, EventArgs e)
        {
            using ManageDevicesForm form = new ManageDevicesForm();

            if (form.ShowDialog(this) == DialogResult.OK)
            {
                await ScanDevicesAsync();
            }
        }

        private void cmbInterval_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode =
                System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            Color lightBlue = Color.FromArgb(190, 225, 245);

            using Pen pen = new Pen(lightBlue, 2);

            // Patrón superior izquierdo
            Point[] topLeft =
            {
        new Point(0, 90),
        new Point(90, 120),
        new Point(155, 75),
        new Point(220, 145),
        new Point(145, 205),
        new Point(70, 165),
        new Point(0, 210)
    };

            e.Graphics.DrawLines(pen, topLeft);

            // Algunas conexiones internas
            e.Graphics.DrawLine(pen, topLeft[1], topLeft[4]);
            e.Graphics.DrawLine(pen, topLeft[2], topLeft[5]);


            // Patrón superior derecho
            Point[] topRight =
            {
        new Point(ClientSize.Width, 100),
        new Point(ClientSize.Width - 80, 130),
        new Point(ClientSize.Width - 145, 85),
        new Point(ClientSize.Width - 220, 155),
        new Point(ClientSize.Width - 145, 220),
        new Point(ClientSize.Width - 65, 175),
        new Point(ClientSize.Width, 220)
    };

            e.Graphics.DrawLines(pen, topRight);

            e.Graphics.DrawLine(pen, topRight[1], topRight[4]);
            e.Graphics.DrawLine(pen, topRight[2], topRight[5]);


            // Patrón inferior izquierdo
            Point[] bottomLeft =
            {
        new Point(0, ClientSize.Height - 190),
        new Point(80, ClientSize.Height - 220),
        new Point(150, ClientSize.Height - 160),
        new Point(215, ClientSize.Height - 210),
        new Point(250, ClientSize.Height - 110),
        new Point(160, ClientSize.Height - 55),
        new Point(70, ClientSize.Height - 100),
        new Point(0, ClientSize.Height - 55)
    };

            e.Graphics.DrawLines(pen, bottomLeft);

            e.Graphics.DrawLine(pen, bottomLeft[1], bottomLeft[5]);
            e.Graphics.DrawLine(pen, bottomLeft[2], bottomLeft[6]);
            e.Graphics.DrawLine(pen, bottomLeft[3], bottomLeft[5]);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
            else
            {
                WindowState = FormWindowState.Maximized;
            }
        }

        private void pnlTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }
    }
}
