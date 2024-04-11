using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Service_Management_System
{
    public partial class Calender : Form
    {
        int month, year;

        public Calender()
        {
            InitializeComponent();
        }

        private void Calender_Load(object sender, EventArgs e)
        {
            displaydays();
        }
        private void displaydays()
        {
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;
            string monthname = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(month);
            LBDATE.Text = monthname + "" + year;

            // Getting first day of the month
            DateTime startofthemonth = new DateTime(year, month, 1);

            // Getting the count of the days of the month
            int days = DateTime.DaysInMonth(year, month);

            //converting the start of the month in to the integer 
            int daysoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d"));

            //Creating blank user control 
            for (int i = 1; i < daysoftheweek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                daycontainer.Controls.Add(ucblank);
            }
            //Creating user controll for days
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);
            }
        }

        private void btnprevious_Click(object sender, EventArgs e)
        {
            //clearing container
            daycontainer.Controls.Clear();

            //decrementing month to go to previous month
            month--;

            string monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            LBDATE.Text = monthname + "" + year;


            // Getting first day of the month
            DateTime startofthemonth = new DateTime(year, month, 1);

            // Getting the count of the days of the month
            int days = DateTime.DaysInMonth(year, month);

            //converting the start of the month in to the integer 
            int daysoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d"));

            //Creating blank user control 
            for (int i = 1; i < daysoftheweek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                daycontainer.Controls.Add(ucblank);
            }
            //Creating user controll for days
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);
            }
        }

        private void LBDATE_Click(object sender, EventArgs e)
        {

        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            //clearing container
            daycontainer.Controls.Clear();

            //Incrementing month to go to next month
            month++;

            string monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            LBDATE.Text = monthname + "" + year;


            // Getting first day of the month
            DateTime startofthemonth = new DateTime(year, month, 1);

            // Getting the count of the days of the month
            int days = DateTime.DaysInMonth(year, month);

            //converting the start of the month in to the integer 
            int daysOfWeek = (int)startofthemonth.DayOfWeek;

            // Adjusting days of the week to start from Monday as 1
            daysOfWeek = (daysOfWeek == 0) ? 7 : daysOfWeek;

            // Creating blank user controls for days before the first day of the month
            for (int i = 1; i < daysOfWeek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                daycontainer.Controls.Add(ucblank);
            }
            //Creating user controll for days
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);
            }
        }
    }
}