using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Service_Management_System
{
    public partial class Add_Inventory_Data : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\C# Practice\Car Service Management System\Car Service Management System\Database\CarManagementDatabase.mdf;Integrated Security=True;Connect Timeout=30");

        public Add_Inventory_Data()
        {
            InitializeComponent();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txtproductid.Text == "" || txtproductname.Text == "" || txtquantity.Text == "" || txtprice.Text == "" || txtmaintaincost.Text == "" )
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    using (SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\C# Practice\Car Service Management System\Car Service Management System\Database\CarManagementDatabase.mdf;Integrated Security=True;Connect Timeout=30"))
                    {
                        connect.Open();

                        string insertData = $"INSERT INTO inventoryData(ProductId,ProductName,Quantity,Price,MaintainCost,Date)Values(@ProductId, @ProductName, @Quantity,@Price,@MaintainCost,@Date);";
                        using (SqlCommand cmd = new SqlCommand(insertData, connect))
                        {
                            cmd.Parameters.AddWithValue("@ProductId", txtproductid.Text);
                            cmd.Parameters.AddWithValue("@ProductName", txtproductid.Text);
                            cmd.Parameters.AddWithValue("@Quantity", txtquantity.Text);
                            cmd.Parameters.AddWithValue("@Price", txtprice.Text);
                            cmd.Parameters.AddWithValue("@MaintainCost", txtmaintaincost.Text);
                            cmd.Parameters.AddWithValue("@Date", dateTimePicker1.Value);

                            cmd.ExecuteNonQuery();
                            clearFieldsInventoryAdd();
                            MessageBox.Show("Added successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        connect.Close();

                    }
                }
                catch (SqlAlreadyFilledException ex)
                {
                    MessageBox.Show(ex.Message);
                }

            } 
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearFieldsInventoryAdd();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // Show Form1
            Application.OpenForms["Inventory_Data_Landaing_Page"].Show();

            // Close form2
            this.Close();
        }

        void clearFieldsInventoryAdd()
        {
            txtproductid.Text = "";
            txtproductname.Text = "";
            txtquantity.Text = "";
            txtprice.Text = "";
            txtmaintaincost.Text = "";
        }

        
    }
}
