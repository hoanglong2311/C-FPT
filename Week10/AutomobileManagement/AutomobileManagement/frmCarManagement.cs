using System;
using System.Linq;
using System.Windows.Forms;
using AutoMobileLibrary.BussinessObject;
using AutoMobileLibrary.Repository;

namespace AutomobileManagement;

public partial class frmCarManagement : Form
{
    private ICarRepository CarRepository = new CarRepository();
    private BindingSource source;
    
    public frmCarManagement()
    {
        InitializeComponent();
    }

    private void frmCarManagement_Load(object sender, System.EventArgs e)
    {
        btnDelete.Enabled = false;
        dgvCarList.CellDoubleClick += dgvCarList_CellDoubleClick;
    }

    private void dgvCarList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        frmCarDetails frmCarDetails = new frmCarDetails
        {
            Text = "Update car",
            InsertOrUpdate = true,
            CarInfo = GetCarObject(),
            CarRepository = CarRepository
        };
        if (frmCarDetails.ShowDialog() == DialogResult.OK)
        {
            LoadCarList();
            //set focus car update
            source.Position = source.Count - 1;
        }
    }

    private void ClearText()
    {
        txtCarID.Text = String.Empty;
        txtCarName.Text = String.Empty;
        txtPrice.Text = String.Empty;
        txtManufacturer.Text = String.Empty;
        txtReleaseYear.Text = String.Empty;
    }
    private void LoadCarList()
    {
        var cars = CarRepository.GetCars();
        try
        {
            source = new BindingSource();
            source.DataSource = cars;
            
            txtCarID.DataBindings.Clear();
            txtCarName.DataBindings.Clear();
            txtPrice.DataBindings.Clear();
            txtManufacturer.DataBindings.Clear();
            txtReleaseYear.DataBindings.Clear();
            
            txtCarID.DataBindings.Add("Text", source, "CarID");
            txtCarName.DataBindings.Add("Text", source, "CarName");
            txtPrice.DataBindings.Add("Text", source, "Price");
            txtManufacturer.DataBindings.Add("Text", source, "Manufacturer");
            txtReleaseYear.DataBindings.Add("Text", source, "ReleaseYear");

            dgvCarList.DataSource = null;
            dgvCarList.DataSource = source;
            if (cars.Count() == 0)
            {
                ClearText();
                btnDelete.Enabled = false;
            }
            else
            {
                btnDelete.Enabled = true;
            }
            
        }
        catch (Exception e)
        {
            MessageBox.Show(e.Message,"Load Car list");
            throw;
        }
    }

    private Car GetCarObject()
    {
        Car car = null;
        try
        {
            car = new Car
            {
                CarId = Int32.Parse(txtCarID.Text),
                CarName = txtCarName.Text,
                Manufacturer = txtManufacturer.Text,
                Price = Decimal.Parse(txtPrice.Text),
                ReleaseYear = int.Parse(txtReleaseYear.Text)
            };
        }
        catch (Exception e)
        {
            MessageBox.Show(e.Message,"Get car");
            throw;
        }

        return car;
    }


    private void btnClose_Click_1(object sender, EventArgs e)
    {
        Close();
    }

    private void btnLoad_Click(object sender, EventArgs e)
    {
        LoadCarList();
    }

    private void btnNew_Click(object sender, EventArgs e)
    {
        frmCarDetails frmCarDetails = new frmCarDetails
        {
            Text = "Add car",
            InsertOrUpdate = false,
            CarRepository = CarRepository
        };
        if (frmCarDetails.ShowDialog() == DialogResult.OK)
        {
            LoadCarList();
            //set focus car update
            source.Position = source.Count - 1;
        }
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
        try
        {
            var car = GetCarObject();
            CarRepository.DeleteCar(car.CarId);
            LoadCarList();
        }
        catch (Exception exception)
        {
            MessageBox.Show(exception.Message, "Delete car");
            throw;
        }
    }
}