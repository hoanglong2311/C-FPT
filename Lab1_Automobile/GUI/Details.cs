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
    public partial class frmCarDetails : Form
    {
        public frmCarDetails()
        {
            InitializeComponent();
        }

        private ICarRepository carRepository = new CarRepository();
        public ICarRepository CarRepository { get => carRepository; set => carRepository = value; }

        public bool InsertOrUpdate { get; set; }
        public Car CarInfo { get; set; }

        private void frmCarDetails_Load(object sender, EventArgs e)
        {
            cboManufacturer.SelectedIndex = 0;
            txtCarID.Enabled = !InsertOrUpdate;

            if (InsertOrUpdate)
            {
                txtCarID.Text = CarInfo.CarID.ToString();
                txtCarName.Text = CarInfo.CarName;
                txtPrice.Text = CarInfo.Price.ToString();
                txtReleaseYear.Text = CarInfo.Year.ToString();
                cboManufacturer.Text = CarInfo.Manufacturer.Trim();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var car = new Car(
                    int.Parse(txtCarID.Text),
                    txtCarName.Text,
                    cboManufacturer.Text,
                    decimal.Parse(txtPrice.Text),
                    int.Parse(txtReleaseYear.Text)
                    );

                if (!InsertOrUpdate)
                {
                    CarRepository.Insert(car);
                }
                else
                {
                    CarRepository.Update(car);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, !InsertOrUpdate ? "add a new car" : "update a new car");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
