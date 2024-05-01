using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Service_Management_System
{
    public partial class Admin_Login : Form
    {
        public Admin_Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username, password;

            username = txtBoxUsername.Text;
            password = txtBoxPassword.Text;

            if (username == "ADMIN" && password == "admin123")
            {
                AdminSession.isLoggedIn = true;

                txtBoxUsername.Clear();
                txtBoxPassword.Clear();

                // Load form2 and hide form1
                Admin_Login_Followup form2 = new Admin_Login_Followup();
                form2.Show();
                this.Hide();
            }
            else
            {
                txtBoxUsername.Clear();
                txtBoxPassword.Clear();

                MessageBox.Show("Please enter correct username and password for Admin Login", "Error", MessageBoxButtons.OK);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBoxUsername.Clear();
            txtBoxPassword.Clear();
        }

    }
}
