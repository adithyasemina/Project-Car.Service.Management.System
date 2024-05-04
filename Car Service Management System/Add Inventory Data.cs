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

        public Add_Inventory_Data()
        {
            InitializeComponent();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtproductid.Text) || string.IsNullOrWhiteSpace(txtproductname.Text) || string.IsNullOrWhiteSpace(txtquantity.Text) || string.IsNullOrWhiteSpace(txtprice.Text) || string.IsNullOrWhiteSpace(txtmaintaincost.Text))
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!applicationValidations.IsNumeric(txtquantity.Text) || !applicationValidations.IsNumeric(txtprice.Text) || !applicationValidations.IsNumeric(txtmaintaincost.Text))
            {
                MessageBox.Show("Quantity, Price, and Maintain Cost must be numeric values", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (decimal.Parse(txtprice.Text) <= 0 || decimal.Parse(txtquantity.Text) <= 0 || decimal.Parse(txtmaintaincost.Text) <= 0)
            {
                MessageBox.Show("Price must be a positive value", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    using (SqlConnection connect = new SqlConnection(DatabaseConnection.connectionString))
                    {
                        connect.Open();

                        string insertData = $"INSERT INTO inventoryData(ProductId,ProductName,Quantity,Price,MaintainCost,Date)Values(@ProductId, @ProductName, @Quantity,@Price,@MaintainCost,@Date);";
                        using (SqlCommand cmd = new SqlCommand(insertData, connect))
                        {
                            cmd.Parameters.AddWithValue("@ProductId", txtproductid.Text);
                            cmd.Parameters.AddWithValue("@ProductName", txtproductname.Text);
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
            // Show Inventory_Data_Landaing_Page
           //pplication.OpenForms["Inventory_Data_Landaing_Page"].Show();

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
