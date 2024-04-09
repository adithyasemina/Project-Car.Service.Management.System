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
using System.Xml.Linq;
using System.IO;

namespace Vehicle_Details
{
    public partial class Add_Vehicle_Details : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\prabh\source\repos\Vehicle_Details\Vehicle_Details\Vehicle_Details_Database1.mdf;Integrated Security=True");
        public Add_Vehicle_Details()
        {
            InitializeComponent();
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
            //Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\prabh\source\repos\Vehicle_Details\Vehicle_Details\Vehicle_Details_Database1.mdf; Integrated Security = True
            Int64 Cid = Int64.Parse(txtCN1.Text);
            String Cname = txtCN1.Text;
            String Vname = txtVN1.Text;
            String Vbrand = txtVB1.Text;
            String Vnum = txtVNum1.Text;
            Int64 Teleno = Int64.Parse(txtCT1.Text);
            String Chassisnum = txtCNum1.Text;
            String Ftype = txtFT1.Text;
            String Etype = txtET1.Text;
            String Date = dateTimePicker1.Value.ToString("yyyy-MM-dd");

            String query = $"INSERT INTO Table(Id,Customer_name,Vehicle_name,Vehicle_brand,Vehicle_number,Customer_tel.number,Chassis_number,Fuel_type,Engine_type,Date)Values('{Cid}','{Cname}','{Vname}','{Vbrand}','{Vnum}','{Teleno}','{Chassisnum}','{Ftype}','{Etype}','{Date}');";
            SqlCommand cmd = new SqlCommand(query, con);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Saved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
