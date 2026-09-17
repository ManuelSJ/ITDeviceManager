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
            pnlHeader = new Panel();
            lblTitle = new Label();
            pnlConfigured = new Panel();
            lblConfiguredText = new Label();
            lblConfiguredCount = new Label();
            pnlChecked = new Panel();
            lblCheckedText = new Label();
            lblCheckedCount = new Label();
            pnlPending = new Panel();
            lblPendingText = new Label();
            lblPendingCount = new Label();
            pnlUnavailable = new Panel();
            lblUnavailableText = new Label();
            lblUnavailableCount = new Label();
            btnScan = new Button();
            lblScanStatus = new Label();
            prgScan = new ProgressBar();
            dgvPendingDevice = new DataGridView();
            colDevice = new DataGridViewTextBoxColumn();
            colAddress = new DataGridViewTextBoxColumn();
            colUptime = new DataGridViewTextBoxColumn();
            colReason = new DataGridViewTextBoxColumn();
            colLastCheck = new DataGridViewTextBoxColumn();
            tlpStats = new TableLayoutPanel();
            lblautoMonitor = new Label();
            lblIntervalText = new Label();
            cmbInterval = new ComboBox();
            lblNextScan = new Label();
            pnlHeader.SuspendLayout();
            pnlConfigured.SuspendLayout();
            pnlChecked.SuspendLayout();
            pnlPending.SuspendLayout();
            pnlUnavailable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPendingDevice).BeginInit();
            tlpStats.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1184, 80);
            pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(1184, 80);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "ITDeviceManager";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlConfigured
            // 
            pnlConfigured.Controls.Add(lblConfiguredText);
            pnlConfigured.Controls.Add(lblConfiguredCount);
            pnlConfigured.Dock = DockStyle.Fill;
            pnlConfigured.Location = new Point(3, 3);
            pnlConfigured.Name = "pnlConfigured";
            pnlConfigured.Size = new Size(283, 84);
            pnlConfigured.TabIndex = 1;
            // 
            // lblConfiguredText
            // 
            lblConfiguredText.AutoSize = true;
            lblConfiguredText.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblConfiguredText.Location = new Point(23, 46);
            lblConfiguredText.Name = "lblConfiguredText";
            lblConfiguredText.Size = new Size(136, 17);
            lblConfiguredText.TabIndex = 1;
            lblConfiguredText.Text = "Equipos configurados";
            // 
            // lblConfiguredCount
            // 
            lblConfiguredCount.AutoSize = true;
            lblConfiguredCount.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblConfiguredCount.Location = new Point(23, 14);
            lblConfiguredCount.Name = "lblConfiguredCount";
            lblConfiguredCount.Size = new Size(28, 32);
            lblConfiguredCount.TabIndex = 0;
            lblConfiguredCount.Text = "0";
            // 
            // pnlChecked
            // 
            pnlChecked.Controls.Add(lblCheckedText);
            pnlChecked.Controls.Add(lblCheckedCount);
            pnlChecked.Dock = DockStyle.Fill;
            pnlChecked.Location = new Point(292, 3);
            pnlChecked.Name = "pnlChecked";
            pnlChecked.Size = new Size(283, 84);
            pnlChecked.TabIndex = 2;
            // 
            // lblCheckedText
            // 
            lblCheckedText.AutoSize = true;
            lblCheckedText.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCheckedText.Location = new Point(23, 46);
            lblCheckedText.Name = "lblCheckedText";
            lblCheckedText.Size = new Size(129, 17);
            lblCheckedText.TabIndex = 1;
            lblCheckedText.Text = "Equipos consultados";
            // 
            // lblCheckedCount
            // 
            lblCheckedCount.AutoSize = true;
            lblCheckedCount.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCheckedCount.Location = new Point(23, 14);
            lblCheckedCount.Name = "lblCheckedCount";
            lblCheckedCount.Size = new Size(28, 32);
            lblCheckedCount.TabIndex = 0;
            lblCheckedCount.Text = "0";
            // 
            // pnlPending
            // 
            pnlPending.Controls.Add(lblPendingText);
            pnlPending.Controls.Add(lblPendingCount);
            pnlPending.Dock = DockStyle.Fill;
            pnlPending.Location = new Point(581, 3);
            pnlPending.Name = "pnlPending";
            pnlPending.Size = new Size(283, 84);
            pnlPending.TabIndex = 3;
            // 
            // lblPendingText
            // 
            lblPendingText.AutoSize = true;
            lblPendingText.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPendingText.Location = new Point(23, 46);
            lblPendingText.Name = "lblPendingText";
            lblPendingText.Size = new Size(115, 17);
            lblPendingText.TabIndex = 1;
            lblPendingText.Text = "Reinicio pendiente";
            // 
            // lblPendingCount
            // 
            lblPendingCount.AutoSize = true;
            lblPendingCount.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPendingCount.Location = new Point(23, 14);
            lblPendingCount.Name = "lblPendingCount";
            lblPendingCount.Size = new Size(28, 32);
            lblPendingCount.TabIndex = 0;
            lblPendingCount.Text = "0";
            // 
            // pnlUnavailable
            // 
            pnlUnavailable.Controls.Add(lblUnavailableText);
            pnlUnavailable.Controls.Add(lblUnavailableCount);
            pnlUnavailable.Dock = DockStyle.Fill;
            pnlUnavailable.Location = new Point(870, 3);
            pnlUnavailable.Name = "pnlUnavailable";
            pnlUnavailable.Size = new Size(284, 84);
            pnlUnavailable.TabIndex = 2;
            // 
            // lblUnavailableText
            // 
            lblUnavailableText.AutoSize = true;
            lblUnavailableText.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUnavailableText.Location = new Point(23, 46);
            lblUnavailableText.Name = "lblUnavailableText";
            lblUnavailableText.Size = new Size(97, 17);
            lblUnavailableText.TabIndex = 1;
            lblUnavailableText.Text = "No disponibles";
            // 
            // lblUnavailableCount
            // 
            lblUnavailableCount.AutoSize = true;
            lblUnavailableCount.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUnavailableCount.Location = new Point(23, 14);
            lblUnavailableCount.Name = "lblUnavailableCount";
            lblUnavailableCount.Size = new Size(28, 32);
            lblUnavailableCount.TabIndex = 0;
            lblUnavailableCount.Text = "0";
            // 
            // btnScan
            // 
            btnScan.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnScan.Location = new Point(12, 182);
            btnScan.Name = "btnScan";
            btnScan.Size = new Size(170, 40);
            btnScan.TabIndex = 4;
            btnScan.Text = "Actualizar ahora";
            btnScan.UseVisualStyleBackColor = true;
            // 
            // lblScanStatus
            // 
            lblScanStatus.AutoSize = true;
            lblScanStatus.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblScanStatus.Location = new Point(188, 193);
            lblScanStatus.Name = "lblScanStatus";
            lblScanStatus.Size = new Size(123, 17);
            lblScanStatus.TabIndex = 5;
            lblScanStatus.Text = "Listo para consultar";
            // 
            // prgScan
            // 
            prgScan.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            prgScan.Location = new Point(15, 228);
            prgScan.Name = "prgScan";
            prgScan.Size = new Size(500, 20);
            prgScan.TabIndex = 6;
            // 
            // dgvPendingDevice
            // 
            dgvPendingDevice.AllowUserToAddRows = false;
            dgvPendingDevice.AllowUserToDeleteRows = false;
            dgvPendingDevice.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvPendingDevice.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPendingDevice.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPendingDevice.Columns.AddRange(new DataGridViewColumn[] { colDevice, colAddress, colUptime, colReason, colLastCheck });
            dgvPendingDevice.Location = new Point(12, 294);
            dgvPendingDevice.MultiSelect = false;
            dgvPendingDevice.Name = "dgvPendingDevice";
            dgvPendingDevice.ReadOnly = true;
            dgvPendingDevice.RowHeadersVisible = false;
            dgvPendingDevice.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPendingDevice.Size = new Size(1160, 355);
            dgvPendingDevice.TabIndex = 7;
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
            // tlpStats
            // 
            tlpStats.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tlpStats.ColumnCount = 4;
            tlpStats.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpStats.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpStats.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpStats.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpStats.Controls.Add(pnlConfigured, 0, 0);
            tlpStats.Controls.Add(pnlChecked, 1, 0);
            tlpStats.Controls.Add(pnlPending, 2, 0);
            tlpStats.Controls.Add(pnlUnavailable, 3, 0);
            tlpStats.Location = new Point(15, 86);
            tlpStats.Name = "tlpStats";
            tlpStats.RowCount = 1;
            tlpStats.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpStats.Size = new Size(1157, 90);
            tlpStats.TabIndex = 8;
            // 
            // lblautoMonitor
            // 
            lblautoMonitor.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblautoMonitor.AutoSize = true;
            lblautoMonitor.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblautoMonitor.Location = new Point(522, 194);
            lblautoMonitor.Name = "lblautoMonitor";
            lblautoMonitor.Size = new Size(196, 17);
            lblautoMonitor.TabIndex = 9;
            lblautoMonitor.Text = "Monitoreo automático: Activado";
            // 
            // lblIntervalText
            // 
            lblIntervalText.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblIntervalText.AutoSize = true;
            lblIntervalText.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblIntervalText.Location = new Point(733, 194);
            lblIntervalText.Name = "lblIntervalText";
            lblIntervalText.Size = new Size(61, 17);
            lblIntervalText.TabIndex = 10;
            lblIntervalText.Text = "Intervalo:";
            // 
            // cmbInterval
            // 
            cmbInterval.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cmbInterval.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbInterval.FormattingEnabled = true;
            cmbInterval.Items.AddRange(new object[] { "2 horas", "4 horas", "6 horas", "8 horas", "12 horas" });
            cmbInterval.Location = new Point(793, 192);
            cmbInterval.Name = "cmbInterval";
            cmbInterval.Size = new Size(100, 23);
            cmbInterval.TabIndex = 11;
            // 
            // lblNextScan
            // 
            lblNextScan.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblNextScan.AutoSize = true;
            lblNextScan.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNextScan.Location = new Point(522, 228);
            lblNextScan.Name = "lblNextScan";
            lblNextScan.Size = new Size(137, 17);
            lblNextScan.TabIndex = 12;
            lblNextScan.Text = "Próxima consulta: --:--";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 661);
            Controls.Add(lblNextScan);
            Controls.Add(cmbInterval);
            Controls.Add(lblIntervalText);
            Controls.Add(lblautoMonitor);
            Controls.Add(tlpStats);
            Controls.Add(dgvPendingDevice);
            Controls.Add(prgScan);
            Controls.Add(lblScanStatus);
            Controls.Add(btnScan);
            Controls.Add(pnlHeader);
            MinimumSize = new Size(1100, 650);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ITDeviceManager";
            pnlHeader.ResumeLayout(false);
            pnlConfigured.ResumeLayout(false);
            pnlConfigured.PerformLayout();
            pnlChecked.ResumeLayout(false);
            pnlChecked.PerformLayout();
            pnlPending.ResumeLayout(false);
            pnlPending.PerformLayout();
            pnlUnavailable.ResumeLayout(false);
            pnlUnavailable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPendingDevice).EndInit();
            tlpStats.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlHeader;
        private Label lblTitle;
        private Panel pnlConfigured;
        private Label lblConfiguredText;
        private Label lblConfiguredCount;
        private Panel pnlChecked;
        private Label lblCheckedText;
        private Label lblCheckedCount;
        private Panel pnlPending;
        private Label lblPendingText;
        private Label lblPendingCount;
        private Panel pnlUnavailable;
        private Label lblUnavailableText;
        private Label lblUnavailableCount;
        private Button btnScan;
        private Label lblScanStatus;
        private ProgressBar prgScan;
        private DataGridView dgvPendingDevice;
        private DataGridViewTextBoxColumn colDevice;
        private DataGridViewTextBoxColumn colAddress;
        private DataGridViewTextBoxColumn colUptime;
        private DataGridViewTextBoxColumn colReason;
        private DataGridViewTextBoxColumn colLastCheck;
        private TableLayoutPanel tlpStats;
        private Label lblautoMonitor;
        private Label lblIntervalText;
        private ComboBox cmbInterval;
        private Label lblNextScan;
    }
}
