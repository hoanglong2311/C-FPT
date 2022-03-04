namespace WinformWithDB
{
    partial class frmCRUD
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
            this.lsvStudents = new System.Windows.Forms.ListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtClassID = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lsvStudents
            // 
            this.lsvStudents.HideSelection = false;
            this.lsvStudents.Location = new System.Drawing.Point(22, 42);
            this.lsvStudents.Name = "lsvStudents";
            this.lsvStudents.Size = new System.Drawing.Size(406, 368);
            this.lsvStudents.TabIndex = 0;
            this.lsvStudents.UseCompatibleStateImageBehavior = false;
            this.lsvStudents.SelectedIndexChanged += new System.EventHandler(this.lsvStudents_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtClassID);
            this.groupBox1.Controls.Add(this.txtFullName);
            this.groupBox1.Controls.Add(this.txtStudentID);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(454, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(324, 193);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Information";
            // 
            // txtClassID
            // 
            this.txtClassID.Location = new System.Drawing.Point(107, 133);
            this.txtClassID.Name = "txtClassID";
            this.txtClassID.Size = new System.Drawing.Size(176, 22);
            this.txtClassID.TabIndex = 5;
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(107, 93);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(176, 22);
            this.txtFullName.TabIndex = 4;
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(107, 53);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(176, 22);
            this.txtStudentID.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Class ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Full name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student ID";
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(470, 326);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 6;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(586, 326);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(702, 326);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lsvStudents);
            this.Name = "frmCRUD";
            this.Text = "frmCRUD";
            this.Load += new System.EventHandler(this.frmCRUD_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lsvStudents;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtClassID;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
    }
}