
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
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
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.lblexpenseId = new System.Windows.Forms.Label();
            this.txtexpenseId = new System.Windows.Forms.TextBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(300, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Expenses Details";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Location = new System.Drawing.Point(9, 58);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(589, 252);
            this.panel3.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Expenses List";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 42);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(566, 190);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // Categorytxt
            // 
            this.Categorytxt.FormattingEnabled = true;
            this.Categorytxt.Location = new System.Drawing.Point(352, 18);
            this.Categorytxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Categorytxt.Name = "Categorytxt";
            this.Categorytxt.Size = new System.Drawing.Size(141, 21);
            this.Categorytxt.TabIndex = 0;
            // 
            // Itemtxt
            // 
            this.Itemtxt.Location = new System.Drawing.Point(85, 81);
            this.Itemtxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Itemtxt.Name = "Itemtxt";
            this.Itemtxt.Size = new System.Drawing.Size(141, 20);
            this.Itemtxt.TabIndex = 4;
            // 
            // Costtxt
            // 
            this.Costtxt.Location = new System.Drawing.Point(85, 132);
            this.Costtxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Costtxt.Name = "Costtxt";
            this.Costtxt.Size = new System.Drawing.Size(141, 20);
            this.Costtxt.TabIndex = 5;
            // 
            // Descriptiontxt
            // 
            this.Descriptiontxt.Location = new System.Drawing.Point(352, 56);
            this.Descriptiontxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Descriptiontxt.Multiline = true;
            this.Descriptiontxt.Name = "Descriptiontxt";
            this.Descriptiontxt.Size = new System.Drawing.Size(223, 72);
            this.Descriptiontxt.TabIndex = 6;
            // 
            // Datetxt
            // 
            this.Datetxt.Location = new System.Drawing.Point(352, 149);
            this.Datetxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Datetxt.Name = "Datetxt";
            this.Datetxt.Size = new System.Drawing.Size(151, 20);
            this.Datetxt.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(275, 18);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Category:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 81);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Item:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 132);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Cost:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(266, 59);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Description:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(302, 152);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Date:";
            // 
            // Addbtn
            // 
            this.Addbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Addbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addbtn.Location = new System.Drawing.Point(19, 173);
            this.Addbtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(83, 30);
            this.Addbtn.TabIndex = 13;
            this.Addbtn.Text = "Add";
            this.Addbtn.UseVisualStyleBackColor = false;
            this.Addbtn.Click += new System.EventHandler(this.button11_Click);
            // 
            // Updatebtn
            // 
            this.Updatebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Updatebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Updatebtn.Location = new System.Drawing.Point(156, 173);
            this.Updatebtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Updatebtn.Name = "Updatebtn";
            this.Updatebtn.Size = new System.Drawing.Size(83, 30);
            this.Updatebtn.TabIndex = 14;
            this.Updatebtn.Text = "Update";
            this.Updatebtn.UseVisualStyleBackColor = false;
            this.Updatebtn.Click += new System.EventHandler(this.button12_Click);
            // 
            // Deletebtn
            // 
            this.Deletebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Deletebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deletebtn.Location = new System.Drawing.Point(334, 173);
            this.Deletebtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.Size = new System.Drawing.Size(83, 30);
            this.Deletebtn.TabIndex = 15;
            this.Deletebtn.Text = "Delete";
            this.Deletebtn.UseVisualStyleBackColor = false;
            this.Deletebtn.Click += new System.EventHandler(this.button13_Click);
            // 
            // Clearbtn
            // 
            this.Clearbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Clearbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clearbtn.Location = new System.Drawing.Point(476, 173);
            this.Clearbtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Clearbtn.Name = "Clearbtn";
            this.Clearbtn.Size = new System.Drawing.Size(83, 30);
            this.Clearbtn.TabIndex = 16;
            this.Clearbtn.Text = "Clear";
            this.Clearbtn.UseVisualStyleBackColor = false;
            this.Clearbtn.Click += new System.EventHandler(this.button14_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel4.Controls.Add(this.txtexpenseId);
            this.panel4.Controls.Add(this.lblexpenseId);
            this.panel4.Controls.Add(this.Clearbtn);
            this.panel4.Controls.Add(this.Deletebtn);
            this.panel4.Controls.Add(this.Updatebtn);
            this.panel4.Controls.Add(this.Addbtn);
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
            this.panel4.Location = new System.Drawing.Point(148, 356);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(589, 209);
            this.panel4.TabIndex = 3;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(656, 10);
            this.button10.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(81, 30);
            this.button10.TabIndex = 3;
            this.button10.Text = "LogOut";
            this.button10.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(545, 10);
            this.button9.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(98, 30);
            this.button9.TabIndex = 2;
            this.button9.Text = "Notifications";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // lblexpenseId
            // 
            this.lblexpenseId.AutoSize = true;
            this.lblexpenseId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblexpenseId.Location = new System.Drawing.Point(22, 32);
            this.lblexpenseId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblexpenseId.Name = "lblexpenseId";
            this.lblexpenseId.Size = new System.Drawing.Size(81, 17);
            this.lblexpenseId.TabIndex = 18;
            this.lblexpenseId.Text = "Expense Id:";
            // 
            // txtexpenseId
            // 
            this.txtexpenseId.Location = new System.Drawing.Point(107, 32);
            this.txtexpenseId.Margin = new System.Windows.Forms.Padding(2);
            this.txtexpenseId.Name = "txtexpenseId";
            this.txtexpenseId.Size = new System.Drawing.Size(141, 20);
            this.txtexpenseId.TabIndex = 19;
            // 
            // Expense_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 570);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Expense_Details";
            this.Text = "Expense_Details";
            this.Load += new System.EventHandler(this.Expense_Details_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
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
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.TextBox txtexpenseId;
        private System.Windows.Forms.Label lblexpenseId;
    }
}