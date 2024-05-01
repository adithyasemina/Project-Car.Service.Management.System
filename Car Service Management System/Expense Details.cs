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
        string stringConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\ASUS\Desktop\Brian - Car Service Management System\Car Service Management System\Database\CarManagementDatabase.mdf"";Integrated Security=True;Connect Timeout=30;Encrypt=True";

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
        /* Brian : This event is not working
         *          The "Datetxt.Value" line also gives an error stating string isn't in proper format.
                        -Try to change the string from DD/MM/YYYY to YYYY/MM/DD 
                        -Else try to get only id column and fill the textboxes with values from the database.   */

        // Variable to store selected row
        int selectedId = 0;

        //Method to capture selected row
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                selectedId = Convert.ToInt32(selectedRow.Cells["Id"].Value);

                // MessageBox.Show("Clicked " + selectedId.ToString());

                using (SqlConnection connect = new SqlConnection(stringConnection))
                {
                    connect.Open();

                    string pushData = $"SELECT * FROM Income WHERE incomeId = {selectedId}";
                    SqlCommand command = new SqlCommand(pushData, connect);
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())           // Checks if there is a row to read
                    {
                        Categorytxt.SelectedItem = reader["category"].ToString();
                        Itemtxt.Text = reader["item"].ToString();
                        Costtxt.Text = reader["cost"].ToString();
                        Descriptiontxt.Text = reader["description"].ToString();
                        Datetxt.Value = Convert.ToDateTime(reader["date_income"]);
                    }
                    reader.Close();
                }
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

                    // Brian : didn't have income id so added that to the query.

                    /* Brain : assuming date_income --> @date_in  (The date user enters)
                     *          and date_insert --> @date (The date the record was inserted)   
                     *          From here and all events below      */

                    string insertData = "INSERT INTO Income (incomeId, category, item, cost, description, date_income,date_insert)" +
                        "VALUES(@id, @cat,@item,@income,@desc,@date_in, @date)";

                    using (SqlCommand cmd = new SqlCommand(insertData, connect))
                    {

                        cmd.Parameters.AddWithValue("@cat", Categorytxt.SelectedItem);
                        cmd.Parameters.AddWithValue("@item", Itemtxt.Text);
                        cmd.Parameters.AddWithValue("@income", Costtxt.Text);
                        cmd.Parameters.AddWithValue("@desc", Descriptiontxt.Text);
                        cmd.Parameters.AddWithValue("@date_in", Datetxt.Value);

                        /*Brian : Commented out because error pops up. Cannot chang the value of a field 2 times in the same query.
                         *          If necessary to take today's date uncomment it          */

                        //cmd.Parameters.AddWithValue("@date", Datetxt.Value); 

                        // Brian : Make the Key field(id) auto increment or Make a new textbox to enter Key field(id) value 
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

        // Brian : Some fields were missing put them to complete query
        private void button12_Click(object sender, EventArgs e)
        {
            if (Categorytxt.SelectedIndex == -1 || Itemtxt.Text == ""
               || Costtxt.Text == "" || Descriptiontxt.Text == "")
            {
                MessageBox.Show("Please select item first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to Update Id: " + selectedId + "?",
                    "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (SqlConnection connect = new SqlConnection(stringConnection))
                    {
                        connect.Open();

                        string updateData = "UPDATE Income SET category = @cat, item = @item, cost  = @income, description = @desc, date_income = @date_in, date_insert = @date WHERE incomeId = @id ";

                        using (SqlCommand cmd = new SqlCommand(updateData, connect))
                        {
                            cmd.Parameters.AddWithValue("@cat", Categorytxt.SelectedItem);
                            cmd.Parameters.AddWithValue("@item", Itemtxt.Text);
                            cmd.Parameters.AddWithValue("@income", Costtxt.Text);
                            cmd.Parameters.AddWithValue("@desc", Descriptiontxt.Text);
                            cmd.Parameters.AddWithValue("@date_in", Datetxt.Value);
                            cmd.Parameters.AddWithValue("@id", selectedId);

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
                if (MessageBox.Show("Are you sure you want to Delete Id: " + selectedId + "?",
                   "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    using (SqlConnection connect = new SqlConnection(stringConnection))
                    {
                        connect.Open();

                        string insertData = "DELETE FROM Income WHERE incomeId = @id";

                        using (SqlCommand cmd = new SqlCommand(insertData, connect))
                        {
                            // Brian : Removed all unnecessary parameter bindings.
                            cmd.Parameters.AddWithValue("@id", selectedId);

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