namespace AdviceCentre_2017
{
    partial class Referrals
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
            this.btnAddRef = new System.Windows.Forms.Button();
            this.btnEditRef = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPhoneNo = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtFindRefID = new System.Windows.Forms.TextBox();
            this.txtFindRefName = new System.Windows.Forms.TextBox();
            this.dgvReferral = new System.Windows.Forms.DataGridView();
            this.referralBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.referral_AdviceCentre_2017DataSet = new AdviceCentre_2017.Referral_AdviceCentre_2017DataSet();
            this.referralTableAdapter = new AdviceCentre_2017.Referral_AdviceCentre_2017DataSetTableAdapters.ReferralTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReferral)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.referralBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.referral_AdviceCentre_2017DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdviceHome
            // 
            this.btnAdviceHome.Location = new System.Drawing.Point(12, 12);
            this.btnAdviceHome.Name = "btnAdviceHome";
            this.btnAdviceHome.Size = new System.Drawing.Size(93, 23);
            this.btnAdviceHome.TabIndex = 0;
            this.btnAdviceHome.Text = "Advice Home";
            this.btnAdviceHome.UseVisualStyleBackColor = true;
            this.btnAdviceHome.Click += new System.EventHandler(this.btnAdviceHome_Click);
            // 
            // btnAddRef
            // 
            this.btnAddRef.Location = new System.Drawing.Point(12, 175);
            this.btnAddRef.Name = "btnAddRef";
            this.btnAddRef.Size = new System.Drawing.Size(103, 48);
            this.btnAddRef.TabIndex = 1;
            this.btnAddRef.Text = "ADD REFERENCE";
            this.btnAddRef.UseVisualStyleBackColor = true;
            this.btnAddRef.Click += new System.EventHandler(this.btnAddRef_Click);
            // 
            // btnEditRef
            // 
            this.btnEditRef.Location = new System.Drawing.Point(121, 175);
            this.btnEditRef.Name = "btnEditRef";
            this.btnEditRef.Size = new System.Drawing.Size(103, 48);
            this.btnEditRef.TabIndex = 2;
            this.btnEditRef.Text = "EDIT REFERENCE";
            this.btnEditRef.UseVisualStyleBackColor = true;
            this.btnEditRef.Click += new System.EventHandler(this.btnEditRef_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(229, 175);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(103, 48);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "DELETE REFERENCE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 268);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Referral ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Referral Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 320);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Referral Phone No";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 346);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Referral Email";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(137, 267);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(195, 20);
            this.txtID.TabIndex = 10;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(137, 293);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(195, 20);
            this.txtName.TabIndex = 11;
            // 
            // txtPhoneNo
            // 
            this.txtPhoneNo.Location = new System.Drawing.Point(137, 319);
            this.txtPhoneNo.Name = "txtPhoneNo";
            this.txtPhoneNo.Size = new System.Drawing.Size(195, 20);
            this.txtPhoneNo.TabIndex = 12;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(137, 345);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(195, 20);
            this.txtEmail.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Goldenrod;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(12, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Referral ID";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Goldenrod;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(12, 102);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Referral Name";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // txtFindRefID
            // 
            this.txtFindRefID.Location = new System.Drawing.Point(111, 75);
            this.txtFindRefID.Name = "txtFindRefID";
            this.txtFindRefID.Size = new System.Drawing.Size(221, 20);
            this.txtFindRefID.TabIndex = 16;
            this.txtFindRefID.TextChanged += new System.EventHandler(this.txtFindRefID_TextChanged);
            // 
            // txtFindRefName
            // 
            this.txtFindRefName.Location = new System.Drawing.Point(111, 104);
            this.txtFindRefName.Name = "txtFindRefName";
            this.txtFindRefName.Size = new System.Drawing.Size(221, 20);
            this.txtFindRefName.TabIndex = 17;
            this.txtFindRefName.TextChanged += new System.EventHandler(this.txtFindRefName_TextChanged);
            // 
            // dgvReferral
            // 
            this.dgvReferral.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReferral.Location = new System.Drawing.Point(338, 12);
            this.dgvReferral.Name = "dgvReferral";
            this.dgvReferral.Size = new System.Drawing.Size(616, 425);
            this.dgvReferral.TabIndex = 19;
            this.dgvReferral.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReferral_CellClick);
            // 
            // referralBindingSource
            // 
            this.referralBindingSource.DataMember = "Referral";
            this.referralBindingSource.DataSource = this.referral_AdviceCentre_2017DataSet;
            // 
            // referral_AdviceCentre_2017DataSet
            // 
            this.referral_AdviceCentre_2017DataSet.DataSetName = "Referral_AdviceCentre_2017DataSet";
            this.referral_AdviceCentre_2017DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // referralTableAdapter
            // 
            this.referralTableAdapter.ClearBeforeFill = true;
            // 
            // Referrals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(966, 449);
            this.Controls.Add(this.dgvReferral);
            this.Controls.Add(this.txtFindRefName);
            this.Controls.Add(this.txtFindRefID);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPhoneNo);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEditRef);
            this.Controls.Add(this.btnAddRef);
            this.Controls.Add(this.btnAdviceHome);
            this.Name = "Referrals";
            this.Text = "Referrals";
            this.Load += new System.EventHandler(this.Referrals_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReferral)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.referralBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.referral_AdviceCentre_2017DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdviceHome;
        private System.Windows.Forms.Button btnAddRef;
        private System.Windows.Forms.Button btnEditRef;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPhoneNo;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtFindRefID;
        private System.Windows.Forms.TextBox txtFindRefName;
        private System.Windows.Forms.DataGridView dgvReferral;
        private Referral_AdviceCentre_2017DataSet referral_AdviceCentre_2017DataSet;
        private System.Windows.Forms.BindingSource referralBindingSource;
        private Referral_AdviceCentre_2017DataSetTableAdapters.ReferralTableAdapter referralTableAdapter;
    }
}