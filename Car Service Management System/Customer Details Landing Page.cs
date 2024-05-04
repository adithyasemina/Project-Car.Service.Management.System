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

namespace Car_Service_Management_System
{
    public partial class Customer_Details_Landing_Page : Form
    {
        public Customer_Details_Landing_Page()
        {
            InitializeComponent();
        }

        private void Customer_Details_Landing_Page_Load(object sender, EventArgs e)
        {
            customerTableFill();
        }

        int rowid = -1;

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                rowid = Convert.ToInt32(selectedRow.Cells["customer_Id"].Value);

                // MessageBox.Show("Clicked " + selectedId.ToString());

                using (SqlConnection connect = new SqlConnection(DatabaseConnection.connectionString))
                {
                    connect.Open();

                    string pushData = $"SELECT * FROM Customer WHERE customer_Id = {rowid}";
                    SqlCommand command = new SqlCommand(pushData, connect);
                    SqlDataReader reader = command.ExecuteReader();

                    panel3.Visible = true;

                    if (reader.Read())           // Checks if there is a row to read
                    {
                        txtcid.Text = reader["customer_Id"].ToString();
                        txtId.Text = reader["customer_Id"].ToString();
                        txtcname.Text = reader["name"].ToString();
                        txtadrs.Text = reader["Address"].ToString();
                        txtcnno.Text = reader["contact_no"].ToString();
                        txtmail.Text = reader["email"].ToString();
                        txtnicno.Text = reader["nicno"].ToString();
                        txtveno.Text = reader["vehicalno"].ToString();
                        txtdate.Text = reader["date"].ToString();
                    }
                    reader.Close();
                    connect.Close();
                }


            }
        }

        private void txtcid_TextChanged(object sender, EventArgs e)
        {
            if (txtcid.Text != "")
            {
                SqlConnection con = new SqlConnection(DatabaseConnection.connectionString);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select * from Customer where customer_Id LIKE '" + txtcid.Text + "%'";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);
                dataGridView1.DataSource = DS.Tables[0];
            }
            else
            {
                customerTableFill();
            }
        }

        private void btnaddcustomr_Click(object sender, EventArgs e)
        {
            Customers ad = new Customers();
            ad.Show();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "" || txtcname.Text == "" || txtadrs.Text == "" || txtcnno.Text == "" || txtdate.Text == "" || txtmail.Text == "" || txtnicno.Text == "" || txtveno.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                if (MessageBox.Show("Data will be Deleted.Confirm?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {

                    SqlConnection con = new SqlConnection(DatabaseConnection.connectionString);
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;

                    cmd.CommandText = "Delete from Customer where customer_Id=" + rowid + "";
                    SqlDataAdapter DA = new SqlDataAdapter(cmd);
                    DataSet DS = new DataSet();
                    DA.Fill(DS);
                    Customer_Details_Landing_Page_Load(this, null);
                    customerTextboxesClear();
                    rowid = -1;
                }
            }
            
        }

        private void butncancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Unsaved Data Will be Lost", "Are you sure?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btrefresh_Click(object sender, EventArgs e)
        {
            Customer_Details_Landing_Page_Load(this, null);
            customerTextboxesClear();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "" || txtcname.Text == "" || txtadrs.Text == "" || txtcnno.Text == "" || txtdate.Text == "" || txtmail.Text == "" || txtnicno.Text == "" || txtveno.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                if (MessageBox.Show("Data will be Updedated.Confirm?", "succses", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    SqlConnection con = new SqlConnection(DatabaseConnection.connectionString);
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;

                    cmd.CommandText = "UPDATE Customer SET name = @name, Address = @Address, contact_no  = @contact_no, email = @email, nicno = @nicno, vehicalno = @vehicalno, date = @date  WHERE customer_Id = @customer_id ";

                    cmd.Parameters.AddWithValue("@customer_id", txtId.Text);
                    cmd.Parameters.AddWithValue("@name", txtcname.Text);
                    cmd.Parameters.AddWithValue("@Address", txtadrs.Text);
                    cmd.Parameters.AddWithValue("@contact_no", txtcnno.Text);
                    cmd.Parameters.AddWithValue("@email", txtmail.Text);
                    cmd.Parameters.AddWithValue("@nicno", txtnicno.Text);
                    cmd.Parameters.AddWithValue("@vehicalno", txtveno.Text);
                    cmd.Parameters.AddWithValue("@date", txtdate.Text);

                    SqlDataAdapter DA = new SqlDataAdapter(cmd);
                    DataSet DS = new DataSet();
                    DA.Fill(DS);
                    Customer_Details_Landing_Page_Load(this, null);
                    customerTextboxesClear();
                    rowid = -1;

                    con.Close();
                }
            }

        }

        void customerTableFill()
        {
            panel3.Visible = false;
            SqlConnection con = new SqlConnection(DatabaseConnection.connectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from Customer";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);

            dataGridView1.DataSource = DS.Tables[0];
        }

        void customerTextboxesClear()
        {
            txtadrs.Clear();
            txtcid.Clear();
            txtcname.Clear();
            txtcnno.Clear();
            txtdate.Clear();
            txtId.Clear();
            txtmail.Clear();
            txtnicno.Clear();
            txtveno.Clear();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtcnno_TextChanged(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblEmpId_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

