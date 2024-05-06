using System.Drawing;
using System.Windows.Forms;

namespace Car_Service_Management_System
{
    partial class Inventory_Data_Landaing_Page
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventory_Data_Landaing_Page));
            this.btnaddproduct = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.TextBox();
            this.txtmaintaincost = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.txtquantity = new System.Windows.Forms.TextBox();
            this.txtproductname = new System.Windows.Forms.TextBox();
            this.txtproductid = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnaddproduct
            // 
            resources.ApplyResources(this.btnaddproduct, "btnaddproduct");
            this.btnaddproduct.BackColor = System.Drawing.Color.Silver;
            this.btnaddproduct.Name = "btnaddproduct";
            this.btnaddproduct.UseVisualStyleBackColor = false;
            this.btnaddproduct.Click += new System.EventHandler(this.btnaddproduct_Click);
            // 
            // textBox1
            // 
            this.textBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnDelete
            // 
            resources.ApplyResources(this.btnDelete, "btnDelete");
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(75)))), ((int)(((byte)(76)))));
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(65)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.WindowFrame;
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // panel3
            // 
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(65)))));
            this.panel3.Controls.Add(this.dateTimePicker1);
            this.panel3.Controls.Add(this.txtmaintaincost);
            this.panel3.Controls.Add(this.btnUpdate);
            this.panel3.Controls.Add(this.txtprice);
            this.panel3.Controls.Add(this.btnDelete);
            this.panel3.Controls.Add(this.txtquantity);
            this.panel3.Controls.Add(this.txtproductname);
            this.panel3.Controls.Add(this.txtproductid);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Name = "panel3";
            // 
            // dateTimePicker1
            // 
            resources.ApplyResources(this.dateTimePicker1, "dateTimePicker1");
            this.dateTimePicker1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dateTimePicker1.Name = "dateTimePicker1";
            // 
            // txtmaintaincost
            // 
            resources.ApplyResources(this.txtmaintaincost, "txtmaintaincost");
            this.txtmaintaincost.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtmaintaincost.Name = "txtmaintaincost";
            // 
            // btnUpdate
            // 
            resources.ApplyResources(this.btnUpdate, "btnUpdate");
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(55)))), ((int)(((byte)(63)))));
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(220)))), ((int)(((byte)(147)))));
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtprice
            // 
            resources.ApplyResources(this.txtprice, "txtprice");
            this.txtprice.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtprice.Name = "txtprice";
            // 
            // txtquantity
            // 
            resources.ApplyResources(this.txtquantity, "txtquantity");
            this.txtquantity.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtquantity.Name = "txtquantity";
            // 
            // txtproductname
            // 
            resources.ApplyResources(this.txtproductname, "txtproductname");
            this.txtproductname.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtproductname.Name = "txtproductname";
            // 
            // txtproductid
            // 
            resources.ApplyResources(this.txtproductid, "txtproductid");
            this.txtproductid.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtproductid.Name = "txtproductid";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Name = "label8";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Name = "label6";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Name = "label5";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Name = "label2";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Name = "label9";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Name = "label7";
            // 
            // Inventory_Data_Landaing_Page
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnaddproduct);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Inventory_Data_Landaing_Page";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Inventory_Data_Landaing_Page_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnaddproduct;
        private TextBox textBox1;
        private Button btnDelete;
        private DataGridView dataGridView1;
        private Panel panel3;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label8;
        private Label label6;
        private Label label5;
        private TextBox dateTimePicker1;
        private TextBox txtmaintaincost;
        private TextBox txtprice;
        private TextBox txtquantity;
        private TextBox txtproductname;
        private TextBox txtproductid;
        private Button btnUpdate;
        private Label label9;
        private Label label7;
    }
}
