namespace ITDeviceManager
{
    partial class ManageDevicesForm
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
            lblTitle = new Label();
            lblInstructions = new Label();
            lblDevices = new Label();
            btnAdd = new Button();
            btnClear = new Button();
            btnImport = new Button();
            openFileDialogDevices = new OpenFileDialog();
            pnlDevices = new Panel();
            txtDevices = new TextBox();
            pnlDevices.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(0, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(534, 45);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Administracion de equipos";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblInstructions
            // 
            lblInstructions.AutoSize = true;
            lblInstructions.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInstructions.ForeColor = Color.White;
            lblInstructions.Location = new Point(15, 103);
            lblInstructions.Name = "lblInstructions";
            lblInstructions.Size = new Size(353, 17);
            lblInstructions.TabIndex = 1;
            lblInstructions.Text = "Ingresa el nombre del equipo o dirección IP, uno por línea.";
            // 
            // lblDevices
            // 
            lblDevices.AutoSize = true;
            lblDevices.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDevices.ForeColor = Color.White;
            lblDevices.Location = new Point(444, 103);
            lblDevices.Name = "lblDevices";
            lblDevices.Size = new Size(78, 17);
            lblDevices.TabIndex = 2;
            lblDevices.Text = "Equipos (0)";
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAdd.BackColor = Color.White;
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatAppearance.BorderColor = Color.FromArgb(190, 225, 245);
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Bahnschrift", 9.75F);
            btnAdd.ForeColor = Color.Black;
            btnAdd.Location = new Point(89, 539);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(110, 35);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Actualizar";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnClear.BackColor = Color.White;
            btnClear.Cursor = Cursors.Hand;
            btnClear.FlatAppearance.BorderColor = Color.FromArgb(190, 225, 245);
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Bahnschrift", 9.75F);
            btnClear.ForeColor = Color.Black;
            btnClear.Location = new Point(205, 539);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(110, 35);
            btnClear.TabIndex = 5;
            btnClear.Text = "Limpiar";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnImport
            // 
            btnImport.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnImport.BackColor = Color.White;
            btnImport.Cursor = Cursors.Hand;
            btnImport.FlatAppearance.BorderColor = Color.FromArgb(190, 225, 245);
            btnImport.FlatStyle = FlatStyle.Flat;
            btnImport.Font = new Font("Bahnschrift", 9.75F);
            btnImport.ForeColor = Color.Black;
            btnImport.Location = new Point(321, 539);
            btnImport.Name = "btnImport";
            btnImport.Size = new Size(110, 35);
            btnImport.TabIndex = 6;
            btnImport.Text = "Importar .txt";
            btnImport.UseVisualStyleBackColor = false;
            btnImport.Click += btnImport_Click;
            // 
            // openFileDialogDevices
            // 
            openFileDialogDevices.FileName = "openFileDialog1";
            openFileDialogDevices.Filter = "Archivos de texto (*.txt)|*.txt";
            openFileDialogDevices.Title = "Seleccionar lista de equipos";
            // 
            // pnlDevices
            // 
            pnlDevices.BackColor = Color.White;
            pnlDevices.Controls.Add(txtDevices);
            pnlDevices.Location = new Point(12, 123);
            pnlDevices.Name = "pnlDevices";
            pnlDevices.Size = new Size(510, 410);
            pnlDevices.TabIndex = 8;
            // 
            // txtDevices
            // 
            txtDevices.AcceptsReturn = true;
            txtDevices.BorderStyle = BorderStyle.None;
            txtDevices.Dock = DockStyle.Fill;
            txtDevices.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDevices.Location = new Point(0, 0);
            txtDevices.Multiline = true;
            txtDevices.Name = "txtDevices";
            txtDevices.ScrollBars = ScrollBars.Vertical;
            txtDevices.Size = new Size(510, 410);
            txtDevices.TabIndex = 4;
            txtDevices.WordWrap = false;
            txtDevices.TextChanged += txtDevice_TextChanged;
            // 
            // ManageDevicesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 43, 70);
            ClientSize = new Size(534, 611);
            Controls.Add(pnlDevices);
            Controls.Add(btnImport);
            Controls.Add(btnClear);
            Controls.Add(btnAdd);
            Controls.Add(lblDevices);
            Controls.Add(lblInstructions);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new Size(550, 400);
            Name = "ManageDevicesForm";
            StartPosition = FormStartPosition.CenterParent;
            pnlDevices.ResumeLayout(false);
            pnlDevices.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblInstructions;
        private Label lblDevices;
        private Button btnAdd;
        private Button btnClear;
        private Button btnImport;
        private OpenFileDialog openFileDialogDevices;
        private Panel pnlDevices;
        private TextBox txtDevices;
    }
}