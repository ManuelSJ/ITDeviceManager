namespace ITDeviceManager
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            pnlHeader = new Panel();
            lblTitle = new Label();
            monitoringTimer = new System.Windows.Forms.Timer(components);
            cardPending = new StatusCard();
            pnlMain = new Panel();
            dgvPendingDevices = new DataGridView();
            colDevice = new DataGridViewTextBoxColumn();
            colAddress = new DataGridViewTextBoxColumn();
            colUptime = new DataGridViewTextBoxColumn();
            colReason = new DataGridViewTextBoxColumn();
            colLastCheck = new DataGridViewTextBoxColumn();
            pnlControls = new Panel();
            tlpControls = new TableLayoutPanel();
            flpAction = new FlowLayoutPanel();
            btnScan = new Button();
            flpAction2 = new FlowLayoutPanel();
            btnManageDevices = new Button();
            flpAction3 = new FlowLayoutPanel();
            btnViewUnavailable = new Button();
            fplprogress = new FlowLayoutPanel();
            lblScanStatus = new Label();
            flpMonitoring = new FlowLayoutPanel();
            lblautoMonitor = new Label();
            flpMonitoring2 = new FlowLayoutPanel();
            lblIntervalText = new Label();
            cmbInterval = new ComboBox();
            flpMonitoring3 = new FlowLayoutPanel();
            lblNextScan = new Label();
            fplProgress2 = new FlowLayoutPanel();
            prgScan = new ProgressBar();
            tlpStatusCards = new TableLayoutPanel();
            cardUnverified = new StatusCard();
            cardUnavailable = new StatusCard();
            cardChecked = new StatusCard();
            cardConfigured = new StatusCard();
            pnlTitleBar = new Panel();
            btnMinimize = new Button();
            btnMaximize = new Button();
            btnClose = new Button();
            lblTitleBar = new Label();
            pnlHeader.SuspendLayout();
            pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPendingDevices).BeginInit();
            pnlControls.SuspendLayout();
            tlpControls.SuspendLayout();
            flpAction.SuspendLayout();
            flpAction2.SuspendLayout();
            flpAction3.SuspendLayout();
            fplprogress.SuspendLayout();
            flpMonitoring.SuspendLayout();
            flpMonitoring2.SuspendLayout();
            flpMonitoring3.SuspendLayout();
            fplProgress2.SuspendLayout();
            tlpStatusCards.SuspendLayout();
            pnlTitleBar.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.Transparent;
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 42);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Padding = new Padding(28, 8, 28, 8);
            pnlHeader.Size = new Size(1184, 88);
            pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = SystemColors.Highlight;
            lblTitle.Location = new Point(28, 8);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(1128, 72);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "ITDeviceManager";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // monitoringTimer
            // 
            monitoringTimer.Tick += monitoringTimer_Tick;
            // 
            // cardPending
            // 
            cardPending.BackColor = Color.White;
            cardPending.CardTitle = "Reinicio pendiente";
            cardPending.CardType = StatusCardType.Warning;
            cardPending.CardValue = "0";
            cardPending.Dock = DockStyle.Fill;
            cardPending.ForeColor = Color.FromArgb(25, 29, 35);
            cardPending.Location = new Point(458, 12);
            cardPending.Margin = new Padding(8);
            cardPending.Name = "cardPending";
            cardPending.Size = new Size(209, 97);
            cardPending.TabIndex = 16;
            // 
            // pnlMain
            // 
            pnlMain.BackColor = Color.Transparent;
            pnlMain.Controls.Add(dgvPendingDevices);
            pnlMain.Controls.Add(pnlControls);
            pnlMain.Controls.Add(tlpStatusCards);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(0, 130);
            pnlMain.Name = "pnlMain";
            pnlMain.Padding = new Padding(28, 0, 28, 24);
            pnlMain.Size = new Size(1184, 570);
            pnlMain.TabIndex = 17;
            pnlMain.Paint += MainForm_Paint;
            // 
            // dgvPendingDevices
            // 
            dgvPendingDevices.AllowUserToAddRows = false;
            dgvPendingDevices.AllowUserToDeleteRows = false;
            dgvPendingDevices.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(250, 250, 250);
            dgvPendingDevices.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvPendingDevices.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPendingDevices.BackgroundColor = Color.White;
            dgvPendingDevices.BorderStyle = BorderStyle.None;
            dgvPendingDevices.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(190, 225, 245);
            dataGridViewCellStyle2.Font = new Font("Segoe UI Variable Small Semibol", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.Padding = new Padding(8, 0, 8, 0);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(190, 225, 245);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvPendingDevices.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvPendingDevices.ColumnHeadersHeight = 44;
            dgvPendingDevices.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvPendingDevices.Columns.AddRange(new DataGridViewColumn[] { colDevice, colAddress, colUptime, colReason, colLastCheck });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(245, 248, 250);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(51, 51, 51);
            dataGridViewCellStyle3.Padding = new Padding(8, 0, 8, 0);
            dataGridViewCellStyle3.SelectionBackColor = Color.WhiteSmoke;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvPendingDevices.DefaultCellStyle = dataGridViewCellStyle3;
            dgvPendingDevices.Dock = DockStyle.Fill;
            dgvPendingDevices.EnableHeadersVisualStyles = false;
            dgvPendingDevices.GridColor = Color.White;
            dgvPendingDevices.Location = new Point(28, 265);
            dgvPendingDevices.MultiSelect = false;
            dgvPendingDevices.Name = "dgvPendingDevices";
            dgvPendingDevices.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(190, 225, 245);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvPendingDevices.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvPendingDevices.RowHeadersVisible = false;
            dgvPendingDevices.RowTemplate.Height = 42;
            dgvPendingDevices.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPendingDevices.Size = new Size(1128, 281);
            dgvPendingDevices.TabIndex = 8;
            // 
            // colDevice
            // 
            colDevice.HeaderText = "Equipo";
            colDevice.Name = "colDevice";
            colDevice.ReadOnly = true;
            // 
            // colAddress
            // 
            colAddress.HeaderText = "Direccion";
            colAddress.Name = "colAddress";
            colAddress.ReadOnly = true;
            // 
            // colUptime
            // 
            colUptime.HeaderText = "Tiempo encendido";
            colUptime.Name = "colUptime";
            colUptime.ReadOnly = true;
            // 
            // colReason
            // 
            colReason.HeaderText = "Motivo";
            colReason.Name = "colReason";
            colReason.ReadOnly = true;
            // 
            // colLastCheck
            // 
            colLastCheck.HeaderText = "Ultima consulta";
            colLastCheck.Name = "colLastCheck";
            colLastCheck.ReadOnly = true;
            // 
            // pnlControls
            // 
            pnlControls.BackColor = Color.Transparent;
            pnlControls.Controls.Add(tlpControls);
            pnlControls.Dock = DockStyle.Top;
            pnlControls.Location = new Point(28, 125);
            pnlControls.Margin = new Padding(0);
            pnlControls.Name = "pnlControls";
            pnlControls.Padding = new Padding(16, 10, 16, 10);
            pnlControls.Size = new Size(1128, 140);
            pnlControls.TabIndex = 10;
            // 
            // tlpControls
            // 
            tlpControls.ColumnCount = 3;
            tlpControls.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.25146F));
            tlpControls.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.7402058F));
            tlpControls.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 52.0083351F));
            tlpControls.Controls.Add(flpAction, 0, 0);
            tlpControls.Controls.Add(flpAction2, 0, 1);
            tlpControls.Controls.Add(flpAction3, 0, 2);
            tlpControls.Controls.Add(fplprogress, 2, 1);
            tlpControls.Controls.Add(flpMonitoring, 1, 0);
            tlpControls.Controls.Add(flpMonitoring2, 1, 1);
            tlpControls.Controls.Add(flpMonitoring3, 1, 2);
            tlpControls.Controls.Add(fplProgress2, 2, 2);
            tlpControls.Dock = DockStyle.Fill;
            tlpControls.Location = new Point(16, 10);
            tlpControls.Margin = new Padding(0);
            tlpControls.Name = "tlpControls";
            tlpControls.RowCount = 3;
            tlpControls.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tlpControls.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tlpControls.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tlpControls.Size = new Size(1096, 120);
            tlpControls.TabIndex = 25;
            // 
            // flpAction
            // 
            flpAction.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flpAction.BackColor = Color.Transparent;
            flpAction.Controls.Add(btnScan);
            flpAction.Dock = DockStyle.Fill;
            flpAction.Location = new Point(0, 0);
            flpAction.Margin = new Padding(0);
            flpAction.Name = "flpAction";
            flpAction.Padding = new Padding(4);
            flpAction.Size = new Size(243, 39);
            flpAction.TabIndex = 18;
            flpAction.WrapContents = false;
            // 
            // btnScan
            // 
            btnScan.BackColor = Color.FromArgb(0, 120, 212);
            btnScan.Cursor = Cursors.Hand;
            btnScan.FlatAppearance.BorderSize = 0;
            btnScan.FlatStyle = FlatStyle.Flat;
            btnScan.Font = new Font("Bahnschrift", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnScan.ForeColor = Color.White;
            btnScan.Location = new Point(4, 6);
            btnScan.Margin = new Padding(0, 2, 6, 2);
            btnScan.Name = "btnScan";
            btnScan.Size = new Size(170, 28);
            btnScan.TabIndex = 7;
            btnScan.Text = "Actualizar ahora";
            btnScan.UseVisualStyleBackColor = false;
            btnScan.Click += btnScan_Click;
            // 
            // flpAction2
            // 
            flpAction2.BackColor = Color.Transparent;
            flpAction2.Controls.Add(btnManageDevices);
            flpAction2.Dock = DockStyle.Fill;
            flpAction2.Location = new Point(0, 39);
            flpAction2.Margin = new Padding(0);
            flpAction2.Name = "flpAction2";
            flpAction2.Padding = new Padding(4);
            flpAction2.Size = new Size(243, 39);
            flpAction2.TabIndex = 22;
            // 
            // btnManageDevices
            // 
            btnManageDevices.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnManageDevices.BackColor = Color.White;
            btnManageDevices.Cursor = Cursors.Hand;
            btnManageDevices.FlatAppearance.BorderColor = Color.FromArgb(0, 120, 212);
            btnManageDevices.FlatStyle = FlatStyle.Flat;
            btnManageDevices.Font = new Font("Bahnschrift", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnManageDevices.ForeColor = Color.FromArgb(45, 55, 72);
            btnManageDevices.Location = new Point(4, 6);
            btnManageDevices.Margin = new Padding(0, 2, 6, 2);
            btnManageDevices.Name = "btnManageDevices";
            btnManageDevices.Size = new Size(170, 28);
            btnManageDevices.TabIndex = 25;
            btnManageDevices.Text = "Administrar equipos";
            btnManageDevices.UseVisualStyleBackColor = false;
            // 
            // flpAction3
            // 
            flpAction3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flpAction3.Controls.Add(btnViewUnavailable);
            flpAction3.Dock = DockStyle.Fill;
            flpAction3.Location = new Point(0, 78);
            flpAction3.Margin = new Padding(0);
            flpAction3.Name = "flpAction3";
            flpAction3.Padding = new Padding(4);
            flpAction3.Size = new Size(243, 42);
            flpAction3.TabIndex = 27;
            flpAction3.WrapContents = false;
            // 
            // btnViewUnavailable
            // 
            btnViewUnavailable.AutoSize = true;
            btnViewUnavailable.BackColor = Color.White;
            btnViewUnavailable.Cursor = Cursors.Hand;
            btnViewUnavailable.FlatAppearance.BorderColor = Color.FromArgb(0, 120, 212);
            btnViewUnavailable.FlatStyle = FlatStyle.Flat;
            btnViewUnavailable.Font = new Font("Bahnschrift", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnViewUnavailable.ForeColor = Color.FromArgb(45, 55, 72);
            btnViewUnavailable.Location = new Point(4, 6);
            btnViewUnavailable.Margin = new Padding(0, 2, 0, 2);
            btnViewUnavailable.Name = "btnViewUnavailable";
            btnViewUnavailable.Size = new Size(170, 28);
            btnViewUnavailable.TabIndex = 27;
            btnViewUnavailable.Text = "Equipos no disponibles";
            btnViewUnavailable.UseVisualStyleBackColor = false;
            // 
            // fplprogress
            // 
            fplprogress.BackColor = Color.Transparent;
            fplprogress.Controls.Add(lblScanStatus);
            fplprogress.Dock = DockStyle.Fill;
            fplprogress.Location = new Point(525, 39);
            fplprogress.Margin = new Padding(0);
            fplprogress.Name = "fplprogress";
            fplprogress.Padding = new Padding(4);
            fplprogress.Size = new Size(571, 39);
            fplprogress.TabIndex = 23;
            fplprogress.WrapContents = false;
            // 
            // lblScanStatus
            // 
            lblScanStatus.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblScanStatus.AutoSize = true;
            lblScanStatus.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblScanStatus.Location = new Point(7, 4);
            lblScanStatus.Name = "lblScanStatus";
            lblScanStatus.Size = new Size(123, 17);
            lblScanStatus.TabIndex = 26;
            lblScanStatus.Text = "Listo para consultar";
            // 
            // flpMonitoring
            // 
            flpMonitoring.BackColor = Color.Transparent;
            flpMonitoring.Controls.Add(lblautoMonitor);
            flpMonitoring.Dock = DockStyle.Fill;
            flpMonitoring.Location = new Point(243, 0);
            flpMonitoring.Margin = new Padding(0);
            flpMonitoring.Name = "flpMonitoring";
            flpMonitoring.Padding = new Padding(4);
            flpMonitoring.Size = new Size(282, 39);
            flpMonitoring.TabIndex = 24;
            flpMonitoring.WrapContents = false;
            // 
            // lblautoMonitor
            // 
            lblautoMonitor.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblautoMonitor.AutoSize = true;
            lblautoMonitor.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblautoMonitor.Location = new Point(7, 4);
            lblautoMonitor.Name = "lblautoMonitor";
            lblautoMonitor.Size = new Size(196, 17);
            lblautoMonitor.TabIndex = 19;
            lblautoMonitor.Text = "Monitoreo automático: Activado";
            // 
            // flpMonitoring2
            // 
            flpMonitoring2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flpMonitoring2.Controls.Add(lblIntervalText);
            flpMonitoring2.Controls.Add(cmbInterval);
            flpMonitoring2.Dock = DockStyle.Fill;
            flpMonitoring2.Location = new Point(243, 39);
            flpMonitoring2.Margin = new Padding(0);
            flpMonitoring2.Name = "flpMonitoring2";
            flpMonitoring2.Padding = new Padding(4);
            flpMonitoring2.Size = new Size(282, 39);
            flpMonitoring2.TabIndex = 26;
            flpMonitoring2.WrapContents = false;
            // 
            // lblIntervalText
            // 
            lblIntervalText.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblIntervalText.AutoSize = true;
            lblIntervalText.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblIntervalText.Location = new Point(7, 4);
            lblIntervalText.Name = "lblIntervalText";
            lblIntervalText.Size = new Size(61, 17);
            lblIntervalText.TabIndex = 21;
            lblIntervalText.Text = "Intervalo:";
            // 
            // cmbInterval
            // 
            cmbInterval.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cmbInterval.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbInterval.FormattingEnabled = true;
            cmbInterval.Items.AddRange(new object[] { "2 horas", "4 horas", "6 horas", "8 horas", "12 horas" });
            cmbInterval.Location = new Point(74, 7);
            cmbInterval.Name = "cmbInterval";
            cmbInterval.Size = new Size(100, 23);
            cmbInterval.TabIndex = 22;
            // 
            // flpMonitoring3
            // 
            flpMonitoring3.Controls.Add(lblNextScan);
            flpMonitoring3.Dock = DockStyle.Fill;
            flpMonitoring3.Location = new Point(243, 78);
            flpMonitoring3.Margin = new Padding(0);
            flpMonitoring3.Name = "flpMonitoring3";
            flpMonitoring3.Padding = new Padding(4);
            flpMonitoring3.Size = new Size(282, 42);
            flpMonitoring3.TabIndex = 28;
            flpMonitoring3.WrapContents = false;
            // 
            // lblNextScan
            // 
            lblNextScan.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblNextScan.AutoSize = true;
            lblNextScan.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNextScan.Location = new Point(7, 4);
            lblNextScan.Name = "lblNextScan";
            lblNextScan.Size = new Size(137, 17);
            lblNextScan.TabIndex = 22;
            lblNextScan.Text = "Próxima consulta: --:--";
            // 
            // fplProgress2
            // 
            fplProgress2.Controls.Add(prgScan);
            fplProgress2.Dock = DockStyle.Fill;
            fplProgress2.Location = new Point(525, 78);
            fplProgress2.Margin = new Padding(0);
            fplProgress2.Name = "fplProgress2";
            fplProgress2.Padding = new Padding(4);
            fplProgress2.Size = new Size(571, 42);
            fplProgress2.TabIndex = 29;
            fplProgress2.WrapContents = false;
            // 
            // prgScan
            // 
            prgScan.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            prgScan.Location = new Point(8, 6);
            prgScan.Margin = new Padding(4, 2, 4, 4);
            prgScan.Name = "prgScan";
            prgScan.Size = new Size(1088, 10);
            prgScan.TabIndex = 23;
            // 
            // tlpStatusCards
            // 
            tlpStatusCards.ColumnCount = 5;
            tlpStatusCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlpStatusCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlpStatusCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlpStatusCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlpStatusCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlpStatusCards.Controls.Add(cardUnverified, 4, 0);
            tlpStatusCards.Controls.Add(cardUnavailable, 3, 0);
            tlpStatusCards.Controls.Add(cardChecked, 1, 0);
            tlpStatusCards.Controls.Add(cardConfigured, 0, 0);
            tlpStatusCards.Controls.Add(cardPending, 2, 0);
            tlpStatusCards.Dock = DockStyle.Top;
            tlpStatusCards.Location = new Point(28, 0);
            tlpStatusCards.Margin = new Padding(0);
            tlpStatusCards.Name = "tlpStatusCards";
            tlpStatusCards.Padding = new Padding(0, 4, 0, 8);
            tlpStatusCards.RowCount = 1;
            tlpStatusCards.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpStatusCards.Size = new Size(1128, 125);
            tlpStatusCards.TabIndex = 9;
            // 
            // cardUnverified
            // 
            cardUnverified.BackColor = Color.White;
            cardUnverified.CardTitle = "Sin verificar";
            cardUnverified.CardType = StatusCardType.Unverified;
            cardUnverified.CardValue = "0";
            cardUnverified.Dock = DockStyle.Fill;
            cardUnverified.ForeColor = Color.FromArgb(25, 29, 35);
            cardUnverified.Location = new Point(908, 12);
            cardUnverified.Margin = new Padding(8);
            cardUnverified.Name = "cardUnverified";
            cardUnverified.Size = new Size(212, 97);
            cardUnverified.TabIndex = 20;
            // 
            // cardUnavailable
            // 
            cardUnavailable.BackColor = Color.White;
            cardUnavailable.CardTitle = "No disponible";
            cardUnavailable.CardType = StatusCardType.Danger;
            cardUnavailable.CardValue = "0";
            cardUnavailable.Dock = DockStyle.Fill;
            cardUnavailable.ForeColor = Color.FromArgb(25, 29, 35);
            cardUnavailable.Location = new Point(683, 12);
            cardUnavailable.Margin = new Padding(8);
            cardUnavailable.Name = "cardUnavailable";
            cardUnavailable.Size = new Size(209, 97);
            cardUnavailable.TabIndex = 19;
            // 
            // cardChecked
            // 
            cardChecked.BackColor = Color.White;
            cardChecked.CardTitle = "Equipos consultados";
            cardChecked.CardType = StatusCardType.Success;
            cardChecked.CardValue = "0";
            cardChecked.Dock = DockStyle.Fill;
            cardChecked.ForeColor = Color.FromArgb(25, 29, 35);
            cardChecked.Location = new Point(233, 12);
            cardChecked.Margin = new Padding(8);
            cardChecked.Name = "cardChecked";
            cardChecked.Size = new Size(209, 97);
            cardChecked.TabIndex = 18;
            // 
            // cardConfigured
            // 
            cardConfigured.BackColor = Color.White;
            cardConfigured.CardTitle = "Equipos configurados";
            cardConfigured.CardType = StatusCardType.Neutral;
            cardConfigured.CardValue = "0";
            cardConfigured.Dock = DockStyle.Fill;
            cardConfigured.ForeColor = Color.FromArgb(25, 29, 35);
            cardConfigured.Location = new Point(8, 12);
            cardConfigured.Margin = new Padding(8);
            cardConfigured.Name = "cardConfigured";
            cardConfigured.Size = new Size(209, 97);
            cardConfigured.TabIndex = 17;
            // 
            // pnlTitleBar
            // 
            pnlTitleBar.BackColor = Color.FromArgb(25, 43, 70);
            pnlTitleBar.Controls.Add(btnMinimize);
            pnlTitleBar.Controls.Add(btnMaximize);
            pnlTitleBar.Controls.Add(btnClose);
            pnlTitleBar.Controls.Add(lblTitleBar);
            pnlTitleBar.Dock = DockStyle.Top;
            pnlTitleBar.Location = new Point(0, 0);
            pnlTitleBar.Name = "pnlTitleBar";
            pnlTitleBar.Size = new Size(1184, 42);
            pnlTitleBar.TabIndex = 21;
            pnlTitleBar.MouseDown += pnlTitleBar_MouseDown;
            // 
            // btnMinimize
            // 
            btnMinimize.Cursor = Cursors.Hand;
            btnMinimize.Dock = DockStyle.Right;
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMinimize.ForeColor = Color.White;
            btnMinimize.Location = new Point(1046, 0);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(46, 42);
            btnMinimize.TabIndex = 3;
            btnMinimize.TabStop = false;
            btnMinimize.Text = "__";
            btnMinimize.UseVisualStyleBackColor = true;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // btnMaximize
            // 
            btnMaximize.Cursor = Cursors.Hand;
            btnMaximize.Dock = DockStyle.Right;
            btnMaximize.FlatAppearance.BorderSize = 0;
            btnMaximize.FlatStyle = FlatStyle.Flat;
            btnMaximize.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMaximize.ForeColor = Color.White;
            btnMaximize.Location = new Point(1092, 0);
            btnMaximize.Name = "btnMaximize";
            btnMaximize.Size = new Size(46, 42);
            btnMaximize.TabIndex = 2;
            btnMaximize.TabStop = false;
            btnMaximize.Text = "□";
            btnMaximize.UseVisualStyleBackColor = true;
            btnMaximize.Click += btnMaximize_Click;
            // 
            // btnClose
            // 
            btnClose.Cursor = Cursors.Hand;
            btnClose.Dock = DockStyle.Right;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(1138, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(46, 42);
            btnClose.TabIndex = 1;
            btnClose.TabStop = false;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // lblTitleBar
            // 
            lblTitleBar.AutoSize = true;
            lblTitleBar.BackColor = Color.Transparent;
            lblTitleBar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitleBar.ForeColor = Color.White;
            lblTitleBar.Location = new Point(40, 11);
            lblTitleBar.Name = "lblTitleBar";
            lblTitleBar.Size = new Size(115, 17);
            lblTitleBar.TabIndex = 0;
            lblTitleBar.Text = "ITDeviceManager";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(1184, 700);
            Controls.Add(pnlMain);
            Controls.Add(pnlHeader);
            Controls.Add(pnlTitleBar);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(1100, 700);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ITDeviceManager";
            WindowState = FormWindowState.Maximized;
            Load += MainForm_Load;
            Shown += MainForm_Shown;
            Paint += MainForm_Paint;
            pnlHeader.ResumeLayout(false);
            pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPendingDevices).EndInit();
            pnlControls.ResumeLayout(false);
            tlpControls.ResumeLayout(false);
            flpAction.ResumeLayout(false);
            flpAction2.ResumeLayout(false);
            flpAction3.ResumeLayout(false);
            flpAction3.PerformLayout();
            fplprogress.ResumeLayout(false);
            fplprogress.PerformLayout();
            flpMonitoring.ResumeLayout(false);
            flpMonitoring.PerformLayout();
            flpMonitoring2.ResumeLayout(false);
            flpMonitoring2.PerformLayout();
            flpMonitoring3.ResumeLayout(false);
            flpMonitoring3.PerformLayout();
            fplProgress2.ResumeLayout(false);
            tlpStatusCards.ResumeLayout(false);
            pnlTitleBar.ResumeLayout(false);
            pnlTitleBar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Label lblTitle;
        private System.Windows.Forms.Timer monitoringTimer;
        private StatusCard cardPending;
        private Panel pnlMain;
        private DataGridView dgvPendingDevices;
        private DataGridViewTextBoxColumn colDevice;
        private DataGridViewTextBoxColumn colAddress;
        private DataGridViewTextBoxColumn colUptime;
        private DataGridViewTextBoxColumn colReason;
        private DataGridViewTextBoxColumn colLastCheck;
        private TableLayoutPanel tlpStatusCards;
        private StatusCard cardUnverified;
        private StatusCard cardUnavailable;
        private StatusCard cardChecked;
        private StatusCard cardConfigured;
        private Panel pnlControls;
        private TableLayoutPanel tlpControls;
        private FlowLayoutPanel flpAction;
        private FlowLayoutPanel flpAction2;
        private Button btnScan;
        private FlowLayoutPanel flpScanStatus;
        private FlowLayoutPanel fplprogress;
        private FlowLayoutPanel flpMonitoring;
        private Panel pnlTitleBar;
        private Button btnClose;
        private Label lblTitleBar;
        private Button btnMaximize;
        private Button btnMinimize;
        private Button btnManageDevices;
        private Label lblautoMonitor;
        private FlowLayoutPanel flpMonitoring2;
        private Label lblIntervalText;
        private ComboBox cmbInterval;
        private FlowLayoutPanel flpAction3;
        private Button btnViewUnavailable;
        private FlowLayoutPanel flpMonitoring3;
        private Label lblNextScan;
        private Label lblScanStatus;
        private FlowLayoutPanel fplProgress2;
        private ProgressBar prgScan;
    }
}
