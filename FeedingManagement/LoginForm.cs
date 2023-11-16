using Repositories.IRepository;
using Repositories.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FeedingManagement
{
    public partial class LoginForm : Form
    {
        IUserRepository _userRepository = new UserRepository();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            if (_userRepository.GetUser(email, password) != null)
            {
                
            }
            else
            {
                MessageBox.Show("You do not have access to this application", "Login Failed");
            }
        }
    }
}
