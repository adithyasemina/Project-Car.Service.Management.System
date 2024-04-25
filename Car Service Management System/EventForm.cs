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
            using (SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\C# Practice\Group projects individually\Venuraka\database\Venuraka.mdf;Integrated Security=True;Connect Timeout=30"))
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
            txdate.Text = Calender.static_month + "/" + UserControlDays.static_day + "/" + Calender.static_year;
            // set the reference ID label to visible
            ReferenceId.Visible = true;
            // get the reference ID and display it
            int refId = GetReferenceId();
            ReferenceId.Text = refId.ToString();
            FILLDGV();
        }

        private void FILLDGV()
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\C# Practice\Group projects individually\Venuraka\database\Venuraka.mdf;Integrated Security=True;Connect Timeout=30"))
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
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txvehicle.Text))
            {
                MessageBox.Show("Please enter a vehicle number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int refId = GetReferenceId();

            using (SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\C# Practice\Group projects individually\Venuraka\database\Venuraka.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO tbl_calendar (date, vehicle, refid, time) VALUES (@date, @vehicle, @refid, @time)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@date", txdate.Text);
                    cmd.Parameters.AddWithValue("@vehicle", txvehicle.Text);
                    cmd.Parameters.AddWithValue("@refid", refId);
                    cmd.Parameters.AddWithValue("@time", txtime.Text);
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