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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }


        public void loadForm(object Form)
        {
            if (this.panelLoad.Controls.Count > 0)
                this.panelLoad.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panelLoad.Controls.Add(f);
            this.panelLoad.Tag = f;
            f.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)  // Running
        {
            loadForm(new ServiceHistory());
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)  // Error
        {
            loadForm(new Employee());
        }

        private void button8_Click(object sender, EventArgs e)    
        {
            loadForm(new AddService());
        }

        private void button3_Click(object sender, EventArgs e) 
        {
            loadForm(new Calender());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            loadForm(new Form1());
        }
    }

}