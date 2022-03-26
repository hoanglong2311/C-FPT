using System.ComponentModel;

namespace AutomobileManagement;

partial class frmCarDetails
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
        this.label2 = new System.Windows.Forms.Label();
        this.label3 = new System.Windows.Forms.Label();
        this.label4 = new System.Windows.Forms.Label();
        this.label5 = new System.Windows.Forms.Label();
        this.txtCarID = new System.Windows.Forms.TextBox();
        this.txtCarName = new System.Windows.Forms.TextBox();
        this.cboManufacturer = new System.Windows.Forms.ComboBox();
        this.txtPrice = new System.Windows.Forms.MaskedTextBox();
        this.txtReleaseYear = new System.Windows.Forms.MaskedTextBox();
        this.btnSave = new System.Windows.Forms.Button();
        this.btnCancel = new System.Windows.Forms.Button();
        this.SuspendLayout();
        // 
        // label1
        // 
        this.label1.Location = new System.Drawing.Point(11, 43);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(103, 29);
        this.label1.TabIndex = 0;
        this.label1.Text = "Car ID";
        // 
        // label2
        // 
        this.label2.Location = new System.Drawing.Point(11, 103);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(87, 30);
        this.label2.TabIndex = 1;
        this.label2.Text = "Car Name";
        // 
        // label3
        // 
        this.label3.AutoSize = true;
        this.label3.Location = new System.Drawing.Point(11, 172);
        this.label3.Name = "label3";
        this.label3.Size = new System.Drawing.Size(92, 17);
        this.label3.TabIndex = 2;
        this.label3.Text = "Manufacturer";
        // 
        // label4
        // 
        this.label4.Location = new System.Drawing.Point(11, 251);
        this.label4.Name = "label4";
        this.label4.Size = new System.Drawing.Size(71, 32);
        this.label4.TabIndex = 3;
        this.label4.Text = "Price";
        // 
        // label5
        // 
        this.label5.AutoSize = true;
        this.label5.Location = new System.Drawing.Point(11, 326);
        this.label5.Name = "label5";
        this.label5.Size = new System.Drawing.Size(102, 17);
        this.label5.TabIndex = 4;
        this.label5.Text = "Released Year";
        // 
        // txtCarID
        // 
        this.txtCarID.Location = new System.Drawing.Point(123, 40);
        this.txtCarID.Name = "txtCarID";
        this.txtCarID.Size = new System.Drawing.Size(238, 22);
        this.txtCarID.TabIndex = 5;
        // 
        // txtCarName
        // 
        this.txtCarName.Location = new System.Drawing.Point(125, 96);
        this.txtCarName.Name = "txtCarName";
        this.txtCarName.Size = new System.Drawing.Size(236, 22);
        this.txtCarName.TabIndex = 6;
        // 
        // cboManufacturer
        // 
        this.cboManufacturer.FormattingEnabled = true;
        this.cboManufacturer.Items.AddRange(new object[] {"Audi", "BMW", "Ford", "Honda", "Hyundai", "Kia", "Suzuki", "Toyota"});
        this.cboManufacturer.Location = new System.Drawing.Point(128, 166);
        this.cboManufacturer.Name = "cboManufacturer";
        this.cboManufacturer.Size = new System.Drawing.Size(233, 24);
        this.cboManufacturer.TabIndex = 9;
        // 
        // txtPrice
        // 
        this.txtPrice.Location = new System.Drawing.Point(128, 248);
        this.txtPrice.Mask = "0000000000";
        this.txtPrice.Name = "txtPrice";
        this.txtPrice.Size = new System.Drawing.Size(233, 22);
        this.txtPrice.TabIndex = 10;
        this.txtPrice.Text = "0";
        // 
        // txtReleaseYear
        // 
        this.txtReleaseYear.Location = new System.Drawing.Point(128, 323);
        this.txtReleaseYear.Mask = "0000";
        this.txtReleaseYear.Name = "txtReleaseYear";
        this.txtReleaseYear.Size = new System.Drawing.Size(233, 22);
        this.txtReleaseYear.TabIndex = 11;
        this.txtReleaseYear.Text = "0";
        // 
        // btnSave
        // 
        this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
        this.btnSave.Location = new System.Drawing.Point(123, 409);
        this.btnSave.Name = "btnSave";
        this.btnSave.Size = new System.Drawing.Size(75, 23);
        this.btnSave.TabIndex = 12;
        this.btnSave.Text = "Save";
        this.btnSave.UseVisualStyleBackColor = true;
        this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
        // 
        // btnCancel
        // 
        this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        this.btnCancel.Location = new System.Drawing.Point(286, 409);
        this.btnCancel.Name = "btnCancel";
        this.btnCancel.Size = new System.Drawing.Size(75, 23);
        this.btnCancel.TabIndex = 13;
        this.btnCancel.Text = "Cancel";
        this.btnCancel.UseVisualStyleBackColor = true;
        this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
        // 
        // frmCarDetails
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(455, 483);
        this.Controls.Add(this.btnCancel);
        this.Controls.Add(this.btnSave);
        this.Controls.Add(this.txtReleaseYear);
        this.Controls.Add(this.txtPrice);
        this.Controls.Add(this.cboManufacturer);
        this.Controls.Add(this.txtCarName);
        this.Controls.Add(this.txtCarID);
        this.Controls.Add(this.label5);
        this.Controls.Add(this.label4);
        this.Controls.Add(this.label3);
        this.Controls.Add(this.label2);
        this.Controls.Add(this.label1);
        this.Name = "frmCarDetails";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "frmCarDetails";
        this.Load += new System.EventHandler(this.frmCarDetails_Load);
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    private System.Windows.Forms.Button btnSave;
    private System.Windows.Forms.Button btnCancel;

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox txtCarID;
    private System.Windows.Forms.TextBox txtCarName;
    private System.Windows.Forms.ComboBox cboManufacturer;
    private System.Windows.Forms.MaskedTextBox txtPrice;
    private System.Windows.Forms.MaskedTextBox txtReleaseYear;

    #endregion
}