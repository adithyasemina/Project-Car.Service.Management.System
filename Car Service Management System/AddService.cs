using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Car_Service_Management_System
{
    public partial class AddService : Form
    {
        SqlConnection con1 = new SqlConnection(DatabaseConnection.connectionString);

        public AddService()
        {
            InitializeComponent();
        }


        private void lblId_Click(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text) || string.IsNullOrWhiteSpace(txtService.Text) || string.IsNullOrWhiteSpace(txtVehicleNo.Text) || string.IsNullOrWhiteSpace(txtBrand.Text) || string.IsNullOrWhiteSpace(txtModel.Text) || string.IsNullOrWhiteSpace(txtSProvider.Text))
            {
                MessageBox.Show("Please fill all the textboxes", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!applicationValidations.IsNumeric(txtId.Text) || int.Parse(txtId.Text) <= 0)
            {
                MessageBox.Show("ID must be a positive integer", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int id = int.Parse(txtId.Text);
                string service = txtService.Text;
                string vehicleNo = txtVehicleNo.Text;
                string brand = txtBrand.Text;
                string model = txtModel.Text;
                DateTime date = dateTimePicker1.Value;
                string serviceProvider = txtSProvider.Text;

                if (MessageBox.Show("Are you sure you want to Add record : " + id + "?","Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string query = "INSERT INTO serviceHistory(serviceId, service, vehicleNo, brand, model, date, serviceProvider) VALUES (@id, @service, @vehicleNo, @brand, @model, @date, @serviceProvider)";

                    SqlCommand cmd = new SqlCommand(query, con1);

                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@service", service);
                    cmd.Parameters.AddWithValue("@vehicleNo", vehicleNo);
                    cmd.Parameters.AddWithValue("@brand", brand);
                    cmd.Parameters.AddWithValue("@model", model);
                    cmd.Parameters.AddWithValue("@date", date);
                    cmd.Parameters.AddWithValue("@serviceProvider", serviceProvider);

                    try
                    {
                        con1.Open();
                        cmd.ExecuteNonQuery();
                        con1.Close();
                        MessageBox.Show("Successfully Inserted Value");

                    }

                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                MessageBox.Show("Please fill the ID box first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int ID = int.Parse(txtId.Text);

                string query4 = $"DELETE FROM serviceHistory WHERE serviceId = " + ID + " ";

                SqlCommand cmd3 = new SqlCommand(query4, con1);
                try
                {
                    con1.Open();
                    cmd3.ExecuteNonQuery();
                    con1.Close();
                    MessageBox.Show("Successfully deleted");

                }

                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text) || string.IsNullOrWhiteSpace(txtService.Text) || string.IsNullOrWhiteSpace(txtVehicleNo.Text) || string.IsNullOrWhiteSpace(txtBrand.Text) || string.IsNullOrWhiteSpace(txtModel.Text) || string.IsNullOrWhiteSpace(txtSProvider.Text))
            {
                MessageBox.Show("Please fill all the textboxes", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!applicationValidations.IsNumeric(txtId.Text) || int.Parse(txtId.Text) <= 0)
            {
                MessageBox.Show("ID must be a positive integer", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (dateTimePicker1.Value > DateTime.Today)
            {
                MessageBox.Show("Enter a valid Date", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int id = int.Parse(txtId.Text);
                string service = txtService.Text;
                string vehicleNo = txtVehicleNo.Text;
                string brand = txtBrand.Text;
                string model = txtModel.Text;
                DateTime date = DateTime.Today;
                string serviceProvider = txtSProvider.Text;

                string query = $"update serviceHistory SET service = @service, vehicleNo = @vehicleNo, brand = @brand, model = @model, date = @date, serviceProvider = @service WHERE serviceId = @id";

                SqlCommand cmd = new SqlCommand(query, con1);

                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@service", service);
                cmd.Parameters.AddWithValue("@vehicleNo", vehicleNo);
                cmd.Parameters.AddWithValue("@brand", brand);
                cmd.Parameters.AddWithValue("@model", model);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@serviceProvider", serviceProvider);

                try
                {
                    con1.Open();
                    cmd.ExecuteNonQuery();
                    con1.Close();
                    MessageBox.Show("Successfully updated Value");

                }

                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void AddService_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}