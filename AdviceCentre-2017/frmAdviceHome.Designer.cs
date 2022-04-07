namespace AdviceCentre_2017
{
    partial class frmAdviceHome
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
            this.components = new System.ComponentModel.Container();
            this.btnHubHome = new System.Windows.Forms.Button();
            this.btnClient = new System.Windows.Forms.Button();
            this.btnBooking = new System.Windows.Forms.Button();
            this.btnDate = new System.Windows.Forms.Button();
            this.AnActualClock = new System.Windows.Forms.Timer(this.components);
            this.btnReferrals = new System.Windows.Forms.Button();
            this.btnRefCli = new System.Windows.Forms.Button();
            this.dgvTimetable = new System.Windows.Forms.DataGridView();
            this.btnAppReport = new System.Windows.Forms.Button();
            this.dgvBackground = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimetable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHubHome
            // 
            this.btnHubHome.BackColor = System.Drawing.Color.Goldenrod;
            this.btnHubHome.Location = new System.Drawing.Point(12, 12);
            this.btnHubHome.Name = "btnHubHome";
            this.btnHubHome.Size = new System.Drawing.Size(135, 30);
            this.btnHubHome.TabIndex = 0;
            this.btnHubHome.Text = "Back to Hub Menu";
            this.btnHubHome.UseVisualStyleBackColor = false;
            this.btnHubHome.Click += new System.EventHandler(this.btnHubHome_Click);
            // 
            // btnClient
            // 
            this.btnClient.BackColor = System.Drawing.Color.Goldenrod;
            this.btnClient.Location = new System.Drawing.Point(153, 12);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(135, 30);
            this.btnClient.TabIndex = 1;
            this.btnClient.Text = "Client Management";
            this.btnClient.UseVisualStyleBackColor = false;
            this.btnClient.Click += new System.EventHandler(this.btnClient_Click);
            // 
            // btnBooking
            // 
            this.btnBooking.BackColor = System.Drawing.Color.Goldenrod;
            this.btnBooking.Location = new System.Drawing.Point(294, 12);
            this.btnBooking.Name = "btnBooking";
            this.btnBooking.Size = new System.Drawing.Size(135, 30);
            this.btnBooking.TabIndex = 2;
            this.btnBooking.Text = "Booking Appointments";
            this.btnBooking.UseVisualStyleBackColor = false;
            this.btnBooking.Click += new System.EventHandler(this.btnBooking_Click);
            // 
            // btnDate
            // 
            this.btnDate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDate.Location = new System.Drawing.Point(12, 48);
            this.btnDate.Name = "btnDate";
            this.btnDate.Size = new System.Drawing.Size(157, 30);
            this.btnDate.TabIndex = 4;
            this.btnDate.Text = "00/00/0000";
            this.btnDate.UseVisualStyleBackColor = true;
            // 
            // AnActualClock
            // 
            this.AnActualClock.Interval = 1000;
            this.AnActualClock.Tick += new System.EventHandler(this.AnActualClock_Tick);
            // 
            // btnReferrals
            // 
            this.btnReferrals.BackColor = System.Drawing.Color.Goldenrod;
            this.btnReferrals.Location = new System.Drawing.Point(435, 12);
            this.btnReferrals.Name = "btnReferrals";
            this.btnReferrals.Size = new System.Drawing.Size(135, 30);
            this.btnReferrals.TabIndex = 71;
            this.btnReferrals.Text = "Referrals";
            this.btnReferrals.UseVisualStyleBackColor = false;
            this.btnReferrals.Click += new System.EventHandler(this.btnReferrals_Click);
            // 
            // btnRefCli
            // 
            this.btnRefCli.BackColor = System.Drawing.Color.Goldenrod;
            this.btnRefCli.Location = new System.Drawing.Point(576, 12);
            this.btnRefCli.Name = "btnRefCli";
            this.btnRefCli.Size = new System.Drawing.Size(138, 30);
            this.btnRefCli.TabIndex = 72;
            this.btnRefCli.Text = "Client-Referrals";
            this.btnRefCli.UseVisualStyleBackColor = false;
            this.btnRefCli.Click += new System.EventHandler(this.btnRefCli_Click);
            // 
            // dgvTimetable
            // 
            this.dgvTimetable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTimetable.Location = new System.Drawing.Point(12, 87);
            this.dgvTimetable.Name = "dgvTimetable";
            this.dgvTimetable.Size = new System.Drawing.Size(867, 348);
            this.dgvTimetable.TabIndex = 73;
            // 
            // btnAppReport
            // 
            this.btnAppReport.BackColor = System.Drawing.Color.Goldenrod;
            this.btnAppReport.Location = new System.Drawing.Point(720, 12);
            this.btnAppReport.Name = "btnAppReport";
            this.btnAppReport.Size = new System.Drawing.Size(157, 30);
            this.btnAppReport.TabIndex = 74;
            this.btnAppReport.Text = "Appointment Reports";
            this.btnAppReport.UseVisualStyleBackColor = false;
            this.btnAppReport.Click += new System.EventHandler(this.btnAppReport_Click);
            // 
            // dgvBackground
            // 
            this.dgvBackground.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBackground.Location = new System.Drawing.Point(639, 87);
            this.dgvBackground.Name = "dgvBackground";
            this.dgvBackground.Size = new System.Drawing.Size(240, 348);
            this.dgvBackground.TabIndex = 75;
            this.dgvBackground.Visible = false;
            // 
            // frmAdviceHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(891, 447);
            this.Controls.Add(this.dgvBackground);
            this.Controls.Add(this.btnAppReport);
            this.Controls.Add(this.dgvTimetable);
            this.Controls.Add(this.btnRefCli);
            this.Controls.Add(this.btnReferrals);
            this.Controls.Add(this.btnDate);
            this.Controls.Add(this.btnBooking);
            this.Controls.Add(this.btnClient);
            this.Controls.Add(this.btnHubHome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmAdviceHome";
            this.Text = "Woodside Advice Branch";
            this.Load += new System.EventHandler(this.frmAdviceHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimetable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBackground)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHubHome;
        private System.Windows.Forms.Button btnClient;
        private System.Windows.Forms.Button btnBooking;
        private System.Windows.Forms.Button btnDate;
        private System.Windows.Forms.Timer AnActualClock;
        private System.Windows.Forms.Button btnReferrals;
        private System.Windows.Forms.Button btnRefCli;
        private System.Windows.Forms.DataGridView dgvTimetable;
        private System.Windows.Forms.Button btnAppReport;
        private System.Windows.Forms.DataGridView dgvBackground;
    }
}