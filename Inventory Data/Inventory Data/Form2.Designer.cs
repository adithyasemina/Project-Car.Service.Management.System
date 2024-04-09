namespace Inventory_Data
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            button3 = new Button();
            button2 = new Button();
            btnsave = new Button();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label7 = new Label();
            dateTimePicker1 = new DateTimePicker();
            txtmaintaincost = new TextBox();
            txtprice = new TextBox();
            txtquantity = new TextBox();
            txtproductname = new TextBox();
            txtproductid = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button3.BackColor = Color.WhiteSmoke;
            button3.Font = new Font("Britannic Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(633, 372);
            button3.Name = "button3";
            button3.Size = new Size(108, 32);
            button3.TabIndex = 33;
            button3.Text = "EXIT";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.BackColor = Color.Silver;
            button2.Font = new Font("Britannic Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(633, 316);
            button2.Name = "button2";
            button2.Size = new Size(108, 32);
            button2.TabIndex = 32;
            button2.Text = "REFRESH";
            button2.UseVisualStyleBackColor = false;
            // 
            // btnsave
            // 
            btnsave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnsave.BackColor = Color.DimGray;
            btnsave.Font = new Font("Britannic Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnsave.Location = new Point(633, 265);
            btnsave.Name = "btnsave";
            btnsave.Size = new Size(108, 35);
            btnsave.TabIndex = 31;
            btnsave.Text = "SAVE";
            btnsave.UseVisualStyleBackColor = false;
            btnsave.Click += btnsave_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(614, 105);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(141, 113);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 30;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.GrayText;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label7);
            panel1.ForeColor = Color.Black;
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(799, 76);
            panel1.TabIndex = 29;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(189, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(87, 73);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Britannic Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(318, 28);
            label7.Name = "label7";
            label7.Size = new Size(190, 21);
            label7.TabIndex = 0;
            label7.Text = "ADD INVENTORY DATA";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dateTimePicker1.Location = new Point(306, 394);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 28;
            // 
            // txtmaintaincost
            // 
            txtmaintaincost.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtmaintaincost.Location = new Point(306, 340);
            txtmaintaincost.Name = "txtmaintaincost";
            txtmaintaincost.Size = new Size(200, 23);
            txtmaintaincost.TabIndex = 27;
            // 
            // txtprice
            // 
            txtprice.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtprice.Location = new Point(306, 292);
            txtprice.Name = "txtprice";
            txtprice.Size = new Size(200, 23);
            txtprice.TabIndex = 26;
            // 
            // txtquantity
            // 
            txtquantity.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtquantity.Location = new Point(306, 238);
            txtquantity.Name = "txtquantity";
            txtquantity.Size = new Size(200, 23);
            txtquantity.TabIndex = 25;
            // 
            // txtproductname
            // 
            txtproductname.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtproductname.Location = new Point(306, 185);
            txtproductname.Name = "txtproductname";
            txtproductname.Size = new Size(200, 23);
            txtproductname.TabIndex = 24;
            // 
            // txtproductid
            // 
            txtproductid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtproductid.Location = new Point(306, 136);
            txtproductid.Name = "txtproductid";
            txtproductid.Size = new Size(200, 23);
            txtproductid.TabIndex = 23;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(136, 400);
            label6.Name = "label6";
            label6.Size = new Size(45, 17);
            label6.TabIndex = 22;
            label6.Text = "DATE:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(136, 346);
            label5.Name = "label5";
            label5.Size = new Size(114, 17);
            label5.TabIndex = 21;
            label5.Text = "MAINTAIN COST:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(136, 293);
            label4.Name = "label4";
            label4.Size = new Size(47, 17);
            label4.TabIndex = 20;
            label4.Text = "PRICE:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(136, 244);
            label3.Name = "label3";
            label3.Size = new Size(78, 17);
            label3.TabIndex = 19;
            label3.Text = "QUANTITY:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(133, 191);
            label2.Name = "label2";
            label2.Size = new Size(115, 17);
            label2.TabIndex = 18;
            label2.Text = "PRODUCT NAME:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(133, 136);
            label1.Name = "label1";
            label1.Size = new Size(91, 17);
            label1.TabIndex = 17;
            label1.Text = "PRODUCT ID:";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 489);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(btnsave);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            Controls.Add(dateTimePicker1);
            Controls.Add(txtmaintaincost);
            Controls.Add(txtprice);
            Controls.Add(txtquantity);
            Controls.Add(txtproductname);
            Controls.Add(txtproductid);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button3;
        private Button button2;
        private Button btnsave;
        private PictureBox pictureBox2;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label7;
        private DateTimePicker dateTimePicker1;
        private TextBox txtmaintaincost;
        private TextBox txtprice;
        private TextBox txtquantity;
        private TextBox txtproductname;
        private TextBox txtproductid;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}