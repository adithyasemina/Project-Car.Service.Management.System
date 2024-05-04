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
            int Cid = int.Parse(txtCustomerId.Text);
            string Cname = txtCN1.Text;
            string Vname = txtVN1.Text;
            string Vbrand = txtVB1.Text;
            string Vnum = txtVNum1.Text;
            int Teleno = int.Parse(txtCT1.Text);
            string Chassisnum = txtCNum1.Text;
            string Ftype = txtFT1.Text;
            string Etype = txtET1.Text;
            string Date = dateTimePicker1.Value.ToString("yyyy-MM-dd");

            string query = $"INSERT INTO vehicleDetail (customerId,CustomerName,VehicleName,VehicleBrand,VehicleNumber,CustomerTelNumber,ChassisNumber,FuelType,EngineType,Date)Values('{Cid}','{Cname}','{Vname}','{Vbrand}','{Vnum}','{Teleno}','{Chassisnum}','{Ftype}','{Etype}','{Date}');";
            SqlCommand cmd = new SqlCommand(query, con);
            try
            {
                con.Open();
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
