using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Globalization;

namespace Car_Service_Management_System
{
    public partial class Statistics : Form
    {
        public Statistics()
        {
            InitializeComponent();
        }

        private void Statistics_Load(object sender, EventArgs e)
        {
            TodayOrders();
            totalBookingsForMonth();
            remainingBookingsToday();
            CalculateMonthExpense();
        }

        void TodayOrders()
        {
            using (SqlConnection connection = new SqlConnection(DatabaseConnection.connectionString))
            {
                int numberOfBookings = 0;
                string todayDate = DateTime.Now.ToString("dd-MMM-yyyy");

                MessageBox.Show("todayDate : " + todayDate);
                string query = "SELECT COUNT(*) FROM tbl_calendar WHERE date = @TodayDate";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@TodayDate", todayDate);

                try
                {
                    connection.Open();
                    numberOfBookings = (int)command.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    return;
                }
                finally
                {
                    label4.Text = Convert.ToString(numberOfBookings);
                }
            }

        }


        void totalBookingsForMonth()
        {
            // Get the current month and year
            int currentMonth = DateTime.Now.Month;
            int currentYear = DateTime.Now.Year;

            string query = $"SELECT COUNT(*) FROM tbl_calendar WHERE MONTH(date) = {currentMonth} AND YEAR(date) = {currentYear}";

            using (SqlConnection connection = new SqlConnection(DatabaseConnection.connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        int totalBookings = (int)command.ExecuteScalar();
                        label6.Text = Convert.ToString(totalBookings);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        void remainingBookingsToday()
        {
            using (SqlConnection connection = new SqlConnection(DatabaseConnection.connectionString))
            {
                try
                {
                    connection.Open();

                    // Get the current date and time
                    DateTime now = DateTime.Now;

                    string query = "SELECT COUNT(*) FROM tbl_calendar WHERE date = @Date AND time >= @Time";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Date", now.Date);
                    command.Parameters.AddWithValue("@Time", now.TimeOfDay);

                    int remainingBookings = (int)command.ExecuteScalar();

                    label9.Text = remainingBookings.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        void CalculateMonthExpense()
        {
            using (SqlConnection connection = new SqlConnection(DatabaseConnection.connectionString))
            {
                try
                {
                    connection.Open();

                    // Get the first day of the current month
                    DateTime firstDayOfMonth = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);

                    // Get the last day of the current month
                    DateTime lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(-1);

                    string query = "SELECT SUM(cost) FROM Income WHERE date_income >= @FirstDayOfMonth AND date_income <= @LastDayOfMonth";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@FirstDayOfMonth", firstDayOfMonth);
                    command.Parameters.AddWithValue("@LastDayOfMonth", lastDayOfMonth);

                    object result = command.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        decimal totalExpense = Convert.ToDecimal(result);

                        label12.Text = totalExpense.ToString("C"); // Format as currency
                    }
                    else
                    {
                        label12.Text = "$ 0";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        

        private void button11_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                AdminSession.isLoggedIn = false;

                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        
    }
}
