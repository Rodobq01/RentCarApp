using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRent
{
    public partial class ManageVehicalWindow : Form
    {
        private readonly CarRentDbContext _dbContext = new CarRentDbContext();
        public ManageVehicalWindow()
        {
            InitializeComponent();
        }

        private void ManageVehicalWindow_Load(object sender, EventArgs e)
        {
            LoadCars();
        }

        private void LoadCars()
        {
            var cars = _dbContext.TypeOfCars.ToList();
            dgwVehical.DataSource = cars;
            dgwVehical.Columns["Id"].Visible = false;

        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            LoadCars();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
           var carId = (int)dgwVehical.SelectedRows[0].Cells["Id"].Value;
            if (carId > 0)
            {
                var car = _dbContext.TypeOfCars.FirstOrDefault();
                if(car != null)
                {
                    if (!Utils.FormIsOpen("AddCarVehicleWindow"))
                    {
                        var editCarVehicleWindow = new AddCarVehicleWindow(car, this, true);
                        editCarVehicleWindow.Show();
                    }
                }
            }
          

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                var carId = (int)dgwVehical.SelectedRows[0].Cells["Id"].Value;
                var car = _dbContext.TypeOfCars.FirstOrDefault(c => c.Id == carId);
                if(car != null)
                {
                    DialogResult dialogResult = MessageBox.Show("Are you soure to delete this record ?",
                       "Delete", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning );
                    if (dialogResult == DialogResult.Yes)
                    {
                        _dbContext.TypeOfCars.Remove(car);
                        _dbContext.SaveChanges();
                        LoadCars();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error ", ex.Message);
            }
        }
    }
}
