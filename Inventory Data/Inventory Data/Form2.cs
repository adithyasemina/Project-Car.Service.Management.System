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
using System.Data.SqlTypes;




namespace Inventory_Data
{
    public partial class Form2 : Form
    {   SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLocalDB;AttachDbFilename=C:\Users\pc\source\repos\project_nsbm\project_nsbm\AddcustomerDatabase1.mdf;IntegratedSecurity=True")
        

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = "C:\Users\Jayani\source\repos\Inventory Data\Inventory Data\Database1.mdf"; Integrated Security = True
        }

        private void btnsave_Click(object sender, EventArgs e)
        { 
            Int64 productid = Int64.Parse(txtproductid.Text);
            string productname = txtproductname.Text;
            string quantity = txtquantity.Text;
            string price = txtprice.Text;
            string maintaincost = txtmaintaincost.Text;
            string date = dateTimePicker1.Text;

            String query=$"INSERT INTO Inventory Data(productid,productname,quantity,price,maintaincost,date)Values('{productid}', '{productname}', '{quantity}', '{maintaincost}', '{date}');";
            SqlCommand cmd = new SqlCommand(query.con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Saved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
            }

            catch(SqlAlreadyFilledException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
