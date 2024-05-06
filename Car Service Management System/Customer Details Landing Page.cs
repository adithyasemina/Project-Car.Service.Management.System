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
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                    if (int.TryParse(selectedRow.Cells["customer_Id"].Value.ToString(), out _))
                    {
                        try
                        {
                            rowid = Convert.ToInt32(selectedRow.Cells["customer_Id"].Value);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("An error occurred while retrieving customer ID: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        //MessageBox.Show(rowid.ToString());
                        using (SqlConnection connect = new SqlConnection(DatabaseConnection.connectionString))
                        {
                            connect.Open();

                            string pushData = $"SELECT * FROM Customer WHERE customer_Id = {rowid}";
                            SqlCommand command = new SqlCommand(pushData, connect);
                            SqlDataReader reader = command.ExecuteReader();

                            panel3.Visible = true;

                            if (reader.Read())           // Checks if there is a row to read
                            {
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
                    else
                    {
                        MessageBox.Show("Invalid selection. Please select a valid row.", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        customerTextboxesClear();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while retrieving customer data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txtcid_TextChanged(object sender, EventArgs e)
        {
            try
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
            catch (SqlException ex)
            {
                MessageBox.Show("An error occurred while retrieving customer data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnaddcustomr_Click(object sender, EventArgs e)
        {
            Customers ad = new Customers();
            ad.Show();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text) || string.IsNullOrWhiteSpace(txtcname.Text) || string.IsNullOrWhiteSpace(txtadrs.Text) || string.IsNullOrWhiteSpace(txtcnno.Text) || string.IsNullOrWhiteSpace(txtdate.Text) || string.IsNullOrWhiteSpace(txtmail.Text) || string.IsNullOrWhiteSpace(txtnicno.Text) || string.IsNullOrWhiteSpace(txtveno.Text))
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                if (MessageBox.Show("Data will be Deleted.Confirm?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    try
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
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while deleting customer data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


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
            if (string.IsNullOrWhiteSpace(txtId.Text) || string.IsNullOrWhiteSpace(txtcname.Text) || string.IsNullOrWhiteSpace(txtadrs.Text) || string.IsNullOrWhiteSpace(txtcnno.Text) || string.IsNullOrWhiteSpace(txtdate.Text) || string.IsNullOrWhiteSpace(txtmail.Text) || string.IsNullOrWhiteSpace(txtnicno.Text) || string.IsNullOrWhiteSpace(txtveno.Text))
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                try
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
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while Updating customer data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }

        void customerTableFill()
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while retrieving customer data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

