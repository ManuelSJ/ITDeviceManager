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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
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
            dgvUnavailableDevices.BackgroundColor = Color.White;
            dgvUnavailableDevices.BorderStyle = BorderStyle.None;
            dgvUnavailableDevices.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(190, 225, 245);
            dataGridViewCellStyle1.Font = new Font("Segoe UI Variable Small Semibol", 9.75F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(190, 225, 245);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvUnavailableDevices.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvUnavailableDevices.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUnavailableDevices.Columns.AddRange(new DataGridViewColumn[] { colDevice, colAddress });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(245, 248, 250);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(51, 51, 51);
            dataGridViewCellStyle2.Padding = new Padding(8, 0, 8, 0);
            dataGridViewCellStyle2.SelectionBackColor = Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvUnavailableDevices.DefaultCellStyle = dataGridViewCellStyle2;
            dgvUnavailableDevices.Dock = DockStyle.Fill;
            dgvUnavailableDevices.EnableHeadersVisualStyles = false;
            dgvUnavailableDevices.GridColor = Color.White;
            dgvUnavailableDevices.Location = new Point(0, 0);
            dgvUnavailableDevices.Name = "dgvUnavailableDevices";
            dgvUnavailableDevices.RowHeadersVisible = false;
            dgvUnavailableDevices.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUnavailableDevices.Size = new Size(384, 461);
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
            ClientSize = new Size(384, 461);
            Controls.Add(dgvUnavailableDevices);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "UnavailableDevicesForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Equipos no disponibles";
            ((System.ComponentModel.ISupportInitialize)dgvUnavailableDevices).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvUnavailableDevices;
        private DataGridViewTextBoxColumn colDevice;
        private DataGridViewTextBoxColumn colAddress;
    }
}