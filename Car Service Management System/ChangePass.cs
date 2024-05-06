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
    public partial class ChangePass : Form
    {
        public ChangePass()
        {
            InitializeComponent();
        }

        private void ChangePass_Load(object sender, EventArgs e)
        {
            txtBoxUsername.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBoxUsername.Clear();
            txtBoxPassword.Clear();
            txtBoxConfirmPassword.Clear();
        }

        private void btnuUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBoxUsername.Text) || string.IsNullOrWhiteSpace(txtBoxPassword.Text) || string.IsNullOrWhiteSpace(txtBoxConfirmPassword.Text))
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtBoxPassword.Text != txtBoxConfirmPassword.Text)
            {
                MessageBox.Show("Passord and Confirm Password Don't Match.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    using (var connection = new SqlConnection(DatabaseConnection.connectionString))
                    {
                        connection.Open();
                        using (var command = new SqlCommand("UPDATE Admin SET Username=@username, Password=@password WHERE Id = 1", connection))
                        {
                            command.Parameters.AddWithValue("@username", txtBoxUsername.Text);
                            command.Parameters.AddWithValue("@password", txtBoxPassword.Text);
                            int rowsAffected = command.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Updated Login Info Successfully.", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                AdminSession.isLoggedIn = false;

                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Failed to Update Login Info.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtBoxUsername.Focus();
                            }
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"SQL error: {ex.Message}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Unexpected error: {ex.Message}");
                }
            }
        }
    }
}
