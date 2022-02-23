namespace Calculator
{
    partial class frmMenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnCongTruNhanChia = new System.Windows.Forms.Button();
            this.btnUocBoi = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.frmSecurity = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(290, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "HOME WORK";
            // 
            // btnCongTruNhanChia
            // 
            this.btnCongTruNhanChia.AutoSize = true;
            this.btnCongTruNhanChia.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnCongTruNhanChia.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCongTruNhanChia.Location = new System.Drawing.Point(24, 199);
            this.btnCongTruNhanChia.Name = "btnCongTruNhanChia";
            this.btnCongTruNhanChia.Size = new System.Drawing.Size(203, 38);
            this.btnCongTruNhanChia.TabIndex = 1;
            this.btnCongTruNhanChia.Text = "Cộng trừ nhân chia";
            this.btnCongTruNhanChia.UseVisualStyleBackColor = false;
            this.btnCongTruNhanChia.Click += new System.EventHandler(this.btnCongTruNhanChia_Click);
            // 
            // btnUocBoi
            // 
            this.btnUocBoi.AutoSize = true;
            this.btnUocBoi.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnUocBoi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUocBoi.Location = new System.Drawing.Point(252, 199);
            this.btnUocBoi.Name = "btnUocBoi";
            this.btnUocBoi.Size = new System.Drawing.Size(231, 38);
            this.btnUocBoi.TabIndex = 2;
            this.btnUocBoi.Text = "Ước chung, Bội chung";
            this.btnUocBoi.UseVisualStyleBackColor = false;
            this.btnUocBoi.Click += new System.EventHandler(this.btnUocBoi_Click);
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = true;
            this.btnExit.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnExit.Location = new System.Drawing.Point(685, 199);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(94, 38);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmSecurity
            // 
            this.frmSecurity.AutoSize = true;
            this.frmSecurity.BackColor = System.Drawing.Color.DarkSalmon;
            this.frmSecurity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.frmSecurity.Location = new System.Drawing.Point(508, 199);
            this.frmSecurity.Name = "frmSecurity";
            this.frmSecurity.Size = new System.Drawing.Size(152, 38);
            this.frmSecurity.TabIndex = 4;
            this.frmSecurity.Text = "Security Code";
            this.frmSecurity.UseVisualStyleBackColor = false;
            this.frmSecurity.Click += new System.EventHandler(this.frmSecurity_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.frmSecurity);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnUocBoi);
            this.Controls.Add(this.btnCongTruNhanChia);
            this.Controls.Add(this.label1);
            this.Name = "frmMenu";
            this.Text = "frmMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button btnCongTruNhanChia;
        private Button btnUocBoi;
        private Button btnExit;
        private Button frmSecurity;
    }
}