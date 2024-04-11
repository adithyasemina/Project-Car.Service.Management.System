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
    public partial class Service_History_Landing_Page : Form
    {
        public Service_History_Landing_Page()
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

        private void btnVehicles_Click(object sender, EventArgs e)
        {
            // loadForm(new Vehicles());
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        /*        private void btnReservations_Click(object sender, EventArgs e)
                {
                    loadForm(new Reservations());
                }

                private void btnServices_Click(object sender, EventArgs e)
                {
                    loadForm(new ServiceHistory());
                }

                private void btnEmployees_Click(object sender, EventArgs e)
                {
                    loadForm(new Employees());
                }

                private void btnStatics_Click(object sender, EventArgs e)
                {
                    loadForm(new Statics());
                }*/

        private void btnPayments_Click(object sender, EventArgs e)
        {
            // loadForm(new Payments());
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            // loadForm(new Inventory());
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            // loadForm(new Customers());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

        }

        private void btnService_Click(object sender, EventArgs e)
        {
            loadForm(new ServiceHistory());
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {

        }
    }
}
