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
    public partial class ManageUsers : Form
    {
        private readonly CarRentDbContext _dbContext = new CarRentDbContext();
        
        public ManageUsers()
        {
            InitializeComponent();

        }

        private void Btn_ResetPassword_Click(object sender, EventArgs e)
        {
            try
            {
                //get id of selected row  from grid
                var id = (int)dataGridUsers.SelectedRows[0].Cells["Id"].Value;
                //get user by id
                var user = _dbContext.Users.FirstOrDefault(x => x.Id == id);//user model
                string hashedPassword = Utils.DefaultHashPassword();
                user.Password = hashedPassword;
                _dbContext.SaveChanges();
                MessageBox.Show("Password was reset");

                PopulateGrid();

            }
            catch (Exception)
            {

                throw;
            }
        }

        public void PopulateGrid()
        {
            var users = _dbContext.Users.Select(x => new
            {
                x.Id,
                x.Username,
                x.UserRoles.FirstOrDefault().Role.Name,
                x.IsActive
            }).ToList();

            dataGridUsers.DataSource = users;

            dataGridUsers.Columns["Username"].HeaderText = "Username";
            dataGridUsers.Columns["Name"].HeaderText = "Role Name";
            dataGridUsers.Columns["IsActive"].HeaderText = "Active";
            dataGridUsers.Columns["Id"].Visible = false;
        }

        private void Btn_Refresh_Click(object sender, EventArgs e)
        {
            PopulateGrid();
        }

        private void ManageUsers_Load(object sender, EventArgs e)
        {
            PopulateGrid();
        }

        private void Btn_ActivateDisactivateUser_Click(object sender, EventArgs e)
        {
            try
            {
                var id = (int)dataGridUsers.SelectedRows[0].Cells["Id"].Value;
                //MessageBox.Show(id.ToString());
                var user = _dbContext.Users.FirstOrDefault(x => x.Id == id);
                if(user != null)
                {
                    user.IsActive = !user.IsActive;
                    //user.IsActive = user.IsActive == true? false : true;
                    _dbContext.SaveChanges();
                    MessageBox.Show("User status was changed");
                    PopulateGrid();
                }
                else
                {
                    MessageBox.Show("User doesn't exist");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void button_change_password_Click(object sender, EventArgs e)
        {
            var id = (int)dataGridUsers.SelectedRows[0].Cells["Id"].Value;
            var change_pass_window = new ChangePassword(id);
            change_pass_window.Show();
            Hide();

        }

        private void Btn_AddNewUser_Click(object sender, EventArgs e)
        {
            var addUser = new AddUser();
            addUser.Show();
        }
    }
}
