namespace AdviceCentre_2017
{
    partial class frmHomeScreen
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnAdviceCentre = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AdviceCentre_2017.Properties.Resources.Woodside_Community_Hub_logo;
            this.pictureBox1.Location = new System.Drawing.Point(110, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(43, 153);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 50);
            this.button1.TabIndex = 1;
            this.button1.Text = "Créche";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(234, 153);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 50);
            this.button2.TabIndex = 2;
            this.button2.Text = "Transport Services";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(43, 226);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 50);
            this.button3.TabIndex = 3;
            this.button3.Text = "After School Club";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnAdviceCentre
            // 
            this.btnAdviceCentre.Location = new System.Drawing.Point(234, 226);
            this.btnAdviceCentre.Name = "btnAdviceCentre";
            this.btnAdviceCentre.Size = new System.Drawing.Size(100, 50);
            this.btnAdviceCentre.TabIndex = 4;
            this.btnAdviceCentre.Text = "Advice Centre";
            this.btnAdviceCentre.UseVisualStyleBackColor = true;
            this.btnAdviceCentre.Click += new System.EventHandler(this.btnAdviceCentre_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(43, 301);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 50);
            this.button5.TabIndex = 5;
            this.button5.Text = "Parenting Groups";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(234, 301);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(100, 50);
            this.button6.TabIndex = 6;
            this.button6.Text = "Classes";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // frmHomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnAdviceCentre);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmHomeScreen";
            this.Text = "Woodside Community Hub";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnAdviceCentre;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}

