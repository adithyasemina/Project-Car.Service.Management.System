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
        public Inventory_Data_Landaing_Page()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add_Inventory_Data In = new Add_Inventory_Data();
            In.Show();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }
        private void
            btnaddproduct_Click(object sender, EventArgs e)
        {
            Add_Inventory_Data ad = new Add_Inventory_Data();
            ad.Show();
        }
        private void btndelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Data will be Deleted.Confirm?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

        }
        private void butcancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Unsaved Data Will be Lost", "Are you sure?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }

        }
        private void Inventory_Data_Landaing_Page_Load(object sender, EventArgs e)
        {
            panel3.Visible = false;
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\ASUS\Desktop\Brian - Car Service Management System\Car Service Management System\Database\CarManagementDatabase.mdf"";Integrated Security=True;Connect Timeout=30;Encrypt=True");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from inventoryData";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);

            dataGridView1.DataSource = DS.Tables[0];

        }
        private void txtcid_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\ASUS\Desktop\Brian - Car Service Management System\Car Service Management System\Database\CarManagementDatabase.mdf"";Integrated Security=True;Connect Timeout=30;Encrypt=True");
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select * from Customer where customer_id LIKE '" + textBox1.Text + "%'";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);
                dataGridView1.DataSource = DS.Tables[0];
            }
            else
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\ASUS\Desktop\Brian - Car Service Management System\Car Service Management System\Database\CarManagementDatabase.mdf"";Integrated Security=True;Connect Timeout=30;Encrypt=True");
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select * from inventoryData";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

                dataGridView1.DataSource = DS.Tables[0];
            }
        }
        int productid;
        Int64 rowid;

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                productid = int.Parse(dataGridView1());
            }

            panel3.Visible = true;
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\ASUS\Desktop\Brian - Car Service Management System\Car Service Management System\Database\CarManagementDatabase.mdf"";Integrated Security=True;Connect Timeout=30;Encrypt=True");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from inventoryData";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);

            rowid = Int64.Parse(DS.Tables[0].Rows[0][0].ToString());
            txtproductname.Text = DS.Tables[0].Rows[0][1].ToString();
            txtquantity.Text = DS.Tables[0].Rows[0][2].ToString();
            txtprice.Text = DS.Tables[0].Rows[0][3].ToString();
            txtmaintaincost.Text = DS.Tables[0].Rows[0][4].ToString();
            dateTimePicker1.Text = DS.Tables[0].Rows[0][5].ToString();
        }

        private void btrefresh_Click(object sender, EventArgs e)
        {
            Inventory_Data_Landaing_Page_Load(this, null);
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            Int64 productid = Int64.Parse(txtproductid.Text);
            string productname = txtproductname.Text;
            string quantity = txtquantity.Text;
            string price = txtprice.Text;
            string maintaincost = txtmaintaincost.Text;
            string date = dateTimePicker1.Text;
            if (MessageBox.Show("Data will be Updedated.Confirm?", "succses", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {

            }

        }

        private void Inventory_Data_Landaing_Page_Load_1(object sender, EventArgs e)
        {

        }
    }
}