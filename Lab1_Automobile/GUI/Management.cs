using Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmCarManagement : Form
    {
        ICarRepository carRepository = new CarRepository();
        BindingSource source;

        public frmCarManagement()
        {
            InitializeComponent();
        }

        private void frmCarManagement_Load(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            dgvCarList.CellDoubleClick += DvgCarList_CellDoubleClick;
        }

        private void DvgCarList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmCarDetails frmCarDetails = new frmCarDetails()
            {
                Text = "Update car",
                InsertOrUpdate = true,
                CarInfo = GetCar(),
                CarRepository = carRepository
            };

            if(frmCarDetails.ShowDialog() == DialogResult.OK)
            {
                source.Position = source.Count - 1;
            }
        }

        void Clear()
        {
            txtCarID.Text = string.Empty;
            txtCarName.Text = string.Empty;
            txtManufacture.Text = string.Empty;
            txtPrice.Text = string.Empty;
            txtReleaseYear.Text = string.Empty;
        }

        Car GetCar()
        {
            Car car = null;
            try
            {
                car = new Car(
                    int.Parse(txtCarID.Text),
                    txtCarName.Text,
                    txtManufacture.Text,
                    decimal.Parse(txtPrice.Text),
                    int.Parse(txtReleaseYear.Text)
                    );
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get Car");
            }
            return car;
        }

        void LoadCars()
        {
            var cars = carRepository.GetCars();
            try
            {
                source = new BindingSource();
                source.DataSource = cars;

                txtCarID.DataBindings.Clear();
                txtCarName.DataBindings.Clear();
                txtManufacture.DataBindings.Clear();
                txtPrice.DataBindings.Clear();
                txtReleaseYear.DataBindings.Clear();

                txtCarID.DataBindings.Add("Text", source, "CarID");
                txtCarName.DataBindings.Add("Text", source, "CarName");
                txtManufacture.DataBindings.Add("Text", source, "Manufacturer");
                txtPrice.DataBindings.Add("Text", source, "Price");
                txtReleaseYear.DataBindings.Add("Text", source, "ReleaseYear");

                dgvCarList.DataSource = null;
                dgvCarList.DataSource = source;

                if (cars.Count() == 0)
                {
                    Clear();
                    btnDelete.Enabled = false;
                }
                else
                {
                    btnDelete.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load car list");
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadCars();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmCarDetails frmCarDetails = new frmCarDetails()
            {
                Text = "Add car",
                InsertOrUpdate = false,
                CarRepository = carRepository
            };

            if (frmCarDetails.ShowDialog() == DialogResult.OK)
            {
                LoadCars();
                source.Position = source.Count - 1;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Car c = GetCar();
                carRepository.Delete(c.CarID);
                LoadCars();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete a car");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
