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
using System.Xml.Linq;

namespace Car_Service_Management_System
{
    public partial class Customers : Form
    {
        //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\ASUS\Desktop\Final connections\Car Service Management System\Database\CarManagementDatabase.mdf"";Integrated Security=True;Connect Timeout=30");
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\C# Practice\Car Service Management System\Car Service Management System\Database\CarManagementDatabase.mdf;Integrated Security=True;Connect Timeout=30");

        public Customers()
        {
            InitializeComponent();
        }


        private void Customers_Load(object sender, EventArgs e)
        {

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
            txtId.Clear();
            textBox1.Clear();
            textBox8.Clear();
            textBox7.Clear();
            textBox6.Clear();
            textBox5.Clear();
            textBox2.Clear();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            int CId = int.Parse(txtId.Text);
            string cname = textBox1.Text;
            string address = textBox8.Text;
            int contactno = int.Parse(textBox7.Text);
            string email = textBox6.Text;
            int nic = int.Parse(textBox5.Text);
            string vehicalno = textBox2.Text;
            string date = dateTimePicker1.Value.ToString("yyyy-MM-dd");

            String query = $"INSERT INTO Customer(customer_id,name,Address,contact_no,email,nicno,vehicalno,date) Values('{CId}','{cname}','{address}','{contactno}','{email}','{nic}','{vehicalno}','{date}');";
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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
