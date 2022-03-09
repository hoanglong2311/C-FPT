namespace Lab3
{
    partial class frmDataBindingCRUD
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
            this.components = new System.ComponentModel.Container();
            this.cboClassID = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sTUDENT_MANAGEMENTDataSet = new Lab3.STUDENT_MANAGEMENTDataSet();
            this.cLASSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cLASSTableAdapter = new Lab3.STUDENT_MANAGEMENTDataSetTableAdapters.CLASSTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnView = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENT_MANAGEMENTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLASSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cboClassID
            // 
            this.cboClassID.DataSource = this.cLASSBindingSource;
            this.cboClassID.DisplayMember = "ClassID";
            this.cboClassID.FormattingEnabled = true;
            this.cboClassID.Location = new System.Drawing.Point(134, 35);
            this.cboClassID.Name = "cboClassID";
            this.cboClassID.Size = new System.Drawing.Size(121, 21);
            this.cboClassID.TabIndex = 0;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.cLASSBindingSource;
            this.comboBox2.DisplayMember = "ClassName";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(134, 83);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 1;
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.cLASSBindingSource;
            this.comboBox3.DisplayMember = "Year";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(134, 130);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "label3";
            // 
            // sTUDENT_MANAGEMENTDataSet
            // 
            this.sTUDENT_MANAGEMENTDataSet.DataSetName = "STUDENT_MANAGEMENTDataSet";
            this.sTUDENT_MANAGEMENTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cLASSBindingSource
            // 
            this.cLASSBindingSource.DataMember = "CLASS";
            this.cLASSBindingSource.DataSource = this.sTUDENT_MANAGEMENTDataSet;
            // 
            // cLASSTableAdapter
            // 
            this.cLASSTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 179);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(779, 256);
            this.dataGridView1.TabIndex = 6;
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(418, 69);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(99, 34);
            this.btnView.TabIndex = 7;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // frmDataBindingCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.cboClassID);
            this.Name = "frmDataBindingCRUD";
            this.Text = "frmDataBindingCRUD";
            this.Load += new System.EventHandler(this.frmDataBindingCRUD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENT_MANAGEMENTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLASSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboClassID;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private STUDENT_MANAGEMENTDataSet sTUDENT_MANAGEMENTDataSet;
        private System.Windows.Forms.BindingSource cLASSBindingSource;
        private STUDENT_MANAGEMENTDataSetTableAdapters.CLASSTableAdapter cLASSTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnView;
    }
}