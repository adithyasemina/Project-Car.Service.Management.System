
namespace Car_Service_Management_System
{
    partial class AddService
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
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtSProvider = new System.Windows.Forms.TextBox();
            this.txtVehicleNo = new System.Windows.Forms.TextBox();
            this.txtService = new System.Windows.Forms.TextBox();
            this.lblBrand = new System.Windows.Forms.Label();
            this.lblSProvider = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblVehicleNo = new System.Windows.Forms.Label();
            this.lblService = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtId
            // 
            this.txtId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtId.Location = new System.Drawing.Point(380, 132);
            this.txtId.Margin = new System.Windows.Forms.Padding(4);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(461, 31);
            this.txtId.TabIndex = 32;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Gill Sans MT", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblId.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblId.Location = new System.Drawing.Point(118, 130);
            this.lblId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(152, 33);
            this.lblId.TabIndex = 31;
            this.lblId.Text = "ID NUMBER";
            this.lblId.Click += new System.EventHandler(this.lblId_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(75)))), ((int)(((byte)(76)))));
            this.btnDelete.Location = new System.Drawing.Point(654, 505);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(187, 42);
            this.btnDelete.TabIndex = 30;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(56)))), ((int)(((byte)(63)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(220)))), ((int)(((byte)(147)))));
            this.btnUpdate.Location = new System.Drawing.Point(392, 505);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(187, 42);
            this.btnUpdate.TabIndex = 29;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtSProvider
            // 
            this.txtSProvider.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSProvider.Location = new System.Drawing.Point(380, 422);
            this.txtSProvider.Margin = new System.Windows.Forms.Padding(4);
            this.txtSProvider.Name = "txtSProvider";
            this.txtSProvider.Size = new System.Drawing.Size(461, 31);
            this.txtSProvider.TabIndex = 26;
            // 
            // txtVehicleNo
            // 
            this.txtVehicleNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVehicleNo.Location = new System.Drawing.Point(380, 230);
            this.txtVehicleNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtVehicleNo.Name = "txtVehicleNo";
            this.txtVehicleNo.Size = new System.Drawing.Size(461, 31);
            this.txtVehicleNo.TabIndex = 25;
            // 
            // txtService
            // 
            this.txtService.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtService.Location = new System.Drawing.Point(380, 182);
            this.txtService.Margin = new System.Windows.Forms.Padding(4);
            this.txtService.Name = "txtService";
            this.txtService.Size = new System.Drawing.Size(461, 31);
            this.txtService.TabIndex = 24;
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Font = new System.Drawing.Font("Gill Sans MT", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblBrand.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblBrand.Location = new System.Drawing.Point(114, 276);
            this.lblBrand.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(102, 33);
            this.lblBrand.TabIndex = 23;
            this.lblBrand.Text = "BRAND";
            // 
            // lblSProvider
            // 
            this.lblSProvider.AutoSize = true;
            this.lblSProvider.Font = new System.Drawing.Font("Gill Sans MT", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblSProvider.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblSProvider.Location = new System.Drawing.Point(114, 420);
            this.lblSProvider.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSProvider.Name = "lblSProvider";
            this.lblSProvider.Size = new System.Drawing.Size(249, 33);
            this.lblSProvider.TabIndex = 22;
            this.lblSProvider.Text = "SERVICE PROVIDER";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Gill Sans MT", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblDate.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblDate.Location = new System.Drawing.Point(114, 372);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(83, 33);
            this.lblDate.TabIndex = 21;
            this.lblDate.Text = "DATE";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(380, 374);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(461, 31);
            this.dateTimePicker1.TabIndex = 20;
            // 
            // lblVehicleNo
            // 
            this.lblVehicleNo.AutoSize = true;
            this.lblVehicleNo.Font = new System.Drawing.Font("Gill Sans MT", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblVehicleNo.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblVehicleNo.Location = new System.Drawing.Point(118, 228);
            this.lblVehicleNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVehicleNo.Name = "lblVehicleNo";
            this.lblVehicleNo.Size = new System.Drawing.Size(166, 33);
            this.lblVehicleNo.TabIndex = 19;
            this.lblVehicleNo.Text = "VEHICLE NO";
            // 
            // lblService
            // 
            this.lblService.AutoSize = true;
            this.lblService.Font = new System.Drawing.Font("Gill Sans MT", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblService.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblService.Location = new System.Drawing.Point(118, 180);
            this.lblService.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(118, 33);
            this.lblService.TabIndex = 18;
            this.lblService.Text = "SERVICE";
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(72)))));
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInsert.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(143)))), ((int)(((byte)(254)))));
            this.btnInsert.Location = new System.Drawing.Point(124, 505);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(4);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(187, 42);
            this.btnInsert.TabIndex = 17;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // txtModel
            // 
            this.txtModel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtModel.Location = new System.Drawing.Point(380, 326);
            this.txtModel.Margin = new System.Windows.Forms.Padding(4);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(461, 31);
            this.txtModel.TabIndex = 33;
            // 
            // txtBrand
            // 
            this.txtBrand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBrand.Location = new System.Drawing.Point(380, 278);
            this.txtBrand.Margin = new System.Windows.Forms.Padding(4);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(461, 31);
            this.txtBrand.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans MT", 13.8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Location = new System.Drawing.Point(114, 324);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 33);
            this.label1.TabIndex = 35;
            this.label1.Text = "MODEL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.label2.Font = new System.Drawing.Font("Candara", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(373, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 40);
            this.label2.TabIndex = 36;
            this.label2.Text = "ADD SERVICES";
            // 
            // AddService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(974, 625);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBrand);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtSProvider);
            this.Controls.Add(this.txtVehicleNo);
            this.Controls.Add(this.txtService);
            this.Controls.Add(this.lblBrand);
            this.Controls.Add(this.lblSProvider);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblVehicleNo);
            this.Controls.Add(this.lblService);
            this.Controls.Add(this.btnInsert);
            this.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddService";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Services Data";
            this.Load += new System.EventHandler(this.AddService_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtSProvider;
        private System.Windows.Forms.TextBox txtVehicleNo;
        private System.Windows.Forms.TextBox txtService;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblSProvider;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblVehicleNo;
        private System.Windows.Forms.Label lblService;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}