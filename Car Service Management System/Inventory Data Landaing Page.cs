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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Security.Cryptography;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;



namespace Car_Service_Management_System
{
    public partial class Inventory_Data_Landaing_Page : Form
    {

        int productid;

        public Inventory_Data_Landaing_Page()
        {
            InitializeComponent();
        }

        private void Inventory_Data_Landaing_Page_Load(object sender, EventArgs e)
        {
            showTable();
        }

        private void btnaddproduct_Click(object sender, EventArgs e)
        {
            Add_Inventory_Data In = new Add_Inventory_Data();
            In.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\ASUS\Desktop\Final connections\Car Service Management System\Database\CarManagementDatabase.mdf"";Integrated Security=True;Connect Timeout=30");
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\C# Practice\Car Service Management System\Car Service Management System\Database\CarManagementDatabase.mdf;Integrated Security=True;Connect Timeout=30");
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "SELECT * FROM inventoryData WHERE ProductId LIKE '" + textBox1.Text + "%'";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);
                dataGridView1.DataSource = DS.Tables[0];
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                productid = Convert.ToInt32(selectedRow.Cells["ProductId"].Value);

                //using (SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\ASUS\Desktop\Final connections\Car Service Management System\Database\CarManagementDatabase.mdf"";Integrated Security=True;Connect Timeout=30"))
                using (SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\C# Practice\Car Service Management System\Car Service Management System\Database\CarManagementDatabase.mdf;Integrated Security=True;Connect Timeout=30"))
                {
                    connect.Open();

                    string pushData = $"SELECT * FROM inventoryData WHERE ProductId = {productid}";
                    SqlCommand command = new SqlCommand(pushData, connect);
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())           // Checks if there is a row to read
                    {
                        txtproductid.Text = reader["ProductId"].ToString();
                        txtprice.Text = reader["Price"].ToString();
                        txtproductname.Text = reader["ProductName"].ToString();
                        txtmaintaincost.Text = reader["MaintainCost"].ToString();
                        txtquantity.Text = reader["Quantity"].ToString();
                        dateTimePicker1.Text = reader["Date"].ToString();

                    }
                    reader.Close();
                    connect.Close();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtproductid.Text == "" || txtproductname.Text == "" || txtquantity.Text == "" || txtprice.Text == "" || txtmaintaincost.Text == "" || dateTimePicker1.Text == "")
            {
                MessageBox.Show("Please select item first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to Update Id: " + productid + "?",
                    "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\ASUS\Desktop\Final connections\Car Service Management System\Database\CarManagementDatabase.mdf"";Integrated Security=True;Connect Timeout=30");
                    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\C# Practice\Car Service Management System\Car Service Management System\Database\CarManagementDatabase.mdf;Integrated Security=True;Connect Timeout=30");
                    con.Open();

                    SqlCommand cnn = new SqlCommand($"DELETE FROM inventoryData WHERE ProductId = {productid}", con);

                    int rowsAffected = cnn.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        // Query executed successfully
                        MessageBox.Show("Record deleted successfully.");

                        clearFieldsInventory();

                        productid = 0;
                    }
                    else
                    {
                        // No rows affected, query might not have executed successfully
                        MessageBox.Show("Error: Record not deleted.");
                        clearFieldsInventory();
                    }

                    con.Close();
                    showTable();
                }
            }
        }
            

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtproductid.Text == "" || txtproductname.Text == "" || txtquantity.Text == "" || txtprice.Text == "" || txtmaintaincost.Text == "" || dateTimePicker1.Text == "")
            {
                MessageBox.Show("Please select item first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to Update Record No : " + productid + "?",
                    "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\ASUS\Desktop\Final connections\Car Service Management System\Database\CarManagementDatabase.mdf"";Integrated Security=True;Connect Timeout=30");
                    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\C# Practice\Car Service Management System\Car Service Management System\Database\CarManagementDatabase.mdf;Integrated Security=True;Connect Timeout=30");

                    con.Open();

                    string updateData = "UPDATE inventoryData SET Date = @date, ProductName = @productName, Quantity  = @quantity, Price = @price, MaintainCost = @maintainCost WHERE ProductId = @productId ";

                    using (SqlCommand cmd = new SqlCommand(updateData, con))
                    {
                        cmd.Parameters.AddWithValue("@date", dateTimePicker1.Text);
                        cmd.Parameters.AddWithValue("@productName", txtproductname.Text);
                        cmd.Parameters.AddWithValue("@quantity", txtquantity.Text);
                        cmd.Parameters.AddWithValue("@price", txtprice.Text);
                        cmd.Parameters.AddWithValue("@maintainCost", txtmaintaincost.Text);
                        cmd.Parameters.AddWithValue("@productId", productid);



                        cmd.ExecuteNonQuery();
                        clearFieldsInventory();

                        MessageBox.Show("Updated successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }

                    con.Close();
                }
            }
            showTable();
        }

        void showTable()
        {
            //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\ASUS\Desktop\Final connections\Car Service Management System\Database\CarManagementDatabase.mdf"";Integrated Security=True;Connect Timeout=30");
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\C# Practice\Car Service Management System\Car Service Management System\Database\CarManagementDatabase.mdf;Integrated Security=True;Connect Timeout=30");
            SqlCommand cnn = new SqlCommand("SELECT * FROM inventoryData", con);
            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();

            da.Fill(table);

            dataGridView1.DataSource = table;
        }

        void clearFieldsInventory()
        {
            txtproductid.Text = "";
            txtproductname.Text = "";
            txtquantity.Text = "";
            txtprice.Text = "";
            txtmaintaincost.Text = "";
            dateTimePicker1.Text = "";
            textBox1.Text = "";
        }

    }
}