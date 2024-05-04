
namespace Car_Service_Management_System
{
    partial class Expense_Details
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Categorytxt = new System.Windows.Forms.ComboBox();
            this.Itemtxt = new System.Windows.Forms.TextBox();
            this.Costtxt = new System.Windows.Forms.TextBox();
            this.Descriptiontxt = new System.Windows.Forms.TextBox();
            this.Datetxt = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Addbtn = new System.Windows.Forms.Button();
            this.Updatebtn = new System.Windows.Forms.Button();
            this.Deletebtn = new System.Windows.Forms.Button();
            this.Clearbtn = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtexpenseId = new System.Windows.Forms.TextBox();
            this.lblexpenseId = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(65)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(47, 140);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(862, 363);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // Categorytxt
            // 
            this.Categorytxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Categorytxt.FormattingEnabled = true;
            this.Categorytxt.Location = new System.Drawing.Point(612, 42);
            this.Categorytxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Categorytxt.Name = "Categorytxt";
            this.Categorytxt.Size = new System.Drawing.Size(210, 28);
            this.Categorytxt.TabIndex = 0;
            // 
            // Itemtxt
            // 
            this.Itemtxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Itemtxt.Location = new System.Drawing.Point(185, 88);
            this.Itemtxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Itemtxt.Name = "Itemtxt";
            this.Itemtxt.Size = new System.Drawing.Size(210, 27);
            this.Itemtxt.TabIndex = 4;
            // 
            // Costtxt
            // 
            this.Costtxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Costtxt.Location = new System.Drawing.Point(185, 133);
            this.Costtxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Costtxt.Name = "Costtxt";
            this.Costtxt.Size = new System.Drawing.Size(210, 27);
            this.Costtxt.TabIndex = 5;
            // 
            // Descriptiontxt
            // 
            this.Descriptiontxt.Location = new System.Drawing.Point(612, 136);
            this.Descriptiontxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Descriptiontxt.Multiline = true;
            this.Descriptiontxt.Name = "Descriptiontxt";
            this.Descriptiontxt.Size = new System.Drawing.Size(210, 88);
            this.Descriptiontxt.TabIndex = 6;
            // 
            // Datetxt
            // 
            this.Datetxt.Location = new System.Drawing.Point(612, 93);
            this.Datetxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Datetxt.Name = "Datetxt";
            this.Datetxt.Size = new System.Drawing.Size(210, 22);
            this.Datetxt.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(416, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "CATEGORY";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(19, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "ITEM ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(19, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "COST";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(416, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "DISCRIPTION";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(416, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "DATE ";
            // 
            // Addbtn
            // 
            this.Addbtn.BackColor = System.Drawing.Color.Silver;
            this.Addbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Addbtn.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold);
            this.Addbtn.Location = new System.Drawing.Point(746, 89);
            this.Addbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(163, 29);
            this.Addbtn.TabIndex = 13;
            this.Addbtn.Text = "ADD Expense";
            this.Addbtn.UseVisualStyleBackColor = false;
            this.Addbtn.Click += new System.EventHandler(this.button11_Click);
            // 
            // Updatebtn
            // 
            this.Updatebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(55)))), ((int)(((byte)(63)))));
            this.Updatebtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Updatebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.Updatebtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(220)))), ((int)(((byte)(147)))));
            this.Updatebtn.Location = new System.Drawing.Point(32, 252);
            this.Updatebtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Updatebtn.Name = "Updatebtn";
            this.Updatebtn.Size = new System.Drawing.Size(111, 37);
            this.Updatebtn.TabIndex = 14;
            this.Updatebtn.Text = "Update";
            this.Updatebtn.UseVisualStyleBackColor = false;
            this.Updatebtn.Click += new System.EventHandler(this.button12_Click);
            // 
            // Deletebtn
            // 
            this.Deletebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.Deletebtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Deletebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.Deletebtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(75)))), ((int)(((byte)(76)))));
            this.Deletebtn.Location = new System.Drawing.Point(711, 252);
            this.Deletebtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.Size = new System.Drawing.Size(111, 37);
            this.Deletebtn.TabIndex = 15;
            this.Deletebtn.Text = "Delete";
            this.Deletebtn.UseVisualStyleBackColor = false;
            this.Deletebtn.Click += new System.EventHandler(this.button13_Click);
            // 
            // Clearbtn
            // 
            this.Clearbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(72)))));
            this.Clearbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Clearbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.Clearbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(143)))), ((int)(((byte)(254)))));
            this.Clearbtn.Location = new System.Drawing.Point(201, 252);
            this.Clearbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Clearbtn.Name = "Clearbtn";
            this.Clearbtn.Size = new System.Drawing.Size(111, 37);
            this.Clearbtn.TabIndex = 16;
            this.Clearbtn.Text = "Clear";
            this.Clearbtn.UseVisualStyleBackColor = false;
            this.Clearbtn.Click += new System.EventHandler(this.button14_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(65)))));
            this.panel4.Controls.Add(this.txtexpenseId);
            this.panel4.Controls.Add(this.lblexpenseId);
            this.panel4.Controls.Add(this.Clearbtn);
            this.panel4.Controls.Add(this.Deletebtn);
            this.panel4.Controls.Add(this.Updatebtn);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.Datetxt);
            this.panel4.Controls.Add(this.Descriptiontxt);
            this.panel4.Controls.Add(this.Costtxt);
            this.panel4.Controls.Add(this.Itemtxt);
            this.panel4.Controls.Add(this.Categorytxt);
            this.panel4.Location = new System.Drawing.Point(47, 532);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(862, 347);
            this.panel4.TabIndex = 3;
            // 
            // txtexpenseId
            // 
            this.txtexpenseId.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtexpenseId.Location = new System.Drawing.Point(185, 43);
            this.txtexpenseId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtexpenseId.Name = "txtexpenseId";
            this.txtexpenseId.Size = new System.Drawing.Size(210, 27);
            this.txtexpenseId.TabIndex = 19;
            // 
            // lblexpenseId
            // 
            this.lblexpenseId.AutoSize = true;
            this.lblexpenseId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblexpenseId.ForeColor = System.Drawing.Color.White;
            this.lblexpenseId.Location = new System.Drawing.Point(19, 45);
            this.lblexpenseId.Name = "lblexpenseId";
            this.lblexpenseId.Size = new System.Drawing.Size(140, 25);
            this.lblexpenseId.TabIndex = 18;
            this.lblexpenseId.Text = "EXPENSE ID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Candara", 19.8F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label9.Location = new System.Drawing.Point(358, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(229, 40);
            this.label9.TabIndex = 65;
            this.label9.Text = "EXPENSE DATA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(39, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 28);
            this.label1.TabIndex = 69;
            this.label1.Text = "Expenses ID";
            // 
            // textBox1
            // 
            this.textBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox1.Location = new System.Drawing.Point(212, 90);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(240, 22);
            this.textBox1.TabIndex = 68;
            // 
            // Expense_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(953, 820);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.Addbtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Expense_Details";
            this.Text = "Expense_Details";
            this.Load += new System.EventHandler(this.Expense_Details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox Categorytxt;
        private System.Windows.Forms.TextBox Itemtxt;
        private System.Windows.Forms.TextBox Costtxt;
        private System.Windows.Forms.TextBox Descriptiontxt;
        private System.Windows.Forms.DateTimePicker Datetxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Addbtn;
        private System.Windows.Forms.Button Updatebtn;
        private System.Windows.Forms.Button Deletebtn;
        private System.Windows.Forms.Button Clearbtn;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtexpenseId;
        private System.Windows.Forms.Label lblexpenseId;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}