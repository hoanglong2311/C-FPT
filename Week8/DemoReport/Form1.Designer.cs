namespace DemoReport
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dsStudent = new DemoReport.dsStudent();
            this.dsStudentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sTUDENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sTUDENTTableAdapter = new DemoReport.dsStudentTableAdapters.STUDENTTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dsStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsStudentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENTBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.sTUDENTBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DemoReport.rStudent.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // dsStudent
            // 
            this.dsStudent.DataSetName = "dsStudent";
            this.dsStudent.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsStudentBindingSource
            // 
            this.dsStudentBindingSource.DataSource = this.dsStudent;
            this.dsStudentBindingSource.Position = 0;
            // 
            // sTUDENTBindingSource
            // 
            this.sTUDENTBindingSource.DataMember = "STUDENT";
            this.sTUDENTBindingSource.DataSource = this.dsStudentBindingSource;
            // 
            // sTUDENTTableAdapter
            // 
            this.sTUDENTTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsStudentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENTBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource dsStudentBindingSource;
        private dsStudent dsStudent;
        private System.Windows.Forms.BindingSource sTUDENTBindingSource;
        private dsStudentTableAdapters.STUDENTTableAdapter sTUDENTTableAdapter;
    }
}

