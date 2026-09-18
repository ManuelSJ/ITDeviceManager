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
            txtDevices = new TextBox();
            btnAdd = new Button();
            btnClear = new Button();
            btnImport = new Button();
            btnContinue = new Button();
            openFileDialogDevices = new OpenFileDialog();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
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
            lblInstructions.Location = new Point(16, 92);
            lblInstructions.Name = "lblInstructions";
            lblInstructions.Size = new Size(353, 17);
            lblInstructions.TabIndex = 1;
            lblInstructions.Text = "Ingresa el nombre del equipo o dirección IP, uno por línea.";
            // 
            // lblDevices
            // 
            lblDevices.AutoSize = true;
            lblDevices.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDevices.Location = new Point(16, 123);
            lblDevices.Name = "lblDevices";
            lblDevices.Size = new Size(78, 17);
            lblDevices.TabIndex = 2;
            lblDevices.Text = "Equipos (0)";
            // 
            // txtDevices
            // 
            txtDevices.AcceptsReturn = true;
            txtDevices.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtDevices.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDevices.Location = new Point(16, 143);
            txtDevices.Multiline = true;
            txtDevices.Name = "txtDevices";
            txtDevices.ScrollBars = ScrollBars.Vertical;
            txtDevices.Size = new Size(506, 380);
            txtDevices.TabIndex = 3;
            txtDevices.WordWrap = false;
            txtDevices.TextChanged += txtDevice_TextChanged;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAdd.Enabled = false;
            btnAdd.Location = new Point(15, 538);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(110, 35);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Agregar";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnClear.Enabled = false;
            btnClear.Location = new Point(131, 538);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(110, 35);
            btnClear.TabIndex = 5;
            btnClear.Text = "Limpiar";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnImport
            // 
            btnImport.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnImport.Enabled = false;
            btnImport.Location = new Point(247, 538);
            btnImport.Name = "btnImport";
            btnImport.Size = new Size(110, 35);
            btnImport.TabIndex = 6;
            btnImport.Text = "Importar .txt";
            btnImport.UseVisualStyleBackColor = true;
            btnImport.Click += btnImport_Click;
            // 
            // btnContinue
            // 
            btnContinue.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnContinue.Enabled = false;
            btnContinue.Location = new Point(363, 538);
            btnContinue.Name = "btnContinue";
            btnContinue.Size = new Size(110, 35);
            btnContinue.TabIndex = 7;
            btnContinue.Text = "Continuar";
            btnContinue.UseVisualStyleBackColor = true;
            btnContinue.Click += btnContinue_Click;
            // 
            // openFileDialogDevices
            // 
            openFileDialogDevices.FileName = "openFileDialog1";
            openFileDialogDevices.Filter = "Archivos de texto (*.txt)|*.txt";
            openFileDialogDevices.Title = "Seleccionar lista de equipos";
            // 
            // ManageDevicesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(534, 611);
            Controls.Add(btnContinue);
            Controls.Add(btnImport);
            Controls.Add(btnClear);
            Controls.Add(btnAdd);
            Controls.Add(txtDevices);
            Controls.Add(lblDevices);
            Controls.Add(lblInstructions);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new Size(550, 400);
            Name = "ManageDevicesForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Administracion de equipos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblInstructions;
        private Label lblDevices;
        private TextBox txtDevices;
        private Button btnAdd;
        private Button btnClear;
        private Button btnImport;
        private Button btnContinue;
        private OpenFileDialog openFileDialogDevices;
    }
}