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
using System.Security.Cryptography;
using System.Xml.Linq;



namespace Car_Service_Management_System
{
    public partial class Vehicle_Details_Landing_Page : Form
    {
        public Vehicle_Details_Landing_Page()
        {
            InitializeComponent();
        }

        private void Vehicle_Details_Landing_Page_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;

            //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\ASUS\Desktop\Final connections\Car Service Management System\Database\CarManagementDatabase.mdf"";Integrated Security=True;Connect Timeout=30");
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\C# Practice\Car Service Management System\Car Service Management System\Database\CarManagementDatabase.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "SELECT * FROM vehicleDetail";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);

            dataGridView2.DataSource = DS.Tables[0];

            con.Close();
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            Vehicles vd = new Vehicles();
            vd.Show();
        }

        private void txtCID_TextChanged(object sender, EventArgs e)
        {
            if (txtCID.Text != "")
            {
                //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\ASUS\Desktop\Final connections\Car Service Management System\Database\CarManagementDatabase.mdf"";Integrated Security=True;Connect Timeout=30");
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\C# Practice\Car Service Management System\Car Service Management System\Database\CarManagementDatabase.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT * FROM vehicleDetail WHERE customerId LIKE '" + txtCID.Text + "%'";

                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);
                dataGridView2.DataSource = DS.Tables[0];

                con.Close();
            }
            else
            {
                //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\ASUS\Desktop\Final connections\Car Service Management System\Database\CarManagementDatabase.mdf"";Integrated Security=True;Connect Timeout=30");
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\C# Practice\Car Service Management System\Car Service Management System\Database\CarManagementDatabase.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT * FROM vehicleDetail WHERE customerId LIKE '" + txtCID.Text + "%'";

                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);
                dataGridView2.DataSource = DS.Tables[0];

                con.Close();
            }
        }

        int cid;

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView2.SelectedRows[0];

                cid = Convert.ToInt32(selectedRow.Cells["customerId"].Value);

                //MessageBox.Show("Clicked " + cid);

                using (SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\C# Practice\Car Service Management System\Car Service Management System\Database\CarManagementDatabase.mdf;Integrated Security=True;Connect Timeout=30"))
                {
                    connect.Open();

                    string pushData = $"SELECT * FROM vehicleDetail WHERE customerId = {cid}";
                    SqlCommand command = new SqlCommand(pushData, connect);
                    SqlDataReader reader = command.ExecuteReader();

                    panel2.Visible = true;

                    if (reader.Read())           // Checks if there is a row to read
                    {
                        txtCustomerId.Text = reader["customerId"].ToString();
                        txtCN.Text = reader["CustomerName"].ToString();
                        txtVN.Text = reader["VehicleName"].ToString();
                        txtVB.Text = reader["VehicleBrand"].ToString();
                        txtVNum.Text = reader["VehicleNumber"].ToString();
                        txtCT.Text = reader["CustomerTelNumber"].ToString();
                        txtCNum.Text = reader["ChassisNumber"].ToString();
                        txtFT.Text = reader["FuelType"].ToString();
                        txtET.Text = reader["EngineType"].ToString();
                        txtDate.Text = reader["Date"].ToString();
                    }
                    reader.Close();
                    connect.Close();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Data will be Deleted.Confirm?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\ASUS\Desktop\Final connections\Car Service Management System\Database\CarManagementDatabase.mdf"";Integrated Security=True;Connect Timeout=30");
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\C# Practice\Car Service Management System\Car Service Management System\Database\CarManagementDatabase.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "Delete from vehicleDetail where customerId=" + cid + "";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);
                
                Vehicle_Details_Landing_Page_Load(this, null);

                con.Close();
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Unsaved Data Will be Lost", "Are you sure?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }

        
        private void btNRef_Click(object sender, EventArgs e)
        {
            Vehicle_Details_Landing_Page_Load(this, null);
            txtCID.Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtCN.Text == "" || txtCNum.Text == "" || txtCT.Text == "" || txtCustomerId.Text == "" || txtDate.Text == "" || txtET.Text == "" || txtFT.Text == "" || txtVB.Text == "" || txtVN.Text == "" || txtVNum.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                string Cname = txtCN.Text;
                string Vname = txtVN.Text;
                string Vbrand = txtVB.Text;
                string Vnumber = txtVNum.Text;
                int Ctele = int.Parse(txtCT.Text);
                string Chassisnum = txtCNum.Text;
                String Ftype = txtFT.Text;
                String Etype = txtET.Text;
                String Date = txtDate.Text;

                if (MessageBox.Show("Data will be Updedated.Confirm?", "succses", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\ASUS\Desktop\Final connections\Car Service Management System\Database\CarManagementDatabase.mdf"";Integrated Security=True;Connect Timeout=30");
                    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\C# Practice\Car Service Management System\Car Service Management System\Database\CarManagementDatabase.mdf;Integrated Security=True;Connect Timeout=30");
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;

                    cmd.CommandText = "UPDATE vehicleDetail SET CustomerName='" + Cname + "' ,VehicleName='" + Vname + "' ,VehicleBrand='" + Vbrand + "' ,VehicleNumber='" + Vnumber + "' ,CustomerTelNumber=" + Ctele + ",ChassisNumber='" + Chassisnum + "',FuelType='" + Ftype + "',EngineType='" + Etype + "',Date='" + Date + "'  WHERE customerId='" + cid + "'";
                    SqlDataAdapter DA = new SqlDataAdapter(cmd);
                    DataSet DS = new DataSet();
                    DA.Fill(DS);
                    Vehicle_Details_Landing_Page_Load(this, null);
                    txtCID.Clear();

                    con.Close();
                }
            }
            

        }

    }
}