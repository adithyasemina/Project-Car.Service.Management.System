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
    public partial class Expense_Details : Form
    {
        string stringConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\C# Practice\Car Service Management System\Car Service Management System\Database\CarManagementDatabase.mdf;Integrated Security=True;Connect Timeout=30";

        public Expense_Details()
        {
            InitializeComponent();

            displayCategyList();
            displayExpensesdate();
        }


        public void displayExpensesdate()
        {
            Expensesdate iData = new Expensesdate();
            List<Expensesdate> listData = iData.incomeListData();

            dataGridView1.DataSource = listData;
        }

        public void displayCategyList()
        {
            using (SqlConnection connect = new SqlConnection(stringConnection))
            {
                connect.Open();

                string selectData = "SELECT category FROM expenseCategories WHERE type = @type AND status = @status";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    cmd.Parameters.AddWithValue("@type", "Income");
                    cmd.Parameters.AddWithValue("@status", "Active");

                    Categorytxt.Items.Clear();

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Categorytxt.Items.Add(reader["category"].ToString());
                    }


                }

                connect.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private int getId = 0;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                getId = (int)row.Cells[0].Value;
                Categorytxt.SelectedItem = row.Cells[1].Value.ToString();
                Itemtxt.Text = row.Cells[2].Value.ToString();
                Costtxt.Text = row.Cells[3].Value.ToString();
                Descriptiontxt.Text = row.Cells[4].Value.ToString();
                Datetxt.Value = Convert.ToDateTime(row.Cells[5].Value.ToString());


            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (Categorytxt.SelectedIndex == -1 || Itemtxt.Text == ""
                || Costtxt.Text == "" || Descriptiontxt.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (SqlConnection connect = new SqlConnection(stringConnection))
                {
                    connect.Open();

                    string insertData = "INSERT INTO Income (incomeId, category, item, cost, description, date_income,date_insert)" +
                        "VALUES(@id, @cat,@item,@income,@desc,@date_in, @date)";

                    using (SqlCommand cmd = new SqlCommand(insertData, connect))
                    {
                        cmd.Parameters.AddWithValue("@cat", Categorytxt.SelectedItem);
                        cmd.Parameters.AddWithValue("@item", Itemtxt.Text);
                        cmd.Parameters.AddWithValue("@income", Costtxt.Text);
                        cmd.Parameters.AddWithValue("@desc", Descriptiontxt.Text);
                        cmd.Parameters.AddWithValue("@date_in", Datetxt.Value); 
                        //cmd.Parameters.AddWithValue("@date", Datetxt.Value);
                        cmd.Parameters.AddWithValue("@id", getId);

                        DateTime today = DateTime.Now;
                        cmd.Parameters.AddWithValue("@date", today);

                        cmd.ExecuteNonQuery();
                        clearFields();

                        MessageBox.Show("Added successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }

                    connect.Close();
                }
            }
            displayExpensesdate();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (Categorytxt.SelectedIndex == -1 || Itemtxt.Text == ""
               || Costtxt.Text == "" || Descriptiontxt.Text == "")
            {
                MessageBox.Show("Please select item first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to Update Id: " + getId + "?",
                    "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (SqlConnection connect = new SqlConnection(stringConnection))
                    {
                        connect.Open();

                        string updateData = "UPDATE Income SET category = @cat, item = @item, income = @income, description = @desc, date_income = @date_in, date_insert = @date WHERE incomeId = @id ";

                        using (SqlCommand cmd = new SqlCommand(updateData, connect))
                        {
                            cmd.Parameters.AddWithValue("@cat", Categorytxt.SelectedItem);
                            cmd.Parameters.AddWithValue("@item", Itemtxt.Text);
                            cmd.Parameters.AddWithValue("@income", Costtxt.Text);
                            cmd.Parameters.AddWithValue("@desc", Descriptiontxt.Text);
                            cmd.Parameters.AddWithValue("@date_in", Datetxt.Value);
                            cmd.Parameters.AddWithValue("@id", getId);

                            DateTime today = DateTime.Now;
                            cmd.Parameters.AddWithValue("@date", today);


                            cmd.ExecuteNonQuery();
                            clearFields();

                            MessageBox.Show("Updated successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }

                        connect.Close();
                    }
                }


            }
            displayExpensesdate();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (Categorytxt.SelectedIndex == -1 || Itemtxt.Text == ""
                || Costtxt.Text == "" || Descriptiontxt.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to Delete Id: " + getId + "?",
                   "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    using (SqlConnection connect = new SqlConnection(stringConnection))
                    {
                        connect.Open();

                        string insertData = "DELETE FROM Income WHERE incomeId = @id";

                        using (SqlCommand cmd = new SqlCommand(insertData, connect))
                        {
                            cmd.Parameters.AddWithValue("@id", getId);

                            cmd.ExecuteNonQuery();
                            clearFields();

                            MessageBox.Show("Delete successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }

                        connect.Close();
                    }
                }


            }
            displayExpensesdate();
        }

        public void clearFields()
        {
            Categorytxt.Text = "";
            Itemtxt.Text = "";
            Costtxt.Text = "";
            Descriptiontxt.Text = "";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            clearFields();
        }
    }
}
