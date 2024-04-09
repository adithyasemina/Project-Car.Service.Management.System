using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Basic_Login_Page
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            // Used "DialogResult" to be able to retrive what button was clicked by user from the message box
            DialogResult result = MessageBox.Show("Are you sure you want to log out? ", "Confirm", MessageBoxButtons.YesNo);

            // Determine which condition when " Yes " button clicked
            if (result == DialogResult.Yes)
            {
                // Admin is logged out
                AdminSession.isLoggedIn = false;

                // Show Form1
                Application.OpenForms["Form1"].Show(); 

                // Close form2
                this.Close();
            }
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Exit application
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // Show Form1
            Application.OpenForms["Form1"].Show();

            // Close form2
            this.Close();
        }
    }
}
    

