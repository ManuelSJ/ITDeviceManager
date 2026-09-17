namespace ITDeviceManager
{
    partial class UnavailableDevicesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvUnavailableDevices = new DataGridView();
            colDevice = new DataGridViewTextBoxColumn();
            colAddress = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvUnavailableDevices).BeginInit();
            SuspendLayout();
            // 
            // dgvUnavailableDevices
            // 
            dgvUnavailableDevices.AllowUserToAddRows = false;
            dgvUnavailableDevices.AllowUserToDeleteRows = false;
            dgvUnavailableDevices.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUnavailableDevices.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUnavailableDevices.Columns.AddRange(new DataGridViewColumn[] { colDevice, colAddress });
            dgvUnavailableDevices.Dock = DockStyle.Fill;
            dgvUnavailableDevices.Location = new Point(0, 0);
            dgvUnavailableDevices.Name = "dgvUnavailableDevices";
            dgvUnavailableDevices.RowHeadersVisible = false;
            dgvUnavailableDevices.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUnavailableDevices.Size = new Size(384, 161);
            dgvUnavailableDevices.TabIndex = 0;
            // 
            // colDevice
            // 
            colDevice.HeaderText = "Equipo";
            colDevice.Name = "colDevice";
            // 
            // colAddress
            // 
            colAddress.HeaderText = "Dirección";
            colAddress.Name = "colAddress";
            // 
            // UnavailableDevicesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 161);
            Controls.Add(dgvUnavailableDevices);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "UnavailableDevicesForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Equipos no disponibles";
            Load += UnavailableDevicesForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUnavailableDevices).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvUnavailableDevices;
        private DataGridViewTextBoxColumn colDevice;
        private DataGridViewTextBoxColumn colAddress;
    }
}