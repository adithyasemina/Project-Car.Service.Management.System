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
using System.Security.Cryptography;
using System.Xml.Linq;



namespace Car_Service_Management_System
{
    public partial class Vehicle_Details_Landing_Page : Form
    {
        public Vehicle_Details_Landing_Page()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            Add_Vehicle_Details vd = new Add_Vehicle_Details();
            vd.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Data will be Deleted.Confirm?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\prabh\source\repos\Vehicle_Details\Vehicle_Details\Vehicle_Details_Database1.mdf; Integrated Security = True");
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "Delete from Table where Table_id=" + rowid + "";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);
                Vehicle_Details_Landing_Page_Load(this, null);

            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Unsaved Data Will be Lost", "Are you sure?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void Vehicle_Details_Landing_Page_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;
            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\prabh\source\repos\Vehicle_Details\Vehicle_Details\Vehicle_Details_Database1.mdf; Integrated Security = True");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from Table";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);

            dataGridView2.DataSource = DS.Tables[0];
        }

        private void txtCID_TextChanged(object sender, EventArgs e)
        {
            if (txtCID.Text != "")
            {
                SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\prabh\source\repos\Vehicle_Details\Vehicle_Details\Vehicle_Details_Database1.mdf; Integrated Security = True");
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select * from Table where Table_id LIKE '" + txtCID.Text + "%'";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);
                dataGridView2.DataSource = DS.Tables[0];
            }
            else
            {
                SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\prabh\source\repos\Vehicle_Details\Vehicle_Details\Vehicle_Details_Database1.mdf; Integrated Security = True");
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select * from Table where Table_id LIKE '" + txtCID.Text + "%'";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);
                dataGridView2.DataSource = DS.Tables[0];
            }
        }


        int cid;
        Int64 rowid;

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                cid = int.Parse(dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            panel2.Visible = true;
            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\prabh\source\repos\Vehicle_Details\Vehicle_Details\Vehicle_Details_Database1.mdf; Integrated Security = True");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from Table where Table_id=" + cid + "";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);

            rowid = Int64.Parse(DS.Tables[0].Rows[0][0].ToString());
            txtCN.Text = DS.Tables[0].Rows[0][1].ToString();
            txtVN.Text = DS.Tables[0].Rows[0][2].ToString();
            txtVB.Text = DS.Tables[0].Rows[0][3].ToString();
            txtVNum.Text = DS.Tables[0].Rows[0][4].ToString();
            txtCT.Text = DS.Tables[0].Rows[0][5].ToString();
            txtCNum.Text = DS.Tables[0].Rows[0][6].ToString();
            txtFT.Text = DS.Tables[0].Rows[0][7].ToString();
            txtET.Text = DS.Tables[0].Rows[0][8].ToString();
            txtDate.Text = DS.Tables[0].Rows[0][8].ToString();
        }

        private void btNRef_Click(object sender, EventArgs e)
        {
            Vehicle_Details_Landing_Page_Load(this, null);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string Cname = txtCN.Text;
            string Vname = txtVN.Text;
            string Vbrand = txtVB.Text;
            string Vnumber = txtVNum.Text;
            Int64 Ctele = Int64.Parse(txtCT.Text);
            string Chassisnum = txtCNum.Text;
            String Ftype = txtFT.Text;
            String Etype = txtET.Text;
            String Date = txtDate.Text;

            if (MessageBox.Show("Data will be Updedated.Confirm?", "succses", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\prabh\source\repos\Vehicle_Details\Vehicle_Details\Vehicle_Details_Database1.mdf; Integrated Security = True");
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "Update Table set name='" + Cname + "' ,Vname='" + Vname + "' ,Vbrand=" + Vbrand + " ,Vnumber='" + Vnumber + "' ,Ctele=" + Ctele + ",Chassisnum='" + Chassisnum + "',Ftype='" + Ftype + "',Etype='" + Etype + "',Date='" + Date + "'  where customer_id=" + cid + "";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);
                Vehicle_Details_Landing_Page_Load(this, null);


            }

        }
    }
}