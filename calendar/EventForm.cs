using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace calendar
{
    public partial class EventForm : Form
    {
        public EventForm()
        {
            InitializeComponent();
        }

        private void EventForm_Load(object sender, EventArgs e)
        {
            //calling static variable we declared 
            txdate.Text =Form1.static_month+"/"+ UserControlDays.static_day + "/" + Form1.static_year;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            //Creating a connectionstring
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\calendar.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into tbl_calendar values('"+txdate.Text+"','"+txvehicle.Text+"')",conn);

            cmd.ExecuteNonQuery();
            MessageBox.Show("saved","Alert");
            cmd.Dispose();
            conn.Close();
        }
    }
}
