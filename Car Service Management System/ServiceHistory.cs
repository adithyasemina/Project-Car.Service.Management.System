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

namespace Car_Service_Management_System
{

    public partial class ServiceHistory : Form
    {
        readonly SqlConnection con = new SqlConnection(DatabaseConnection.connectionString);

        public ServiceHistory()
        {
            InitializeComponent();
        }

        private void ServiceHistory_Load(object sender, EventArgs e)
        {
            fillServiceTable();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddService addService = new AddService();
            addService.Show();
        }

        void fillServiceTable()
        {
            SqlCommand cnn = new SqlCommand("SELECT * FROM [serviceHistory]", con);
            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();

            da.Fill(table);

            // Brian: Changed from dataGridView1 to dataGridView2 because i didn't see any changes when kept in dataGridView1
            dataGridView1.DataSource = table;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            if (textBox1.Text != "")
            {
                SqlConnection con = new SqlConnection(DatabaseConnection.connectionString);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "SELECT * FROM serviceHistory WHERE serviceId LIKE '" + textBox1.Text + "%'";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);
                dataGridView1.DataSource = DS.Tables[0];
            }
            else
            {
                fillServiceTable();
            }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            fillServiceTable();
        }
    }
}
