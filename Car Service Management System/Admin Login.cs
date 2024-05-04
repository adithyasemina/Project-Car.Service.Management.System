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

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both username and password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (username == "ADMIN" && password == "admin123")
                {
                    AdminSession.isLoggedIn = true;

                    txtBoxUsername.Clear();
                    txtBoxPassword.Clear();

                    MessageBox.Show("Admin login was successful. Click to view pages", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }
                else
                {
                    txtBoxUsername.Clear();
                    txtBoxPassword.Clear();

                    MessageBox.Show("Please enter correct username and password for Admin Login", "Error", MessageBoxButtons.OK);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBoxUsername.Clear();
            txtBoxPassword.Clear();
        }

    }
}
