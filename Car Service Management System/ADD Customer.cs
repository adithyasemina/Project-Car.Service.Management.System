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
    public partial class ADD_Customer : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\pc\source\repos\project_nsbm\project_nsbm\AddcustomerDatabase1.mdf;Integrated Security=True");
        public ADD_Customer()
        {
            InitializeComponent();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm?", "Alert", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            txtcid.Clear();
            txtname.Clear();
            txtadress.Clear();
            txtcno.Clear();
            txtemail.Clear();
            txtnic.Clear();
            txtvno.Clear();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {//Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\pc\source\repos\project_nsbm\project_nsbm\AddcustomerDatabase1.mdf;Integrated Security=True
            Int64 CId = Int64.Parse(txtcid.Text);
            string cname = txtname.Text;
            string adress = txtadress.Text;
            Int64 contactno = Int64.Parse(txtcno.Text);
            string email = txtemail.Text;
            Int64 nic = Int64.Parse(txtnic.Text);
            string vehicalno = txtvno.Text;
            String date = dateTimePicker1.Value.ToString("yyyy-MM-dd");

            String query = $"INSERT INTO Customer(customer_id,name,Adress,contact_no,email,nicno,vehicalno,date) Values('{CId}','{cname}','{adress}','{contactno}','{email}','{nic}','{vehicalno}','{date}');";
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
            }


        }
    }
}
