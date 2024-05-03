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
        string todayDate = DateTime.Now.ToString("dd-MMM-yy");
        //string todayDate = "01-Mar-24";
        //DateTime todayDate = DateTime.Now;


        int numberOfBookings = 0;


        public Statistics()
        {
            InitializeComponent();
        }

        private void Statistics_Load(object sender, EventArgs e)
        {
            TodayOrders();
            totalBookingsForMonth();
        }

        void TodayOrders()
        {
            //using (SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\ASUS\Desktop\Final connections\Car Service Management System\Database\CarManagementDatabase.mdf"";Integrated Security=True;Connect Timeout=30"))
            using (SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\C# Practice\Car Service Management System\Car Service Management System\Database\CarManagementDatabase.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                string query = "SELECT COUNT(*) FROM tbl_calendar WHERE [date] = @TodayDate";
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

            // Construct the SQL query to count the bookings for the current month
            string query = $"SELECT COUNT(*) FROM tbl_calendar WHERE MONTH(date) = {currentMonth} AND YEAR(date) = {currentYear}";

            //using (SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\ASUS\Desktop\Final connections\Car Service Management System\Database\CarManagementDatabase.mdf"";Integrated Security=True;Connect Timeout=30"))
            using (SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\C# Practice\Car Service Management System\Car Service Management System\Database\CarManagementDatabase.mdf;Integrated Security=True;Connect Timeout=30"))
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
