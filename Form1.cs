namespace ITDeviceManager
{
    public partial class MainForm : Form
    {
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
    }
}
