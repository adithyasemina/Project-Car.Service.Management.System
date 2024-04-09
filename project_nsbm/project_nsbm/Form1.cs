using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace project_nsbm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnaddcustomr_Click(object sender, EventArgs e)
        {
            ADD_Customer ad = new ADD_Customer();
            ad.Show();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Data will be Deleted.Confirm?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {

                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\pc\source\repos\project_nsbm\project_nsbm\AddcustomerDatabase1.mdf;Integrated Security=True");
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "Delete from Customer where customer_id=" + rowid + "";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);
                Form1_Load(this, null);

            }
           }

        private void butncancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Unsaved Data Will be Lost", "Are you sure?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel3.Visible = false;
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\pc\source\repos\project_nsbm\project_nsbm\AddcustomerDatabase1.mdf;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from customer";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);

            dataGridView1.DataSource = DS.Tables[0];
        }

        private void txtcid_TextChanged(object sender, EventArgs e)
        {
            if (txtcid.Text != "")
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\pc\source\repos\project_nsbm\project_nsbm\AddcustomerDatabase1.mdf;Integrated Security=True");
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select * from Customer where customer_id LIKE '" + txtcid.Text + "%'";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);
                dataGridView1.DataSource = DS.Tables[0];
            }
            else
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\pc\source\repos\project_nsbm\project_nsbm\AddcustomerDatabase1.mdf;Integrated Security=True");
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select * from customer";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

                dataGridView1.DataSource = DS.Tables[0];
            }
        }
        int cid;
        Int64 rowid;

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                cid = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            panel3.Visible = true;
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\pc\source\repos\project_nsbm\project_nsbm\AddcustomerDatabase1.mdf;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from customer where customer_id=" + cid + "";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            

            rowid = Int64.Parse(DS.Tables[0].Rows[0][0].ToString());
            txtcname.Text = DS.Tables[0].Rows[0][1].ToString();
            txtadrs.Text = DS.Tables[0].Rows[0][2].ToString();
            txtcnno.Text = DS.Tables[0].Rows[0][3].ToString();
            txtmail.Text = DS.Tables[0].Rows[0][4].ToString();
            txtnicno.Text = DS.Tables[0].Rows[0][5].ToString();
            txtveno.Text = DS.Tables[0].Rows[0][6].ToString();
            txtdate.Text = DS.Tables[0].Rows[0][7].ToString();
        }

        private void btrefresh_Click(object sender, EventArgs e)
        {
            Form1_Load(this, null);
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            
            string cname = txtcname.Text;
            string adress = txtadrs.Text;
            Int64 contactno = Int64.Parse(txtcnno.Text);
            string email = txtmail.Text;
            Int64 nic = Int64.Parse(txtnicno.Text);
            string vehicalno = txtveno.Text;
            String date = txtdate.Text;

            if (MessageBox.Show("Data will be Updedated.Confirm?", "succses", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\pc\source\repos\project_nsbm\project_nsbm\AddcustomerDatabase1.mdf;Integrated Security=True");
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "Update Customer set name='" + cname + "' ,Adress='" + adress + "' ,contact_no=" + contactno + " ,email='" + email + "' ,nicno=" + nic + ",vehicalno='" + vehicalno + "',date='" + date + "' where customer_id=" + cid + "";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);
                Form1_Load(this, null);

            }
        }
    }
}

