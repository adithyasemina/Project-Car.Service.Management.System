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

        //readonly SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\ASUS\Desktop\Final connections\Car Service Management System\Database\CarManagementDatabase.mdf"";Integrated Security=True;Connect Timeout=30");
        readonly SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\C# Practice\Car Service Management System\Car Service Management System\Database\CarManagementDatabase.mdf;Integrated Security=True;Connect Timeout=30");

        private void Employee_Load(object sender, EventArgs e)
        {
            BindData();

        }

        // Brian : Method to clear fields
        private void clearFieldsEmployee()
        {
            // Clear all textboxes after successfull addition
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }


        void BindData()
        {
            //SqlCommand cnn = new SqlCommand("Select * from Table", con);
            SqlCommand cnn = new SqlCommand("SELECT * FROM [employeeDetail]", con);
            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();

            da.Fill(table);

            // Brian: Changed from dataGridView1 to dataGridView2 because i didn't see any changes when kept in dataGridView1
            dataGridView2.DataSource = table;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();

            //SqlCommand enableIdentityInsertCmd = new SqlCommand("SET IDENTITY_INSERT [Table] ON", con);
            //enableIdentityInsertCmd.ExecuteNonQuery();

            // Brian: Added Id which was ommitted previously

            SqlCommand cnn = new SqlCommand("INSERT INTO [employeeDetail] (name, empId, position, age, address, salary, email) VALUES (@name, @Id, @position, @age, @address, @salary, @email)", con);

            cnn.Parameters.AddWithValue("@Name", textBox1.Text);

            // Brian: Added Id which was ommitted previously
            cnn.Parameters.AddWithValue("@Id", int.Parse(textBox4.Text));
            cnn.Parameters.AddWithValue("@Position", textBox3.Text);
            cnn.Parameters.AddWithValue("@Age", int.Parse(textBox4.Text));
            cnn.Parameters.AddWithValue("@Address", textBox5.Text);
            cnn.Parameters.AddWithValue("@Salary", int.Parse(textBox6.Text));
            cnn.Parameters.AddWithValue("@Email", textBox7.Text);

            // Brian: Checks amount of rows affected by query
            int rowsAffected = cnn.ExecuteNonQuery();


            //SqlCommand disableIdentityInsertCmd = new SqlCommand("SET IDENTITY_INSERT [Table] OFF", con);
            //disableIdentityInsertCmd.ExecuteNonQuery();


            con.Close();

            // Brian: IF ELSE block To show success or error messages and clear the textboxes
            if (rowsAffected > 0)
            {
                // Query executed successfully
                MessageBox.Show("Employee added successfully.");

                clearFieldsEmployee();
            }
            else
            {
                // No rows affected, query might not have executed successfully
                MessageBox.Show("Error: Employee not added.");

                clearFieldsEmployee();

                textBox1.Focus();
            }



            BindData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clearFieldsEmployee();
        }

        // variable for storing clicked id value
        int selectedId = 0;

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand cnn = new SqlCommand($"DELETE FROM [employeeDetail] WHERE empId = {selectedId}", con);

            // Brian: Checks amount of rows affected by query
            int rowsAffected = cnn.ExecuteNonQuery();


            // Brian: IF ELSE block To show success or error messages and clear the textboxes
            if (rowsAffected > 0)
            {
                // Query executed successfully
                MessageBox.Show("Employee deleted successfully.");

                clearFieldsEmployee();

                selectedId = 0;
            }
            else
            {
                // No rows affected, query might not have executed successfully
                MessageBox.Show("Error: Employee not deleted.");
                clearFieldsEmployee();
            }
            con.Close();
            BindData();
        }


        // Method responsible for identifying selected row
        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView2.SelectedRows[0];

                // Converting and storing value of 1st row into "id" varible
                int id = Convert.ToInt32(selectedRow.Cells["Empid"].Value);
                selectedId = id;
                MessageBox.Show($"clicked : {selectedId}");

            }
        }

        
    }
}