using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Service_Management_System
{
    public partial class UserControlDays : UserControl
    {
        public UserControlDays()
        {
            InitializeComponent();
        }

        //creating another static variable for day
        public static string static_day;

        private void lbdays_Click(object sender, EventArgs e)
        {

        }

        private void UserControlDays_Load(object sender, EventArgs e)
        {

        }

        public void days(int numday)
        {
            lbdays.Text = numday + "";
        }

        private void UserControlDays_Click(object sender, EventArgs e)
        {
            static_day = lbdays.Text;
            EventForm eventForm = new EventForm();
            eventForm.Show();
        }
    }
}
