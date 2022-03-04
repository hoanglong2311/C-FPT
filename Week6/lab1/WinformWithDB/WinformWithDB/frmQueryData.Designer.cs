using System.ComponentModel;

namespace WinformWithDB
{
    partial class frmQueryData
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
            this.txtClassID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumberOfStudents = new System.Windows.Forms.TextBox();
            this.btnCalNumStudent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.Location = new System.Drawing.Point(28, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter ClassID";
            // 
            // txtClassID
            // 
            this.txtClassID.Location = new System.Drawing.Point(289, 64);
            this.txtClassID.Name = "txtClassID";
            this.txtClassID.Size = new System.Drawing.Size(284, 22);
            this.txtClassID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label2.Location = new System.Drawing.Point(28, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Number of Students";
            // 
            // txtNumberOfStudents
            // 
            this.txtNumberOfStudents.Location = new System.Drawing.Point(289, 131);
            this.txtNumberOfStudents.Name = "txtNumberOfStudents";
            this.txtNumberOfStudents.ReadOnly = true;
            this.txtNumberOfStudents.Size = new System.Drawing.Size(283, 22);
            this.txtNumberOfStudents.TabIndex = 3;
            // 
            // btnCalNumStudent
            // 
            this.btnCalNumStudent.AutoSize = true;
            this.btnCalNumStudent.Location = new System.Drawing.Point(289, 206);
            this.btnCalNumStudent.Name = "btnCalNumStudent";
            this.btnCalNumStudent.Size = new System.Drawing.Size(195, 27);
            this.btnCalNumStudent.TabIndex = 4;
            this.btnCalNumStudent.Text = "Calculate number of student";
            this.btnCalNumStudent.UseVisualStyleBackColor = true;
            this.btnCalNumStudent.Click += new System.EventHandler(this.btnCalNumStudent_Click);
            // 
            // frmQueryData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalNumStudent);
            this.Controls.Add(this.txtNumberOfStudents);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtClassID);
            this.Controls.Add(this.label1);
            this.Name = "frmQueryData";
            this.Text = "frmQueryData";
            this.Load += new System.EventHandler(this.frmQueryData_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtNumberOfStudents;
        private System.Windows.Forms.Button btnCalNumStudent;

        private System.Windows.Forms.TextBox txtClassID;
        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label label1;

        #endregion
    }
}