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

namespace Car_Service_Management_System
{
    public partial class Vehicles : Form
    {
        SqlConnection con = new SqlConnection(DatabaseConnection.connectionString);

        public Vehicles()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblAddVehicle_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm?", "Alert", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnRef_Click(object sender, EventArgs e)
        {
            txtCustomerId.Clear();
            txtCN1.Clear();
            txtVN1.Clear();
            txtVB1.Clear();
            txtVNum1.Clear();
            txtCT1.Clear();
            txtCNum1.Clear();
            txtFT1.Clear();
            txtET1.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCustomerId.Text) || string.IsNullOrWhiteSpace(txtCN1.Text) || string.IsNullOrWhiteSpace(txtVN1.Text) || string.IsNullOrWhiteSpace(txtVB1.Text) || string.IsNullOrWhiteSpace(txtVNum1.Text) || string.IsNullOrWhiteSpace(txtCT1.Text) || string.IsNullOrWhiteSpace(txtCNum1.Text) || string.IsNullOrWhiteSpace(txtFT1.Text) || string.IsNullOrWhiteSpace(txtET1.Text))
            {
                MessageBox.Show("Please fill all the fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!applicationValidations.IsNumeric(txtCustomerId.Text) || !applicationValidations.IsNumeric(txtCT1.Text))
            {
                MessageBox.Show("Customer ID and Contact Number should contain numericals only ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtCT1.Text.Length != 10 && txtCT1.Text.Length != 12)
            {
                MessageBox.Show("Please enter a valid contact number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (int.Parse(txtCT1.Text) < 0)
            {
                MessageBox.Show("Invalid Contact Number. Should be positive", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (int.Parse(txtCustomerId.Text) < 0)
            {
                MessageBox.Show("Invalid ID. ID should be positive", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int Cid = int.Parse(txtCustomerId.Text);
                string Cname = txtCN1.Text;
                string Vname = txtVN1.Text;
                string Vbrand = txtVB1.Text;
                string Vnum = txtVNum1.Text;
                //long Teleno = long.Parse(txtCT1.Text);
                string Chassisnum = txtCNum1.Text;
                string Ftype = txtFT1.Text;
                string Etype = txtET1.Text;
                string Date = dateTimePicker1.Value.ToString("yyyy-MM-dd");

                string query = $"INSERT INTO vehicleDetail (customerId,CustomerName,VehicleName,VehicleBrand,VehicleNumber,CustomerTelNumber,ChassisNumber,FuelType,EngineType,Date)Values('{Cid}','{Cname}','{Vname}','{Vbrand}','{Vnum}',@contactNumber,'{Chassisnum}','{Ftype}','{Etype}','{Date}');";
                SqlCommand cmd = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@contactNumber", txtCT1.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Saved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                    con.Close();
                }
            }
        }
    }
}
