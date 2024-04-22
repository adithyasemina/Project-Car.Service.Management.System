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
using System.Net.Sockets;

namespace Car_Service_Management_System
{
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }

        //readonly SqlConnection con = new SqlConnection(@"Data Source=MSI;Initial Catalog=employee_details;Integrated Security=True;Encrypt=False;Trust Server Certificate=True");
        readonly SqlConnection con = new SqlConnection(@"Data Source=MSI;Initial Catalog=employee_details;Integrated Security=True;");

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Employee_Load(object sender, EventArgs e)
        {
            BindData();

        }
        void BindData()
        {
            //SqlCommand cnn = new SqlCommand("Select * from Table", con);
            SqlCommand cnn = new SqlCommand("SELECT * FROM [Table]", con);
            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();

            da.Fill(table);

            dataGridView1.DataSource = table;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand enableIdentityInsertCmd = new SqlCommand("SET IDENTITY_INSERT [Table] ON", con);
            enableIdentityInsertCmd.ExecuteNonQuery();


            SqlCommand cnn = new SqlCommand("INSERT INTO [Table] (name, position, age, address, salary, email) VALUES (@name, @position, @age, @address, @salary, @email)", con);

            cnn.Parameters.AddWithValue("@Name", textBox1.Text);
            cnn.Parameters.AddWithValue("@Position", textBox3.Text);
            cnn.Parameters.AddWithValue("@Age", int.Parse(textBox4.Text));
            cnn.Parameters.AddWithValue("@Address", textBox5.Text);
            cnn.Parameters.AddWithValue("@Salary", int.Parse(textBox6.Text));
            cnn.Parameters.AddWithValue("@Email", textBox7.Text);

            cnn.ExecuteNonQuery();


            SqlCommand disableIdentityInsertCmd = new SqlCommand("SET IDENTITY_INSERT [Table] OFF", con);
            disableIdentityInsertCmd.ExecuteNonQuery();


            con.Close();

            BindData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
        }
    }
}