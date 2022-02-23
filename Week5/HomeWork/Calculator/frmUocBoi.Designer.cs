namespace Calculator
{
    partial class frmUocBoi
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumberA = new System.Windows.Forms.TextBox();
            this.txtNumberB = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdBscnn = new System.Windows.Forms.RadioButton();
            this.rdUscln = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "B";
            // 
            // txtNumberA
            // 
            this.txtNumberA.Location = new System.Drawing.Point(105, 87);
            this.txtNumberA.Name = "txtNumberA";
            this.txtNumberA.Size = new System.Drawing.Size(247, 27);
            this.txtNumberA.TabIndex = 2;
            // 
            // txtNumberB
            // 
            this.txtNumberB.Location = new System.Drawing.Point(105, 158);
            this.txtNumberB.Name = "txtNumberB";
            this.txtNumberB.Size = new System.Drawing.Size(247, 27);
            this.txtNumberB.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdBscnn);
            this.groupBox1.Controls.Add(this.rdUscln);
            this.groupBox1.Location = new System.Drawing.Point(448, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(286, 125);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn Tìm";
            // 
            // rdBscnn
            // 
            this.rdBscnn.AutoSize = true;
            this.rdBscnn.Location = new System.Drawing.Point(19, 78);
            this.rdBscnn.Name = "rdBscnn";
            this.rdBscnn.Size = new System.Drawing.Size(78, 24);
            this.rdBscnn.TabIndex = 1;
            this.rdBscnn.TabStop = true;
            this.rdBscnn.Text = "BSCNN";
            this.rdBscnn.UseVisualStyleBackColor = true;
            // 
            // rdUscln
            // 
            this.rdUscln.AutoSize = true;
            this.rdUscln.Location = new System.Drawing.Point(19, 30);
            this.rdUscln.Name = "rdUscln";
            this.rdUscln.Size = new System.Drawing.Size(75, 24);
            this.rdUscln.TabIndex = 0;
            this.rdUscln.TabStop = true;
            this.rdUscln.Text = "USCLN";
            this.rdUscln.UseVisualStyleBackColor = true;
            this.rdUscln.CheckedChanged += new System.EventHandler(this.rdUscln_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.txtKetQua);
            this.groupBox2.Location = new System.Drawing.Point(12, 270);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(768, 154);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kết quả";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(506, 106);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 29);
            this.button3.TabIndex = 3;
            this.button3.Text = "Thoát";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(316, 106);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 2;
            this.button2.Text = "Bỏ Qua";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(126, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "Tìm";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtKetQua
            // 
            this.txtKetQua.Location = new System.Drawing.Point(39, 46);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Size = new System.Drawing.Size(492, 27);
            this.txtKetQua.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(312, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 31);
            this.label3.TabIndex = 4;
            this.label3.Text = "Máy tính";
            // 
            // frmUocBoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtNumberB);
            this.Controls.Add(this.txtNumberA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmUocBoi";
            this.Text = "frmUocBoi";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtNumberA;
        private TextBox txtNumberB;
        private GroupBox groupBox1;
        private RadioButton rdBscnn;
        private RadioButton rdUscln;
        private GroupBox groupBox2;
        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox txtKetQua;
        private Label label3;
    }
}