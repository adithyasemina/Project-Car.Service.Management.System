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
using System.Globalization;

namespace Car_Service_Management_System
{
    public partial class EventForm : Form
    {
        public EventForm()
        {
            InitializeComponent();
            // set the reference ID label to visible
            ReferenceId.Visible = true;
            // set the reference ID label to readonly
            ReferenceId.ReadOnly = true;
        }

        private int GetReferenceId()
        {
            int refId = 1; // default value
            using (SqlConnection conn = new SqlConnection(DatabaseConnection.connectionString))
            {
                conn.Open();
                string query = "SELECT MAX(refid) FROM tbl_calendar";
                SqlCommand cmd = new SqlCommand(query, conn);
                object result = cmd.ExecuteScalar();
                if (result != DBNull.Value && result != null)
                {
                    refId = (int)result + 1;
                }
            }
            return refId;
        }


        private void EventForm_Load(object sender, EventArgs e)
        {
            //calling static variable we declared 
            txdate.Text = UserControlDays.static_day + "-" + GetMonthName(Calender.static_month) + "-" + Calender.static_year; 
            // set the reference ID label to visible
            ReferenceId.Visible = true;
            // get the reference ID and display it
            int refId = GetReferenceId();
            ReferenceId.Text = refId.ToString();
            FILLDGV();
        }

        private void FILLDGV()
        {
            using (SqlConnection conn = new SqlConnection(DatabaseConnection.connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM tbl_calendar WHERE date = @date";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@date", txdate.Text);
                    SqlDataReader reader = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    dataGridView.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error");
                }
                conn.Close();
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txvehicle.Text))
            {
                MessageBox.Show("Please enter a vehicle number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                int refId = GetReferenceId();

                if (!DateTime.TryParseExact(txtime.Text, "HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime time))
                {
                    MessageBox.Show("Invalid time format. Please enter time in the format HH:mm.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    // Convert the time to a string in "hh:mm" format
                    string formattedTime = time.ToString("HH:mm");

                    using (SqlConnection conn = new SqlConnection(DatabaseConnection.connectionString))
                    {
                        try
                        {
                            conn.Open();
                            string query = "INSERT INTO tbl_calendar (date, vehicle, refid, time) VALUES (@date, @vehicle, @refid, @time)";
                            SqlCommand cmd = new SqlCommand(query, conn);
                            cmd.Parameters.AddWithValue("@date", txdate.Text);
                            cmd.Parameters.AddWithValue("@vehicle", txvehicle.Text);
                            cmd.Parameters.AddWithValue("@refid", refId);
                            cmd.Parameters.AddWithValue("@time", formattedTime);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Saved", "Alert");
                            FILLDGV();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message, "Error");
                        }
                    }
                }
            }

            
        }

        string GetMonthName(int monthNumber)
        {
            switch (monthNumber)
            {
                case 1:
                    return "Jan";
                case 2:
                    return "Feb";
                case 3:
                    return "Mar";
                case 4:
                    return "Apr";
                case 5:
                    return "May";
                case 6:
                    return "Jun";
                case 7:
                    return "Jul";
                case 8:
                    return "Aug";
                case 9:
                    return "Sep";
                case 10:
                    return "Oct";
                case 11:
                    return "Nov";
                case 12:
                    return "Dec";
                default:
                    throw new ArgumentException("Invalid month number. Month number must be between 1 and 12.");
            }
        }
    }
}