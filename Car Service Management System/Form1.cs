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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public void loadForm(object Form)
        {
            if (this.mainPanel.Controls.Count > 0)
                this.mainPanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(f);
            this.mainPanel.Tag = f;
            f.Show();
        }

        /* private void btnDashboard_Click(object sender, EventArgs e)
         {
             loadForm(new Dashboard());
         }*/


        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            loadForm(new Customer_Details_Landing_Page());
        }

        private void btnVehicles_Click(object sender, EventArgs e)
        {
            loadForm(new Vehicle_Details_Landing_Page());
        }

        private void btnService_Click(object sender, EventArgs e)
        {
            loadForm(new ServiceHistory());
        }


        private void btnInventory_Click(object sender, EventArgs e)
        {
            loadForm(new Inventory_Data_Landaing_Page());
        }

        private void btnExpense_Click(object sender, EventArgs e)
        {
            loadForm(new Expense_Details());
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            loadForm(new Calender());
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            loadForm(new Employee());

        }

        private void btnStatics_Click(object sender, EventArgs e)
        {
            loadForm(new Statistics());
        }

    }
}
