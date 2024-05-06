using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Car_Service_Management_System
{
    public partial class Admin_Login : Form
    {
        public Admin_Login()
        {
            InitializeComponent();
        }

        private void Admin_Login_Load(object sender, EventArgs e)
        {
            txtBoxUsername.Focus();
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
                try
                {
                    using (var connection = new SqlConnection(DatabaseConnection.connectionString))
                    {
                        connection.Open();
                        using (var command = new SqlCommand("SELECT COUNT(*) FROM Admin WHERE Username=@username AND Password=@password", connection))
                        {
                            command.Parameters.AddWithValue("@username", txtBoxUsername.Text);
                            command.Parameters.AddWithValue("@password", txtBoxPassword.Text);
                            int count = (int)command.ExecuteScalar();
                            if (count > 0)
                            {
                                MessageBox.Show("Login successful. Select the page you want to proceed with", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                
                                AdminSession.isLoggedIn = true;
                                txtBoxUsername.Clear();
                                txtBoxPassword.Clear();

                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Invalid username or password.", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtBoxUsername.Clear();
                                txtBoxPassword.Clear();

                                txtBoxUsername.Focus();
                            }
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"SQL error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Unexpected error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
