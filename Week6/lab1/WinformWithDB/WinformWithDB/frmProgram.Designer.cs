using System.ComponentModel;

namespace WinformWithDB
{
    partial class frmProgram
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnForm1 = new System.Windows.Forms.Button();
            this.btnForm2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.Location = new System.Drawing.Point(324, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menu";
            // 
            // btnForm1
            // 
            this.btnForm1.Location = new System.Drawing.Point(54, 157);
            this.btnForm1.Name = "btnForm1";
            this.btnForm1.Size = new System.Drawing.Size(206, 48);
            this.btnForm1.TabIndex = 1;
            this.btnForm1.Text = "Form 1";
            this.btnForm1.UseVisualStyleBackColor = true;
            this.btnForm1.Click += new System.EventHandler(this.btnForm1_Click);
            // 
            // btnForm2
            // 
            this.btnForm2.Location = new System.Drawing.Point(323, 158);
            this.btnForm2.Name = "btnForm2";
            this.btnForm2.Size = new System.Drawing.Size(208, 46);
            this.btnForm2.TabIndex = 2;
            this.btnForm2.Text = "Form 2";
            this.btnForm2.UseVisualStyleBackColor = true;
            // 
            // frmProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnForm2);
            this.Controls.Add(this.btnForm1);
            this.Controls.Add(this.label1);
            this.Name = "frmProgram";
            this.Text = "frmProgram";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnForm1;
        private System.Windows.Forms.Button btnForm2;

        private System.Windows.Forms.Label label1;

        #endregion
    }
}