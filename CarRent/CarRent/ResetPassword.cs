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
    public partial class ChangePassword : Form
    {
        private readonly CarRentDbContext _dbContext = new CarRentDbContext();
        private int _id;
        public ChangePassword()
        {
            InitializeComponent();
        }
        public ChangePassword(int id)
        {
            _id = id;
        }
        private void Btn_resetPassword_Click(object sender, EventArgs e)
        {
            
        }

        private void Btn_changePassword_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrWhiteSpace(Tb_NewPassword.Text) || string.IsNullOrWhiteSpace(Tb_ConfirmPassword.Text)))
            {
                if (Tb_NewPassword.Text == Tb_ConfirmPassword.Text)
                {
                    if (Utils.HashPassword(Tb_NewPassword.Text) == Utils.DefaultHashPassword())
                    {
                        MessageBox.Show("Using default password is not allowed!");
                    }
                    else
                    {
                        //save to database
                        var user = _dbContext.Users.FirstOrDefault(x => x.Id == _id);
                        user.Password = Utils.HashPassword(Tb_ConfirmPassword.Text);
                        _dbContext.SaveChanges();
                        MessageBox.Show("Data saved to db");
                    }
                }
                else
                {
                    MessageBox.Show("Passwords are different");
                    Tb_NewPassword.Clear();
                    Tb_NewPassword.Clear();
                }
            }
            else
            {
                MessageBox.Show("enter password first");
            }
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {

        }
    }
}
