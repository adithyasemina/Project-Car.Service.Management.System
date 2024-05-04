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
        SqlConnection con = new SqlConnection(DatabaseConnection.connectionString);

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
            if (string.IsNullOrWhiteSpace(txtId.Text) ||string.IsNullOrWhiteSpace(textBox1.Text) ||string.IsNullOrWhiteSpace(textBox8.Text) ||string.IsNullOrWhiteSpace(textBox7.Text) ||string.IsNullOrWhiteSpace(textBox6.Text) ||string.IsNullOrWhiteSpace(textBox5.Text) ||string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Please fill blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!applicationValidations.IsNumeric(txtId.Text) || int.Parse(txtId.Text) < 0 || !applicationValidations.IsNumeric(textBox7.Text) || long.Parse(textBox7.Text) < 0 ||!applicationValidations.IsNumeric(textBox5.Text) || long.Parse(textBox5.Text) < 0)
            {
                MessageBox.Show("Customer Id , Contact Number, NIC should be positive integers", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBox7.Text.Length != 10 && textBox7.Text.Length != 12)
            {
                MessageBox.Show("Enter valid Contact Number", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBox5.Text.Length != 12)
            {
                MessageBox.Show("Enter valid NIC ", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int CId = int.Parse(txtId.Text);
                string cname = textBox1.Text;
                string address = textBox8.Text;
                long contactno = long.Parse(textBox7.Text);
                string email = textBox6.Text;
                long nic = long.Parse(textBox5.Text);
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
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
