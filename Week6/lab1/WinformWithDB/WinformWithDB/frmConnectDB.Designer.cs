using System.ComponentModel;

namespace WinformWithDB
{
    partial class frmConnectDB
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.button1 = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.lbConnectStatus = new System.Windows.Forms.Label();
            this.btnProgram = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(234, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(339, 75);
            this.button1.TabIndex = 0;
            this.button1.Text = "Connect to SQL Server Database";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(234, 128);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(341, 73);
            this.btnDisconnect.TabIndex = 1;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // lbConnectStatus
            // 
            this.lbConnectStatus.AutoSize = true;
            this.lbConnectStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConnectStatus.Location = new System.Drawing.Point(234, 366);
            this.lbConnectStatus.Name = "lbConnectStatus";
            this.lbConnectStatus.Size = new System.Drawing.Size(0, 20);
            this.lbConnectStatus.TabIndex = 2;
            // 
            // btnProgram
            // 
            this.btnProgram.Location = new System.Drawing.Point(235, 222);
            this.btnProgram.Name = "btnProgram";
            this.btnProgram.Size = new System.Drawing.Size(340, 71);
            this.btnProgram.TabIndex = 3;
            this.btnProgram.Text = "Program";
            this.btnProgram.UseVisualStyleBackColor = true;
            this.btnProgram.Click += new System.EventHandler(this.btnProgram_Click);
            // 
            // frmConnectDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnProgram);
            this.Controls.Add(this.lbConnectStatus);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.button1);
            this.Name = "frmConnectDB";
            this.Text = "frmConnectDB";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button btnProgram;

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Label lbConnectStatus;

        #endregion
    }
}