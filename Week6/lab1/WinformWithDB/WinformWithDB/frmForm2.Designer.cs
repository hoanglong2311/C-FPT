namespace WinformWithDB
{
    partial class frmForm2
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
            this.btnViewInDetail = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtClassIDDB = new System.Windows.Forms.TextBox();
            this.txtClassName = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.btnViewListSutdents = new System.Windows.Forms.Button();
            this.cbxClassID = new System.Windows.Forms.ComboBox();
            this.lvStudents = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // btnViewInDetail
            // 
            this.btnViewInDetail.Location = new System.Drawing.Point(30, 106);
            this.btnViewInDetail.Name = "btnViewInDetail";
            this.btnViewInDetail.Size = new System.Drawing.Size(297, 55);
            this.btnViewInDetail.TabIndex = 0;
            this.btnViewInDetail.Text = "View in detail";
            this.btnViewInDetail.UseVisualStyleBackColor = true;
            this.btnViewInDetail.Click += new System.EventHandler(this.btnViewInDetail_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Class ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Class ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Class Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 328);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Year";
            // 
            // txtClassIDDB
            // 
            this.txtClassIDDB.Location = new System.Drawing.Point(125, 204);
            this.txtClassIDDB.Name = "txtClassIDDB";
            this.txtClassIDDB.Size = new System.Drawing.Size(223, 22);
            this.txtClassIDDB.TabIndex = 6;
            // 
            // txtClassName
            // 
            this.txtClassName.Location = new System.Drawing.Point(125, 268);
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.Size = new System.Drawing.Size(223, 22);
            this.txtClassName.TabIndex = 7;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(125, 325);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(223, 22);
            this.txtYear.TabIndex = 8;
            // 
            // btnViewListSutdents
            // 
            this.btnViewListSutdents.Location = new System.Drawing.Point(419, 106);
            this.btnViewListSutdents.Name = "btnViewListSutdents";
            this.btnViewListSutdents.Size = new System.Drawing.Size(348, 55);
            this.btnViewListSutdents.TabIndex = 9;
            this.btnViewListSutdents.Text = "View list of Students";
            this.btnViewListSutdents.UseVisualStyleBackColor = true;
            this.btnViewListSutdents.Click += new System.EventHandler(this.btnViewListSutdents_Click);
            // 
            // cbxClassID
            // 
            this.cbxClassID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxClassID.FormattingEnabled = true;
            this.cbxClassID.Location = new System.Drawing.Point(125, 43);
            this.cbxClassID.Name = "cbxClassID";
            this.cbxClassID.Size = new System.Drawing.Size(218, 24);
            this.cbxClassID.TabIndex = 11;
            this.cbxClassID.SelectedIndexChanged += new System.EventHandler(this.cbxClassID_SelectedIndexChanged);
            // 
            // lvStudents
            // 
            this.lvStudents.HideSelection = false;
            this.lvStudents.Location = new System.Drawing.Point(418, 182);
            this.lvStudents.Name = "lvStudents";
            this.lvStudents.Size = new System.Drawing.Size(481, 307);
            this.lvStudents.TabIndex = 12;
            this.lvStudents.UseCompatibleStateImageBehavior = false;
            // 
            // frmForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 510);
            this.Controls.Add(this.lvStudents);
            this.Controls.Add(this.cbxClassID);
            this.Controls.Add(this.btnViewListSutdents);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtClassName);
            this.Controls.Add(this.txtClassIDDB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnViewInDetail);
            this.Name = "frmForm2";
            this.Text = "frmForm2";
            this.Load += new System.EventHandler(this.frmForm2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnViewInDetail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtClassIDDB;
        private System.Windows.Forms.TextBox txtClassName;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Button btnViewListSutdents;
        private System.Windows.Forms.ComboBox cbxClassID;
        private System.Windows.Forms.ListView lvStudents;
    }
}