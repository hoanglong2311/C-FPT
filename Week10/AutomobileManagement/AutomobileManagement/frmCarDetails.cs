using System;
using System.Windows.Forms;
using AutoMobileLibrary.BussinessObject;
using AutoMobileLibrary.Repository;

namespace AutomobileManagement;

public partial class frmCarDetails : Form
{
    public frmCarDetails()
    {
        InitializeComponent();
    }
    public ICarRepository CarRepository { get; set; }
    public bool InsertOrUpdate { get; set; } // true for update and false for insert
    public Car CarInfo { get; set; }
    //---------------------------------------------------------------------------------------------

    private void frmCarDetails_Load(object sender, EventArgs e)
    {
        cboManufacturer.SelectedIndex = 0;
        txtCarID.Enabled = !InsertOrUpdate;
        if (InsertOrUpdate == true) //update mode
        {
            // txtCarID.Text = CarInfo.CarId.ToString();
            txtCarName.Text = CarInfo.CarName;
            txtPrice.Text = CarInfo.Price.ToString();
            txtReleaseYear.Text = CarInfo.ReleaseYear.ToString();
            cboManufacturer.Text = CarInfo.Manufacturer.Trim();
        }
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        try
        {
            var car = new Car
            {
                CarName = txtCarName.Text,
                Manufacturer = cboManufacturer.Text,
                Price = decimal.Parse(txtPrice.Text),
                ReleaseYear = Int32.Parse(txtReleaseYear.Text)
            };
            if (InsertOrUpdate == false) //Insert mode
            {
                CarRepository.InsertCar(car);
            }
            else
            {
                CarRepository.UpdateCar(car);
            }
        }
        catch (Exception exception)
        {
            MessageBox.Show(exception.Message, InsertOrUpdate==false? "Add new car" : "Update car", MessageBoxButtons.OK, MessageBoxIcon.Error);
            throw;
        }
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
        this.Close();
    }
}