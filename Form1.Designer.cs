namespace NintendoModTool
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnLoadRom;
        private System.Windows.Forms.TextBox txtRomInfo;
        private System.Windows.Forms.Button btnSaveRom;
        private System.Windows.Forms.DataGridView dgvChrData;
        private System.Windows.Forms.TextBox txtPrgOffset;
        private System.Windows.Forms.TextBox txtPrgValue;
        private System.Windows.Forms.Button btnModifyPrg;
        private System.Windows.Forms.TextBox txtChrOffset;
        private System.Windows.Forms.TextBox txtChrValue;
        private System.Windows.Forms.Button btnModifyChr;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnLoadRom = new Button();
            txtRomInfo = new TextBox();
            btnSaveRom = new Button();
            dgvChrData = new DataGridView();
            txtPrgOffset = new TextBox();
            txtPrgValue = new TextBox();
            btnModifyPrg = new Button();
            txtChrOffset = new TextBox();
            txtChrValue = new TextBox();
            btnModifyChr = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvChrData).BeginInit();
            SuspendLayout();
            // 
            // btnLoadRom
            // 
            btnLoadRom.Location = new Point(14, 14);
            btnLoadRom.Margin = new Padding(4, 3, 4, 3);
            btnLoadRom.Name = "btnLoadRom";
            btnLoadRom.Size = new Size(88, 27);
            btnLoadRom.TabIndex = 0;
            btnLoadRom.Text = "Load ROM";
            btnLoadRom.UseVisualStyleBackColor = true;
            btnLoadRom.Click += btnLoadRom_Click;
            // 
            // txtRomInfo
            // 
            txtRomInfo.Location = new Point(14, 47);
            txtRomInfo.Margin = new Padding(4, 3, 4, 3);
            txtRomInfo.Multiline = true;
            txtRomInfo.Name = "txtRomInfo";
            txtRomInfo.ReadOnly = true;
            txtRomInfo.Size = new Size(1340, 115);
            txtRomInfo.TabIndex = 1;
            // 
            // btnSaveRom
            // 
            btnSaveRom.Location = new Point(14, 170);
            btnSaveRom.Margin = new Padding(4, 3, 4, 3);
            btnSaveRom.Name = "btnSaveRom";
            btnSaveRom.Size = new Size(88, 27);
            btnSaveRom.TabIndex = 2;
            btnSaveRom.Text = "Save ROM";
            btnSaveRom.UseVisualStyleBackColor = true;
            btnSaveRom.Click += btnSaveRom_Click;
            // 
            // dgvChrData
            // 
            dgvChrData.AllowUserToAddRows = false;
            dgvChrData.AllowUserToDeleteRows = false;
            dgvChrData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChrData.Location = new Point(14, 203);
            dgvChrData.Margin = new Padding(4, 3, 4, 3);
            dgvChrData.Name = "dgvChrData";
            dgvChrData.ReadOnly = true;
            dgvChrData.Size = new Size(1340, 346);
            dgvChrData.TabIndex = 3;
            // 
            // txtPrgOffset
            // 
            txtPrgOffset.Location = new Point(14, 556);
            txtPrgOffset.Margin = new Padding(4, 3, 4, 3);
            txtPrgOffset.Name = "txtPrgOffset";
            txtPrgOffset.Size = new Size(116, 23);
            txtPrgOffset.TabIndex = 4;
            txtPrgOffset.Text = "PRG Offset";
            // 
            // txtPrgValue
            // 
            txtPrgValue.Location = new Point(138, 556);
            txtPrgValue.Margin = new Padding(4, 3, 4, 3);
            txtPrgValue.Name = "txtPrgValue";
            txtPrgValue.Size = new Size(116, 23);
            txtPrgValue.TabIndex = 5;
            txtPrgValue.Text = "PRG Value";
            // 
            // btnModifyPrg
            // 
            btnModifyPrg.Location = new Point(261, 556);
            btnModifyPrg.Margin = new Padding(4, 3, 4, 3);
            btnModifyPrg.Name = "btnModifyPrg";
            btnModifyPrg.Size = new Size(88, 27);
            btnModifyPrg.TabIndex = 6;
            btnModifyPrg.Text = "Modify PRG";
            btnModifyPrg.UseVisualStyleBackColor = true;
            btnModifyPrg.Click += btnModifyPrg_Click;
            // 
            // txtChrOffset
            // 
            txtChrOffset.Location = new Point(14, 586);
            txtChrOffset.Margin = new Padding(4, 3, 4, 3);
            txtChrOffset.Name = "txtChrOffset";
            txtChrOffset.Size = new Size(116, 23);
            txtChrOffset.TabIndex = 7;
            txtChrOffset.Text = "CHR Offset";
            // 
            // txtChrValue
            // 
            txtChrValue.Location = new Point(138, 586);
            txtChrValue.Margin = new Padding(4, 3, 4, 3);
            txtChrValue.Name = "txtChrValue";
            txtChrValue.Size = new Size(116, 23);
            txtChrValue.TabIndex = 8;
            txtChrValue.Text = "CHR Value";
            // 
            // btnModifyChr
            // 
            btnModifyChr.Location = new Point(261, 586);
            btnModifyChr.Margin = new Padding(4, 3, 4, 3);
            btnModifyChr.Name = "btnModifyChr";
            btnModifyChr.Size = new Size(88, 27);
            btnModifyChr.TabIndex = 9;
            btnModifyChr.Text = "Modify CHR";
            btnModifyChr.UseVisualStyleBackColor = true;
            btnModifyChr.Click += btnModifyChr_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1367, 624);
            Controls.Add(btnModifyChr);
            Controls.Add(txtChrValue);
            Controls.Add(txtChrOffset);
            Controls.Add(btnModifyPrg);
            Controls.Add(txtPrgValue);
            Controls.Add(txtPrgOffset);
            Controls.Add(dgvChrData);
            Controls.Add(btnSaveRom);
            Controls.Add(txtRomInfo);
            Controls.Add(btnLoadRom);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "NintendoModTool by TameoModder v1.0.0 BETA";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvChrData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
