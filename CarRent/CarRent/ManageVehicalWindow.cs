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
    }
}
