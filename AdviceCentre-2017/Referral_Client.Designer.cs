namespace AdviceCentre_2017
{
    partial class Referral_Client
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
            this.btnAddCliRef = new System.Windows.Forms.Button();
            this.btnDelCliRef = new System.Windows.Forms.Button();
            this.dgvRefCli = new System.Windows.Forms.DataGridView();
            this.dgvClient = new System.Windows.Forms.DataGridView();
            this.dgvReferrals = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.txtSearchCliID = new System.Windows.Forms.TextBox();
            this.txtSearchCliName = new System.Windows.Forms.TextBox();
            this.txtSearchRefID = new System.Windows.Forms.TextBox();
            this.txtSearchRefName = new System.Windows.Forms.TextBox();
            this.cbxClientID = new System.Windows.Forms.ComboBox();
            this.cbxRefID = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFindCliID = new System.Windows.Forms.TextBox();
            this.txtFindRefID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRefCli)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReferrals)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdviceHome
            // 
            this.btnAdviceHome.Location = new System.Drawing.Point(12, 12);
            this.btnAdviceHome.Name = "btnAdviceHome";
            this.btnAdviceHome.Size = new System.Drawing.Size(88, 23);
            this.btnAdviceHome.TabIndex = 0;
            this.btnAdviceHome.Text = "Advice Home";
            this.btnAdviceHome.UseVisualStyleBackColor = true;
            this.btnAdviceHome.Click += new System.EventHandler(this.btnAdviceHome_Click);
            // 
            // btnAddCliRef
            // 
            this.btnAddCliRef.Location = new System.Drawing.Point(108, 12);
            this.btnAddCliRef.Name = "btnAddCliRef";
            this.btnAddCliRef.Size = new System.Drawing.Size(134, 37);
            this.btnAddCliRef.TabIndex = 1;
            this.btnAddCliRef.Text = "Add Client Reference";
            this.btnAddCliRef.UseVisualStyleBackColor = true;
            this.btnAddCliRef.Click += new System.EventHandler(this.btnAddCliRef_Click);
            // 
            // btnDelCliRef
            // 
            this.btnDelCliRef.Location = new System.Drawing.Point(248, 12);
            this.btnDelCliRef.Name = "btnDelCliRef";
            this.btnDelCliRef.Size = new System.Drawing.Size(134, 37);
            this.btnDelCliRef.TabIndex = 2;
            this.btnDelCliRef.Text = "Delete Client Reference";
            this.btnDelCliRef.UseVisualStyleBackColor = true;
            this.btnDelCliRef.Click += new System.EventHandler(this.btnDelCliRef_Click);
            // 
            // dgvRefCli
            // 
            this.dgvRefCli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRefCli.Location = new System.Drawing.Point(789, 12);
            this.dgvRefCli.Name = "dgvRefCli";
            this.dgvRefCli.Size = new System.Drawing.Size(356, 511);
            this.dgvRefCli.TabIndex = 3;
            this.dgvRefCli.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRefCli_CellClick);
            // 
            // dgvClient
            // 
            this.dgvClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClient.Location = new System.Drawing.Point(12, 184);
            this.dgvClient.Name = "dgvClient";
            this.dgvClient.Size = new System.Drawing.Size(771, 150);
            this.dgvClient.TabIndex = 4;
            // 
            // dgvReferrals
            // 
            this.dgvReferrals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReferrals.Location = new System.Drawing.Point(12, 369);
            this.dgvReferrals.Name = "dgvReferrals";
            this.dgvReferrals.Size = new System.Drawing.Size(771, 154);
            this.dgvReferrals.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Client ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(248, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Referral ID";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSlateGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(12, 157);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "ClientID";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightSlateGray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(284, 156);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Client Name";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightSlateGray;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(12, 341);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(130, 23);
            this.button3.TabIndex = 16;
            this.button3.Text = "Referral ID";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightSlateGray;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(284, 340);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(130, 23);
            this.button4.TabIndex = 17;
            this.button4.Text = "Referral Name";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // txtSearchCliID
            // 
            this.txtSearchCliID.Location = new System.Drawing.Point(148, 159);
            this.txtSearchCliID.Name = "txtSearchCliID";
            this.txtSearchCliID.Size = new System.Drawing.Size(130, 20);
            this.txtSearchCliID.TabIndex = 18;
            this.txtSearchCliID.TextChanged += new System.EventHandler(this.txtSearchCliID_TextChanged);
            // 
            // txtSearchCliName
            // 
            this.txtSearchCliName.Location = new System.Drawing.Point(420, 158);
            this.txtSearchCliName.Name = "txtSearchCliName";
            this.txtSearchCliName.Size = new System.Drawing.Size(130, 20);
            this.txtSearchCliName.TabIndex = 19;
            this.txtSearchCliName.TextChanged += new System.EventHandler(this.txtSearchCliName_TextChanged);
            // 
            // txtSearchRefID
            // 
            this.txtSearchRefID.Location = new System.Drawing.Point(148, 343);
            this.txtSearchRefID.Name = "txtSearchRefID";
            this.txtSearchRefID.Size = new System.Drawing.Size(130, 20);
            this.txtSearchRefID.TabIndex = 20;
            this.txtSearchRefID.TextChanged += new System.EventHandler(this.txtSearchRefID_TextChanged);
            // 
            // txtSearchRefName
            // 
            this.txtSearchRefName.Location = new System.Drawing.Point(420, 343);
            this.txtSearchRefName.Name = "txtSearchRefName";
            this.txtSearchRefName.Size = new System.Drawing.Size(130, 20);
            this.txtSearchRefName.TabIndex = 21;
            this.txtSearchRefName.TextChanged += new System.EventHandler(this.txtSearchRefName_TextChanged);
            // 
            // cbxClientID
            // 
            this.cbxClientID.FormattingEnabled = true;
            this.cbxClientID.Location = new System.Drawing.Point(81, 72);
            this.cbxClientID.Name = "cbxClientID";
            this.cbxClientID.Size = new System.Drawing.Size(161, 21);
            this.cbxClientID.TabIndex = 22;
            // 
            // cbxRefID
            // 
            this.cbxRefID.FormattingEnabled = true;
            this.cbxRefID.Location = new System.Drawing.Point(332, 72);
            this.cbxRefID.Name = "cbxRefID";
            this.cbxRefID.Size = new System.Drawing.Size(161, 21);
            this.cbxRefID.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(576, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "Find ClientID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(559, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "Find ReferralID";
            // 
            // txtFindCliID
            // 
            this.txtFindCliID.Location = new System.Drawing.Point(683, 44);
            this.txtFindCliID.Name = "txtFindCliID";
            this.txtFindCliID.Size = new System.Drawing.Size(100, 20);
            this.txtFindCliID.TabIndex = 27;
            this.txtFindCliID.TextChanged += new System.EventHandler(this.txtFindCliID_TextChanged);
            // 
            // txtFindRefID
            // 
            this.txtFindRefID.Location = new System.Drawing.Point(683, 98);
            this.txtFindRefID.Name = "txtFindRefID";
            this.txtFindRefID.Size = new System.Drawing.Size(100, 20);
            this.txtFindRefID.TabIndex = 28;
            this.txtFindRefID.TextChanged += new System.EventHandler(this.txtFindRefID_TextChanged);
            // 
            // Referral_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(1157, 535);
            this.Controls.Add(this.txtFindRefID);
            this.Controls.Add(this.txtFindCliID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxRefID);
            this.Controls.Add(this.cbxClientID);
            this.Controls.Add(this.txtSearchRefName);
            this.Controls.Add(this.txtSearchRefID);
            this.Controls.Add(this.txtSearchCliName);
            this.Controls.Add(this.txtSearchCliID);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvReferrals);
            this.Controls.Add(this.dgvClient);
            this.Controls.Add(this.dgvRefCli);
            this.Controls.Add(this.btnDelCliRef);
            this.Controls.Add(this.btnAddCliRef);
            this.Controls.Add(this.btnAdviceHome);
            this.Name = "Referral_Client";
            this.Text = "Referral_Client";
            this.Load += new System.EventHandler(this.Referral_Client_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRefCli)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReferrals)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdviceHome;
        private System.Windows.Forms.Button btnAddCliRef;
        private System.Windows.Forms.Button btnDelCliRef;
        private System.Windows.Forms.DataGridView dgvRefCli;
        private System.Windows.Forms.DataGridView dgvClient;
        private System.Windows.Forms.DataGridView dgvReferrals;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtSearchCliID;
        private System.Windows.Forms.TextBox txtSearchCliName;
        private System.Windows.Forms.TextBox txtSearchRefID;
        private System.Windows.Forms.TextBox txtSearchRefName;
        private System.Windows.Forms.ComboBox cbxClientID;
        private System.Windows.Forms.ComboBox cbxRefID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFindCliID;
        private System.Windows.Forms.TextBox txtFindRefID;
    }
}