using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRent
{
    public partial class AddCarVehicleWindow : Form
    {
        private TypeOfCar _car;
        private ManageVehicalWindow _manageVehicalWindow;
        private bool _isEdit;
        public AddCarVehicleWindow()
        {
            InitializeComponent();
        }

        public AddCarVehicleWindow(TypeOfCar car, ManageVehicalWindow manageVehicalWindow, bool isEdit)
        {
            _car = car;
            _manageVehicalWindow = manageVehicalWindow;
            _isEdit = isEdit;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            TypeOfCar typeOfCar = new TypeOfCar();
            if (!string.IsNullOrEmpty(textBoxLbModel.Text))
            {
                typeOfCar.Model = textBoxLbModel.Text.Trim();
            }
            else
            {
                MessageBox.Show("Add model");
                textBoxLbModel.Focus();
            }
            if (!string.IsNullOrEmpty(textBoxLbMark.Text))
            {
                typeOfCar.Make = textBoxLbMark.Text.Trim();
            }
            else
            {
                MessageBox.Show("Add mark");
                textBoxLbMark.Focus();
            }
            if (!string.IsNullOrEmpty(textBoxLbVin.Text))
            {
                typeOfCar.VIN = textBoxLbVin.Text.Trim();
            }
            else
            {
                MessageBox.Show("Add vin");
                textBoxLbVin.Focus();
            }
            if (!string.IsNullOrEmpty(textBoxLbYear.Text))
            {
                typeOfCar.Year = Convert.ToInt32(textBoxLbYear.Text.Trim());
            }
            else
            {
                MessageBox.Show("Add Year");
                textBoxLbYear.Focus();
            }
            if (!string.IsNullOrEmpty(textBoxLbLicenNumber.Text))
            {
                typeOfCar.LicensePlateNumber = textBoxLbLicenNumber.Text.Trim();
            }
            else
            {
                MessageBox.Show("Add Licen Number");
                textBoxLbLicenNumber.Focus();
            }
            CarRentDbContext dbContext = new CarRentDbContext();
            try
            {
                if (_isEdit)
                {
                    var carToUpdate = dbContext.TypeOfCars.Find(_car.Id);
                    carToUpdate.Make = typeOfCar.Make;
                    carToUpdate.Model = typeOfCar.Model;
                    carToUpdate.Year = typeOfCar.Year;
                    carToUpdate.LicensePlateNumber = typeOfCar.LicensePlateNumber;
                    carToUpdate.VIN = typeOfCar.VIN;
                    dbContext.SaveChanges();
                    
                    //dbContext.TypeOfCars.AddOrUpdate(typeOfCar);  // TO DO:  comment 85 - 91| uncomment 93
                    dbContext.SaveChanges();
                    MessageBox.Show("Added new type of car");
                    Close();
                }
                else
                {
                    dbContext.TypeOfCars.Add(typeOfCar);
                    dbContext.SaveChanges();
                    MessageBox.Show("Added new type of car");
                    Close();
                }
               
            }
            catch (Exception ex)
            {

                MessageBox.Show("error" + ex.Message);
            }
            
        }

        private void AddCarVehicleWindow_Load(object sender, EventArgs e)
        {
            if (_isEdit)
            {
                this.Text = "Edit Car Vehicle";
                textBoxLbModel.Text = _car.Model;
                textBoxLbMark.Text = _car.Make;
                textBoxLbVin.Text = _car.VIN;
                textBoxLbYear.Text = _car.Year.ToString();
                textBoxLbLicenNumber.Text = _car.LicensePlateNumber;
            }
            else
            {
                this.Text = "Add Car Vehicle";
            }

        }
    }
}
