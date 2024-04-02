
namespace ServiceHistory
{
    partial class Form1
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.service = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceProvider = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Black;
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.button5);
            this.flowLayoutPanel1.Controls.Add(this.button6);
            this.flowLayoutPanel1.Controls.Add(this.button7);
            this.flowLayoutPanel1.Controls.Add(this.button8);
            this.flowLayoutPanel1.Controls.Add(this.button9);
            this.flowLayoutPanel1.Controls.Add(this.button10);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(241, 693);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.ImageKey = "(none)";
            this.button1.Location = new System.Drawing.Point(3, 140);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(238, 57);
            this.button1.TabIndex = 0;
            this.button1.Text = "Dashboard";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.service,
            this.vehicleNo,
            this.date,
            this.serviceProvider,
            this.status});
            this.dataGridView1.Location = new System.Drawing.Point(288, 190);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(805, 405);
            this.dataGridView1.TabIndex = 1;
            // 
            // id
            // 
            this.id.HeaderText = "Id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.Width = 125;
            // 
            // service
            // 
            this.service.HeaderText = "Service";
            this.service.MinimumWidth = 6;
            this.service.Name = "service";
            this.service.Width = 125;
            // 
            // vehicleNo
            // 
            this.vehicleNo.HeaderText = "Vehicle No";
            this.vehicleNo.MinimumWidth = 6;
            this.vehicleNo.Name = "vehicleNo";
            this.vehicleNo.Width = 125;
            // 
            // date
            // 
            this.date.HeaderText = "Date";
            this.date.MinimumWidth = 6;
            this.date.Name = "date";
            this.date.Width = 125;
            // 
            // serviceProvider
            // 
            this.serviceProvider.HeaderText = "Service Provider";
            this.serviceProvider.MinimumWidth = 6;
            this.serviceProvider.Name = "serviceProvider";
            this.serviceProvider.Width = 125;
            // 
            // status
            // 
            this.status.HeaderText = "Status";
            this.status.MinimumWidth = 6;
            this.status.Name = "status";
            this.status.Width = 125;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(288, 109);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 56);
            this.button2.TabIndex = 2;
            this.button2.Text = "Add Service";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(258, 613);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(898, 43);
            this.button3.TabIndex = 3;
            this.button3.Text = "Designed by ...";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(270, 20);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(263, 43);
            this.button4.TabIndex = 4;
            this.button4.Text = "Service History";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Black;
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(3, 203);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(238, 58);
            this.button5.TabIndex = 2;
            this.button5.Text = "Reservations";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Black;
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(3, 267);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(238, 59);
            this.button6.TabIndex = 3;
            this.button6.Text = "Vehicles";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(3, 332);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(238, 56);
            this.button7.TabIndex = 4;
            this.button7.Text = "Service History";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Black;
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Location = new System.Drawing.Point(3, 394);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(239, 56);
            this.button8.TabIndex = 5;
            this.button8.Text = "Payments";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Black;
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Location = new System.Drawing.Point(3, 456);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(239, 56);
            this.button9.TabIndex = 6;
            this.button9.Text = "Employees";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.Black;
            this.button10.ForeColor = System.Drawing.Color.White;
            this.button10.Location = new System.Drawing.Point(3, 518);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(238, 60);
            this.button10.TabIndex = 7;
            this.button10.Text = "Statics";
            this.button10.UseVisualStyleBackColor = false;
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.Black;
            this.button11.ForeColor = System.Drawing.Color.White;
            this.button11.Location = new System.Drawing.Point(1039, 20);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(100, 37);
            this.button11.TabIndex = 7;
            this.button11.Text = "Logout";
            this.button11.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(837, 137);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(256, 28);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = "  Search";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ServiceHistory.Properties.Resources.Screenshot_2024_04_02_151157;
            this.pictureBox2.Location = new System.Drawing.Point(782, 20);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(192, 43);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ServiceHistory.Properties.Resources.account_profile_user_icon__icon_search_engine_10;
            this.pictureBox1.InitialImage = global::ServiceHistory.Properties.Resources.avator;
            this.pictureBox1.Location = new System.Drawing.Point(1008, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::ServiceHistory.Properties.Resources.front_headlights_modern_sport_car_260nw_200718078;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(238, 131);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1168, 693);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Location = new System.Drawing.Point(2, 2);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn service;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceProvider;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.TextBox textBox1;
    }
}

