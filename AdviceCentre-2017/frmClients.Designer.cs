namespace AdviceCentre_2017
{
    partial class frmClients
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
            this.btnAdviceHome = new System.Windows.Forms.Button();
            this.btnClientName = new System.Windows.Forms.Button();
            this.btnClientID = new System.Windows.Forms.Button();
            this.txtClientName = new System.Windows.Forms.TextBox();
            this.txtClientID = new System.Windows.Forms.TextBox();
            this.btnAddClient = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPhoneNo = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDeleteClient = new System.Windows.Forms.Button();
            this.btnEditClient = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.rtxtDescription = new System.Windows.Forms.RichTextBox();
            this.dgvClients = new System.Windows.Forms.DataGridView();
            this.clientIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientPhoneNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientRecords_AdviceCentre_2017DataSet = new AdviceCentre_2017.ClientRecords_AdviceCentre_2017DataSet();
            this.clientTableAdapter = new AdviceCentre_2017.ClientRecords_AdviceCentre_2017DataSetTableAdapters.ClientTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientRecords_AdviceCentre_2017DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdviceHome
            // 
            this.btnAdviceHome.Location = new System.Drawing.Point(12, 12);
            this.btnAdviceHome.Name = "btnAdviceHome";
            this.btnAdviceHome.Size = new System.Drawing.Size(83, 28);
            this.btnAdviceHome.TabIndex = 11;
            this.btnAdviceHome.Text = "Back to Home";
            this.btnAdviceHome.UseVisualStyleBackColor = true;
            this.btnAdviceHome.Click += new System.EventHandler(this.btnAdviceHome_Click);
            // 
            // btnClientName
            // 
            this.btnClientName.BackColor = System.Drawing.Color.Goldenrod;
            this.btnClientName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientName.Location = new System.Drawing.Point(12, 46);
            this.btnClientName.Name = "btnClientName";
            this.btnClientName.Size = new System.Drawing.Size(83, 28);
            this.btnClientName.TabIndex = 1;
            this.btnClientName.Text = "Client Name";
            this.btnClientName.UseVisualStyleBackColor = false;
            // 
            // btnClientID
            // 
            this.btnClientID.BackColor = System.Drawing.Color.Goldenrod;
            this.btnClientID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientID.Location = new System.Drawing.Point(12, 80);
            this.btnClientID.Name = "btnClientID";
            this.btnClientID.Size = new System.Drawing.Size(83, 28);
            this.btnClientID.TabIndex = 2;
            this.btnClientID.Text = "Client ID";
            this.btnClientID.UseVisualStyleBackColor = false;
            // 
            // txtClientName
            // 
            this.txtClientName.Location = new System.Drawing.Point(101, 51);
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.Size = new System.Drawing.Size(203, 20);
            this.txtClientName.TabIndex = 3;
            this.txtClientName.TextChanged += new System.EventHandler(this.txtClientName_TextChanged);
            // 
            // txtClientID
            // 
            this.txtClientID.Location = new System.Drawing.Point(101, 85);
            this.txtClientID.Name = "txtClientID";
            this.txtClientID.Size = new System.Drawing.Size(203, 20);
            this.txtClientID.TabIndex = 4;
            this.txtClientID.TextChanged += new System.EventHandler(this.txtClientID_TextChanged);
            // 
            // btnAddClient
            // 
            this.btnAddClient.Location = new System.Drawing.Point(12, 111);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(92, 60);
            this.btnAddClient.TabIndex = 7;
            this.btnAddClient.Text = "Add ";
            this.btnAddClient.UseVisualStyleBackColor = true;
            this.btnAddClient.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 358);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Phone Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 395);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "E-mail";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(124, 223);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(180, 20);
            this.txtName.TabIndex = 0;
            // 
            // txtPhoneNo
            // 
            this.txtPhoneNo.Location = new System.Drawing.Point(123, 359);
            this.txtPhoneNo.Name = "txtPhoneNo";
            this.txtPhoneNo.Size = new System.Drawing.Size(181, 20);
            this.txtPhoneNo.TabIndex = 2;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(124, 396);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(180, 20);
            this.txtEmail.TabIndex = 3;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(124, 188);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(180, 20);
            this.txtID.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 18);
            this.label4.TabIndex = 14;
            this.label4.Text = "Client ID";
            // 
            // btnDeleteClient
            // 
            this.btnDeleteClient.Location = new System.Drawing.Point(110, 111);
            this.btnDeleteClient.Name = "btnDeleteClient";
            this.btnDeleteClient.Size = new System.Drawing.Size(95, 60);
            this.btnDeleteClient.TabIndex = 16;
            this.btnDeleteClient.Text = "Delete";
            this.btnDeleteClient.UseVisualStyleBackColor = true;
            this.btnDeleteClient.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEditClient
            // 
            this.btnEditClient.Location = new System.Drawing.Point(211, 111);
            this.btnEditClient.Name = "btnEditClient";
            this.btnEditClient.Size = new System.Drawing.Size(93, 60);
            this.btnEditClient.TabIndex = 17;
            this.btnEditClient.Text = "Edit";
            this.btnEditClient.UseVisualStyleBackColor = true;
            this.btnEditClient.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 18);
            this.label5.TabIndex = 20;
            this.label5.Text = "Description";
            // 
            // rtxtDescription
            // 
            this.rtxtDescription.Location = new System.Drawing.Point(124, 249);
            this.rtxtDescription.Name = "rtxtDescription";
            this.rtxtDescription.Size = new System.Drawing.Size(180, 104);
            this.rtxtDescription.TabIndex = 1;
            this.rtxtDescription.Text = "";
            // 
            // dgvClients
            // 
            this.dgvClients.AutoGenerateColumns = false;
            this.dgvClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clientIDDataGridViewTextBoxColumn,
            this.clientNameDataGridViewTextBoxColumn,
            this.clientDescriptionDataGridViewTextBoxColumn,
            this.clientPhoneNoDataGridViewTextBoxColumn,
            this.clientEmailDataGridViewTextBoxColumn});
            this.dgvClients.DataSource = this.clientBindingSource;
            this.dgvClients.Location = new System.Drawing.Point(310, 12);
            this.dgvClients.Name = "dgvClients";
            this.dgvClients.Size = new System.Drawing.Size(862, 437);
            this.dgvClients.TabIndex = 22;
            this.dgvClients.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClients_CellClick);
            // 
            // clientIDDataGridViewTextBoxColumn
            // 
            this.clientIDDataGridViewTextBoxColumn.DataPropertyName = "ClientID";
            this.clientIDDataGridViewTextBoxColumn.HeaderText = "ClientID";
            this.clientIDDataGridViewTextBoxColumn.Name = "clientIDDataGridViewTextBoxColumn";
            this.clientIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.clientIDDataGridViewTextBoxColumn.Width = 50;
            // 
            // clientNameDataGridViewTextBoxColumn
            // 
            this.clientNameDataGridViewTextBoxColumn.DataPropertyName = "ClientName";
            this.clientNameDataGridViewTextBoxColumn.HeaderText = "ClientName";
            this.clientNameDataGridViewTextBoxColumn.Name = "clientNameDataGridViewTextBoxColumn";
            // 
            // clientDescriptionDataGridViewTextBoxColumn
            // 
            this.clientDescriptionDataGridViewTextBoxColumn.DataPropertyName = "ClientDescription";
            this.clientDescriptionDataGridViewTextBoxColumn.HeaderText = "ClientDescription";
            this.clientDescriptionDataGridViewTextBoxColumn.Name = "clientDescriptionDataGridViewTextBoxColumn";
            this.clientDescriptionDataGridViewTextBoxColumn.Width = 400;
            // 
            // clientPhoneNoDataGridViewTextBoxColumn
            // 
            this.clientPhoneNoDataGridViewTextBoxColumn.DataPropertyName = "ClientPhoneNo";
            this.clientPhoneNoDataGridViewTextBoxColumn.HeaderText = "ClientPhoneNo";
            this.clientPhoneNoDataGridViewTextBoxColumn.Name = "clientPhoneNoDataGridViewTextBoxColumn";
            // 
            // clientEmailDataGridViewTextBoxColumn
            // 
            this.clientEmailDataGridViewTextBoxColumn.DataPropertyName = "ClientEmail";
            this.clientEmailDataGridViewTextBoxColumn.HeaderText = "ClientEmail";
            this.clientEmailDataGridViewTextBoxColumn.Name = "clientEmailDataGridViewTextBoxColumn";
            this.clientEmailDataGridViewTextBoxColumn.Width = 200;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "Client";
            this.clientBindingSource.DataSource = this.clientRecords_AdviceCentre_2017DataSet;
            // 
            // clientRecords_AdviceCentre_2017DataSet
            // 
            this.clientRecords_AdviceCentre_2017DataSet.DataSetName = "ClientRecords_AdviceCentre_2017DataSet";
            this.clientRecords_AdviceCentre_2017DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // frmClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(1184, 461);
            this.Controls.Add(this.dgvClients);
            this.Controls.Add(this.rtxtDescription);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnEditClient);
            this.Controls.Add(this.btnDeleteClient);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPhoneNo);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddClient);
            this.Controls.Add(this.txtClientID);
            this.Controls.Add(this.txtClientName);
            this.Controls.Add(this.btnClientID);
            this.Controls.Add(this.btnClientName);
            this.Controls.Add(this.btnAdviceHome);
            this.Name = "frmClients";
            this.Text = "Clients";
            this.Load += new System.EventHandler(this.frmClients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientRecords_AdviceCentre_2017DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdviceHome;
        private System.Windows.Forms.Button btnClientName;
        private System.Windows.Forms.Button btnClientID;
        private System.Windows.Forms.TextBox txtClientName;
        private System.Windows.Forms.TextBox txtClientID;
        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPhoneNo;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDeleteClient;
        private System.Windows.Forms.Button btnEditClient;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox rtxtDescription;
        private System.Windows.Forms.DataGridView dgvClients;
        private ClientRecords_AdviceCentre_2017DataSet clientRecords_AdviceCentre_2017DataSet;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private ClientRecords_AdviceCentre_2017DataSetTableAdapters.ClientTableAdapter clientTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientPhoneNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientEmailDataGridViewTextBoxColumn;
    }
}