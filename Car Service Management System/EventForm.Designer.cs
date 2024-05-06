
namespace Car_Service_Management_System
{
    partial class EventForm
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
            this.txdate = new System.Windows.Forms.TextBox();
            this.txvehicle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnsave = new System.Windows.Forms.Button();
            this.ReferenceId = new System.Windows.Forms.TextBox();
            this.ReferenceIdtxt = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.txtime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // txdate
            // 
            this.txdate.Enabled = false;
            this.txdate.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txdate.Location = new System.Drawing.Point(303, 68);
            this.txdate.Margin = new System.Windows.Forms.Padding(4);
            this.txdate.Name = "txdate";
            this.txdate.Size = new System.Drawing.Size(367, 33);
            this.txdate.TabIndex = 0;
            // 
            // txvehicle
            // 
            this.txvehicle.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txvehicle.Location = new System.Drawing.Point(303, 186);
            this.txvehicle.Margin = new System.Windows.Forms.Padding(4);
            this.txvehicle.Name = "txvehicle";
            this.txvehicle.Size = new System.Drawing.Size(367, 33);
            this.txvehicle.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans MT", 13.8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Location = new System.Drawing.Point(78, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gill Sans MT", 13.8F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label2.Location = new System.Drawing.Point(78, 186);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 33);
            this.label2.TabIndex = 3;
            this.label2.Text = "Vehicle Number";
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(56)))), ((int)(((byte)(63)))));
            this.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(220)))), ((int)(((byte)(147)))));
            this.btnsave.Location = new System.Drawing.Point(492, 532);
            this.btnsave.Margin = new System.Windows.Forms.Padding(4);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(187, 42);
            this.btnsave.TabIndex = 4;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // ReferenceId
            // 
            this.ReferenceId.Enabled = false;
            this.ReferenceId.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReferenceId.Location = new System.Drawing.Point(303, 126);
            this.ReferenceId.Margin = new System.Windows.Forms.Padding(4);
            this.ReferenceId.Name = "ReferenceId";
            this.ReferenceId.Size = new System.Drawing.Size(367, 33);
            this.ReferenceId.TabIndex = 5;
            // 
            // ReferenceIdtxt
            // 
            this.ReferenceIdtxt.AutoSize = true;
            this.ReferenceIdtxt.Font = new System.Drawing.Font("Gill Sans MT", 13.8F, System.Drawing.FontStyle.Bold);
            this.ReferenceIdtxt.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.ReferenceIdtxt.Location = new System.Drawing.Point(78, 126);
            this.ReferenceIdtxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ReferenceIdtxt.Name = "ReferenceIdtxt";
            this.ReferenceIdtxt.Size = new System.Drawing.Size(152, 33);
            this.ReferenceIdtxt.TabIndex = 6;
            this.ReferenceIdtxt.Text = "Reference Id";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(74, 314);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.Size = new System.Drawing.Size(605, 185);
            this.dataGridView.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Gill Sans MT", 13.8F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label5.Location = new System.Drawing.Point(78, 245);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 33);
            this.label5.TabIndex = 8;
            this.label5.Text = "Time Slot";
            // 
            // txtime
            // 
            this.txtime.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtime.Location = new System.Drawing.Point(303, 245);
            this.txtime.Margin = new System.Windows.Forms.Padding(4);
            this.txtime.Name = "txtime";
            this.txtime.Size = new System.Drawing.Size(367, 33);
            this.txtime.TabIndex = 9;
            // 
            // EventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(821, 618);
            this.Controls.Add(this.txtime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.ReferenceIdtxt);
            this.Controls.Add(this.ReferenceId);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txvehicle);
            this.Controls.Add(this.txdate);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EventForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.EventForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txdate;
        private System.Windows.Forms.TextBox txvehicle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.TextBox ReferenceId;
        private System.Windows.Forms.Label ReferenceIdtxt;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtime;
    }
}