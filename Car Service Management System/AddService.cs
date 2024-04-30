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
    public partial class AddService : Form
    {
        SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Asus\source\project\Car Service Management System\Car Service Management System\serviceHistory.mdf;Integrated Security=True");

        public AddService()
        {
            InitializeComponent();
        }


        private void lblId_Click(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            String service = txtService.Text;
            String vehicleNo = txtVehicleNo.Text;
            String brand = txtBrand.Text;
            String model = txtModel.Text;
            DateTime date = DateTime.Today;
            String serviceProvider = txtSProvider.Text;


            string query = $"INSERT INTO serviceHistory(id, service, vehicleNo, brand, model, date, serviceProvider) VALUES ({id}, '{service}', '{vehicleNo}', '{brand}', '{model}', {date}, '{serviceProvider}');";

            SqlCommand cmd = new SqlCommand(query, con1);
            try
            {
                con1.Open();
                cmd.ExecuteNonQuery();
                con1.Close();
                MessageBox.Show("Successfully Inserted Value");

            }

            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(txtId.Text);

            string query4 = $"DELETE service WHERE ID = (id)";

            SqlCommand cmd3 = new SqlCommand(query4, con1);
            try
            {
                con1.Open();
                cmd3.ExecuteNonQuery();
                con1.Close();
                MessageBox.Show("Successfully deleted");

            }

            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            String service = txtService.Text;
            String vehicleNo = txtVehicleNo.Text;
            String brand = txtBrand.Text;
            String model = txtModel.Text;
            DateTime date = DateTime.Today;
            String serviceProvider = txtSProvider.Text;

            string query = $"update serviceHistory SET service ='{service}', vehicleNo ='{vehicleNo}', brand='{brand}', mode;='{model}', date={date}, serviceProvider='{serviceProvider}' WHERE id={id}";

            SqlCommand cmd = new SqlCommand(query, con1);
            try
            {
                con1.Open();
                cmd.ExecuteNonQuery();
                con1.Close();
                MessageBox.Show("Successfully updated Value");

            }

            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddService_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}