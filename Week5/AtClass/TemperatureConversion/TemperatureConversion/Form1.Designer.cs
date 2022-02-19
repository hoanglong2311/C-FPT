namespace TemperatureConversion
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
            this.label1 = new System.Windows.Forms.Label();
            this.Celcius = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFerhenheight = new System.Windows.Forms.TextBox();
            this.txtCelsius = new System.Windows.Forms.TextBox();
            this.txtKelvin = new System.Windows.Forms.TextBox();
            this.btnFerhenheight = new System.Windows.Forms.Button();
            this.btnCelcius = new System.Windows.Forms.Button();
            this.btnKelvin = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(16, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ferhenheight";
            // 
            // Celcius
            // 
            this.Celcius.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.Celcius.ForeColor = System.Drawing.Color.DarkOrange;
            this.Celcius.Location = new System.Drawing.Point(14, 147);
            this.Celcius.Name = "Celcius";
            this.Celcius.Size = new System.Drawing.Size(132, 44);
            this.Celcius.TabIndex = 1;
            this.Celcius.Text = "Celcius";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label3.ForeColor = System.Drawing.Color.DarkOrange;
            this.label3.Location = new System.Drawing.Point(12, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 41);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kelvin";
            // 
            // txtFerhenheight
            // 
            this.txtFerhenheight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtFerhenheight.Location = new System.Drawing.Point(165, 87);
            this.txtFerhenheight.Name = "txtFerhenheight";
            this.txtFerhenheight.Size = new System.Drawing.Size(202, 34);
            this.txtFerhenheight.TabIndex = 3;
            this.txtFerhenheight.TextChanged += new System.EventHandler(this.txtFerhenheight_TextChanged);
            // 
            // txtCelsius
            // 
            this.txtCelsius.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtCelsius.Location = new System.Drawing.Point(165, 148);
            this.txtCelsius.Name = "txtCelsius";
            this.txtCelsius.Size = new System.Drawing.Size(201, 34);
            this.txtCelsius.TabIndex = 4;
            // 
            // txtKelvin
            // 
            this.txtKelvin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtKelvin.Location = new System.Drawing.Point(163, 209);
            this.txtKelvin.Name = "txtKelvin";
            this.txtKelvin.Size = new System.Drawing.Size(202, 34);
            this.txtKelvin.TabIndex = 5;
            // 
            // btnFerhenheight
            // 
            this.btnFerhenheight.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnFerhenheight.Location = new System.Drawing.Point(486, 87);
            this.btnFerhenheight.Name = "btnFerhenheight";
            this.btnFerhenheight.Size = new System.Drawing.Size(115, 34);
            this.btnFerhenheight.TabIndex = 6;
            this.btnFerhenheight.Text = "Convert";
            this.btnFerhenheight.UseVisualStyleBackColor = true;
            this.btnFerhenheight.Click += new System.EventHandler(this.btnFerhenheight_Click);
            // 
            // btnCelcius
            // 
            this.btnCelcius.Location = new System.Drawing.Point(486, 147);
            this.btnCelcius.Name = "btnCelcius";
            this.btnCelcius.Size = new System.Drawing.Size(114, 35);
            this.btnCelcius.TabIndex = 7;
            this.btnCelcius.Text = "Convert";
            this.btnCelcius.UseVisualStyleBackColor = true;
            this.btnCelcius.Click += new System.EventHandler(this.btnCelcius_Click);
            // 
            // btnKelvin
            // 
            this.btnKelvin.Location = new System.Drawing.Point(486, 206);
            this.btnKelvin.Name = "btnKelvin";
            this.btnKelvin.Size = new System.Drawing.Size(114, 37);
            this.btnKelvin.TabIndex = 8;
            this.btnKelvin.Text = "Convert";
            this.btnKelvin.UseVisualStyleBackColor = true;
            this.btnKelvin.Click += new System.EventHandler(this.btnKelvin_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(649, 377);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(104, 43);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnKelvin);
            this.Controls.Add(this.btnCelcius);
            this.Controls.Add(this.btnFerhenheight);
            this.Controls.Add(this.txtKelvin);
            this.Controls.Add(this.txtCelsius);
            this.Controls.Add(this.txtFerhenheight);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Celcius);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btnReset;

        private System.Windows.Forms.Button btnFerhenheight;
        private System.Windows.Forms.Button btnCelcius;
        private System.Windows.Forms.Button btnKelvin;

        private System.Windows.Forms.TextBox txtFerhenheight;
        private System.Windows.Forms.TextBox txtCelsius;
        private System.Windows.Forms.TextBox txtKelvin;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Celcius;
        private System.Windows.Forms.Label label3;

        #endregion
    }
}