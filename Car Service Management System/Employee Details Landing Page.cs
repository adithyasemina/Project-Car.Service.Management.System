﻿using System;
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
    public partial class Employee_Details_Landing_Page : Form
    {
        public Employee_Details_Landing_Page()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employee EmployeeInfo = new Employee();

            EmployeeInfo.Show();



        }
    }
}
