using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutomobileLibrary.Repository;
using AutomobileLibrary.BusinessObject;

namespace AutomobileWinApp
{
    public partial class frmCarDetails : Form
    {
        public frmCarDetails()
        {
            InitializeComponent();
        }

        public ICarRepository CarRepository { get; set; }
        public bool InsertOrUpdate {  get; set; } //fasle:insert , true: update
        public Car  CarInfo { get; set; }
 
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var car = new Car
                {
                    CarID = int.Parse(txtID.Text),
                    CarName = txtName.Text,
                    Manufacturer = cbManufacturer.Text,
                    Price = decimal.Parse(txtPrice.Text),
                    ReleaseYear = int.Parse(txtYear.Text)

                };
                if(InsertOrUpdate == false)
                {
                    CarRepository.InsertCar(car);
                }
                else
                {
                    CarRepository.UpdateCar(car);
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message, InsertOrUpdate == false ? "Add new car" : "Update car");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmCarDetails_Load(object sender, EventArgs e)
        {
            cbManufacturer.SelectedIndex = 0;
            txtID.Enabled = !InsertOrUpdate;
            if(InsertOrUpdate == true ) //Update
            {
                //Show info
                txtID.Text = CarInfo.CarID.ToString();
                txtName.Text = CarInfo.CarName.ToString();
                txtPrice.Text = CarInfo.Price.ToString();
                txtYear.Text = CarInfo.ReleaseYear.ToString();
                cbManufacturer.Text = CarInfo.Manufacturer.Trim();
            }
        }
    }
}
