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
    public partial class AddUser : Form
    {
        private readonly CarRentDbContext _dbContext = new CarRentDbContext();
        private ManageUsers _manageUsers;
        public AddUser(ManageUsers manageUsers)
        {
            _manageUsers = manageUsers;
        }
        public AddUser()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            var roles = _dbContext.Roles.ToList();
            cb_role.DataSource = roles;
            cb_role.ValueMember = "Id";
            cb_role.DisplayMember = "Name";
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            var user_name = tb_user_name.Text;
            var role_id = (int)cb_role.SelectedValue;
            var passworHash = Utils.DefaultHashPassword();
            var user = new User
            {
                Username = user_name,
                Password = passworHash,
                IsActive = true
            };
            _dbContext.Users.Add(user);
            _dbContext.SaveChanges();

            var user_id = user.Id;
            var user_role = new UserRole
            {
                UserId = user_id,
                RoleId = role_id
            };
            _dbContext.UserRoles.Add(user_role);
            _dbContext.SaveChanges();
            MessageBox.Show("User added");
            _manageUsers.PopulateGrid();
            Close();
        }
    }
}
