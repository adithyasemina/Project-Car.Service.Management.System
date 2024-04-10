using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calendar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            displaydays();
        }
        private void displaydays()
        {
            DateTime now = DateTime.Now;

            // Getting first day of the month
            DateTime startofthemonth = new DateTime(now.Year,now.Month,1);

            // Getting the count of the days of the month
            int days=DateTime.DaysInMonth(now.Year,now.Month);

            //converting the start of the month in to the integer 
            int daysoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d"))+1;

            //Creating blank user control 
            for (int i = 1; i < daysoftheweek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                daycontainer.Controls.Add(ucblank);
            }
            //Creating user controll for days

        }
    }
}
