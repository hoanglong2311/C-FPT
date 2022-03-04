namespace WinformWithDB
{
    partial class Form1
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
            this.dgvClass = new System.Windows.Forms.DataGridView();
            this.lbClass = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize) (this.dgvClass)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClass
            // 
            this.dgvClass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClass.Location = new System.Drawing.Point(19, 59);
            this.dgvClass.Name = "dgvClass";
            this.dgvClass.RowTemplate.Height = 24;
            this.dgvClass.Size = new System.Drawing.Size(449, 359);
            this.dgvClass.TabIndex = 0;
            // 
            // lbClass
            // 
            this.lbClass.Location = new System.Drawing.Point(39, 20);
            this.lbClass.Name = "lbClass";
            this.lbClass.Size = new System.Drawing.Size(97, 25);
            this.lbClass.TabIndex = 1;
            this.lbClass.Text = "Class";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(572, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 48);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbClass);
            this.Controls.Add(this.dgvClass);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize) (this.dgvClass)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.Label lbClass;

        private System.Windows.Forms.DataGridView dgvClass;

        #endregion
    }
}