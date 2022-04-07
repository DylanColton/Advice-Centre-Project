namespace AdviceCentre_2017
{
    partial class frmRoomAppointments
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new AdviceCentre_2017.DataSet1();
            this.btnBackToAdvice = new System.Windows.Forms.Button();
            this.cbxRoomID = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.btnCheck = new System.Windows.Forms.Button();
            this.dataTable1TableAdapter = new AdviceCentre_2017.DataSet1TableAdapters.DataTable1TableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet1BindingSource
            // 
            this.dataSet1BindingSource.DataSource = typeof(AdviceCentre_2017.DataSet1TableAdapters.DataTable1TableAdapter);
            // 
            // dataTable1BindingSource
            // 
            this.dataTable1BindingSource.DataMember = "DataTable1";
            this.dataTable1BindingSource.DataSource = this.dataSet1BindingSource1;
            // 
            // dataSet1BindingSource1
            // 
            this.dataSet1BindingSource1.DataSource = this.dataSet1;
            this.dataSet1BindingSource1.Position = 0;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.RemotingFormat = System.Data.SerializationFormat.Binary;
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.ExcludeSchema;
            // 
            // btnBackToAdvice
            // 
            this.btnBackToAdvice.Location = new System.Drawing.Point(12, 12);
            this.btnBackToAdvice.Name = "btnBackToAdvice";
            this.btnBackToAdvice.Size = new System.Drawing.Size(127, 23);
            this.btnBackToAdvice.TabIndex = 0;
            this.btnBackToAdvice.Text = "Back to Advice Centre";
            this.btnBackToAdvice.UseVisualStyleBackColor = true;
            this.btnBackToAdvice.Click += new System.EventHandler(this.btnBackToAdvice_Click);
            // 
            // cbxRoomID
            // 
            this.cbxRoomID.FormattingEnabled = true;
            this.cbxRoomID.Location = new System.Drawing.Point(305, 14);
            this.cbxRoomID.Name = "cbxRoomID";
            this.cbxRoomID.Size = new System.Drawing.Size(200, 21);
            this.cbxRoomID.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(226, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Room ID";
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(305, 41);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 20);
            this.dtpDate.TabIndex = 5;
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(511, 38);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(214, 23);
            this.btnCheck.TabIndex = 6;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // dataTable1TableAdapter
            // 
            this.dataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.dataTable1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "AdviceCentre_2017.Offices.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(23, 103);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(829, 320);
            this.reportViewer1.TabIndex = 7;
            // 
            // frmRoomAppointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(900, 464);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxRoomID);
            this.Controls.Add(this.btnBackToAdvice);
            this.Name = "frmRoomAppointments";
            this.Text = "Reports for Appointments per Rooms";
            this.Load += new System.EventHandler(this.frmRoomAppointments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBackToAdvice;
        private System.Windows.Forms.ComboBox cbxRoomID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Button btnCheck;
        public DataSet1 dataSet1;
        public System.Windows.Forms.BindingSource dataSet1BindingSource;
        public System.Windows.Forms.BindingSource dataSet1BindingSource1;
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private DataSet1TableAdapters.DataTable1TableAdapter dataTable1TableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}