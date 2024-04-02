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

namespace ServiceHistory
{
    public partial class Form2 : Form
    {
        SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\ASUS\SOURCE\REPOS\SERVICES\SERVICES\DATABASE1.MDF;Integrated Security=True");

        public Form2()
        {
            InitializeComponent();
        }

        /*private void button1_Click(object sender, EventArgs e)
        {
            string service = txtService.Text;
            string vehicleNo = txtVehicle.Text;
            string date = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string serviceProvider = txtSProvider.Text;
            String status = comboBox1.ValueMember.ToString();

            String query = $"INSERT INTO Services(service, vehicleNO, date, serviceProvider, status) Values ('{service}','{vehicleNo}','{date}',{serviceProvider},'{status}');";
            SqlCommand cmd = new SqlCommand(query, con1);

            try
            {
                con1.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successful data query");
                con1.Close(); 
            }
            catch (SqlException sqle)
            {
                MessageBox.Show(sqle.Message);
            }
        }*/
    }
}
