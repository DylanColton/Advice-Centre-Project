namespace AdviceCentre_2017
{
    partial class frmPreBooking
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
            this.btnAdviceHome = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpAppDate = new System.Windows.Forms.DateTimePicker();
            this.cbxClient = new System.Windows.Forms.ComboBox();
            this.cbxStaff = new System.Windows.Forms.ComboBox();
            this.cbxRoom = new System.Windows.Forms.ComboBox();
            this.cbxAdvice = new System.Windows.Forms.ComboBox();
            this.dgvAppointment = new System.Windows.Forms.DataGridView();
            this.dgvCheckAvailable = new System.Windows.Forms.DataGridView();
            this.btnCheckAvailibility = new System.Windows.Forms.Button();
            this.txtDateTime = new System.Windows.Forms.TextBox();
            this.btnSearchByClient = new System.Windows.Forms.Button();
            this.btnSearchByStaff = new System.Windows.Forms.Button();
            this.btnSearchByDate = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckAvailable)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdviceHome
            // 
            this.btnAdviceHome.Location = new System.Drawing.Point(12, 12);
            this.btnAdviceHome.Name = "btnAdviceHome";
            this.btnAdviceHome.Size = new System.Drawing.Size(122, 23);
            this.btnAdviceHome.TabIndex = 135;
            this.btnAdviceHome.Text = "Back to Advice Home";
            this.btnAdviceHome.UseVisualStyleBackColor = true;
            this.btnAdviceHome.Click += new System.EventHandler(this.btnAdviceHome_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(377, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(195, 23);
            this.btnAdd.TabIndex = 141;
            this.btnAdd.Text = "ADD APPOINTMENT";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(579, 12);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(196, 23);
            this.btnEdit.TabIndex = 142;
            this.btnEdit.Text = "EDIT APPOINTMENT";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(781, 11);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(196, 23);
            this.btnDelete.TabIndex = 143;
            this.btnDelete.Text = "DELETE APPOINTMENT";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(12, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 144;
            this.label1.Text = "Client ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(12, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 145;
            this.label2.Text = "Staff ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(454, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 146;
            this.label3.Text = "Room ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(713, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 147;
            this.label4.Text = "Date/Time";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.Window;
            this.label7.Location = new System.Drawing.Point(454, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 150;
            this.label7.Text = "Advice Type";
            // 
            // dtpAppDate
            // 
            this.dtpAppDate.Location = new System.Drawing.Point(777, 95);
            this.dtpAppDate.Name = "dtpAppDate";
            this.dtpAppDate.Size = new System.Drawing.Size(200, 20);
            this.dtpAppDate.TabIndex = 158;
            this.dtpAppDate.ValueChanged += new System.EventHandler(this.dtpAppDate_ValueChanged);
            // 
            // cbxClient
            // 
            this.cbxClient.FormattingEnabled = true;
            this.cbxClient.Location = new System.Drawing.Point(70, 64);
            this.cbxClient.Name = "cbxClient";
            this.cbxClient.Size = new System.Drawing.Size(217, 21);
            this.cbxClient.TabIndex = 159;
            // 
            // cbxStaff
            // 
            this.cbxStaff.FormattingEnabled = true;
            this.cbxStaff.Location = new System.Drawing.Point(70, 123);
            this.cbxStaff.Name = "cbxStaff";
            this.cbxStaff.Size = new System.Drawing.Size(217, 21);
            this.cbxStaff.TabIndex = 160;
            // 
            // cbxRoom
            // 
            this.cbxRoom.FormattingEnabled = true;
            this.cbxRoom.Location = new System.Drawing.Point(527, 64);
            this.cbxRoom.Name = "cbxRoom";
            this.cbxRoom.Size = new System.Drawing.Size(186, 21);
            this.cbxRoom.TabIndex = 161;
            // 
            // cbxAdvice
            // 
            this.cbxAdvice.FormattingEnabled = true;
            this.cbxAdvice.Location = new System.Drawing.Point(527, 120);
            this.cbxAdvice.Name = "cbxAdvice";
            this.cbxAdvice.Size = new System.Drawing.Size(186, 21);
            this.cbxAdvice.TabIndex = 162;
            // 
            // dgvAppointment
            // 
            this.dgvAppointment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAppointment.Location = new System.Drawing.Point(13, 166);
            this.dgvAppointment.Name = "dgvAppointment";
            this.dgvAppointment.Size = new System.Drawing.Size(967, 369);
            this.dgvAppointment.TabIndex = 163;
            this.dgvAppointment.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAppointment_CellClick);
            // 
            // dgvCheckAvailable
            // 
            this.dgvCheckAvailable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCheckAvailable.Location = new System.Drawing.Point(583, 166);
            this.dgvCheckAvailable.Name = "dgvCheckAvailable";
            this.dgvCheckAvailable.Size = new System.Drawing.Size(397, 369);
            this.dgvCheckAvailable.TabIndex = 164;
            this.dgvCheckAvailable.Visible = false;
            // 
            // btnCheckAvailibility
            // 
            this.btnCheckAvailibility.Location = new System.Drawing.Point(377, 11);
            this.btnCheckAvailibility.Name = "btnCheckAvailibility";
            this.btnCheckAvailibility.Size = new System.Drawing.Size(194, 23);
            this.btnCheckAvailibility.TabIndex = 165;
            this.btnCheckAvailibility.Text = "CHECK AVAILABILITY";
            this.btnCheckAvailibility.UseVisualStyleBackColor = true;
            this.btnCheckAvailibility.Click += new System.EventHandler(this.btnCheckAvailibility_Click);
            // 
            // txtDateTime
            // 
            this.txtDateTime.Location = new System.Drawing.Point(777, 120);
            this.txtDateTime.Name = "txtDateTime";
            this.txtDateTime.Size = new System.Drawing.Size(200, 20);
            this.txtDateTime.TabIndex = 166;
            this.txtDateTime.Visible = false;
            // 
            // btnSearchByClient
            // 
            this.btnSearchByClient.Location = new System.Drawing.Point(293, 62);
            this.btnSearchByClient.Name = "btnSearchByClient";
            this.btnSearchByClient.Size = new System.Drawing.Size(131, 23);
            this.btnSearchByClient.TabIndex = 167;
            this.btnSearchByClient.Text = "Search For Appointment";
            this.btnSearchByClient.UseVisualStyleBackColor = true;
            this.btnSearchByClient.Click += new System.EventHandler(this.btnSearchByClient_Click);
            // 
            // btnSearchByStaff
            // 
            this.btnSearchByStaff.Location = new System.Drawing.Point(293, 121);
            this.btnSearchByStaff.Name = "btnSearchByStaff";
            this.btnSearchByStaff.Size = new System.Drawing.Size(131, 23);
            this.btnSearchByStaff.TabIndex = 168;
            this.btnSearchByStaff.Text = "Search For Appointment";
            this.btnSearchByStaff.UseVisualStyleBackColor = true;
            this.btnSearchByStaff.Click += new System.EventHandler(this.btnSearchByStaff_Click);
            // 
            // btnSearchByDate
            // 
            this.btnSearchByDate.Location = new System.Drawing.Point(777, 118);
            this.btnSearchByDate.Name = "btnSearchByDate";
            this.btnSearchByDate.Size = new System.Drawing.Size(200, 23);
            this.btnSearchByDate.TabIndex = 169;
            this.btnSearchByDate.Text = "Search For Appointment";
            this.btnSearchByDate.UseVisualStyleBackColor = true;
            this.btnSearchByDate.Click += new System.EventHandler(this.btnSearchByDate_Click);
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(181, 11);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(106, 23);
            this.btnReload.TabIndex = 170;
            this.btnReload.Text = "Reload Table";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // frmPreBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(992, 547);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnSearchByDate);
            this.Controls.Add(this.btnSearchByStaff);
            this.Controls.Add(this.btnSearchByClient);
            this.Controls.Add(this.txtDateTime);
            this.Controls.Add(this.btnCheckAvailibility);
            this.Controls.Add(this.dgvCheckAvailable);
            this.Controls.Add(this.dgvAppointment);
            this.Controls.Add(this.cbxAdvice);
            this.Controls.Add(this.cbxRoom);
            this.Controls.Add(this.cbxStaff);
            this.Controls.Add(this.cbxClient);
            this.Controls.Add(this.dtpAppDate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnAdviceHome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmPreBooking";
            this.Text = "Booking";
            this.Load += new System.EventHandler(this.frmPreBooking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckAvailable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAdviceHome;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpAppDate;
        private System.Windows.Forms.ComboBox cbxClient;
        private System.Windows.Forms.ComboBox cbxStaff;
        private System.Windows.Forms.ComboBox cbxRoom;
        private System.Windows.Forms.ComboBox cbxAdvice;
        private System.Windows.Forms.DataGridView dgvAppointment;
        private System.Windows.Forms.DataGridView dgvCheckAvailable;
        private System.Windows.Forms.Button btnCheckAvailibility;
        private System.Windows.Forms.TextBox txtDateTime;
        private System.Windows.Forms.Button btnSearchByClient;
        private System.Windows.Forms.Button btnSearchByStaff;
        private System.Windows.Forms.Button btnSearchByDate;
        private System.Windows.Forms.Button btnReload;
    }
}