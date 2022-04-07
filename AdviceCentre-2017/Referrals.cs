using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdviceCentre_2017
{
    public partial class Referrals : Form
    {
        public Referrals()
        {
            InitializeComponent();
            CenterToScreen();
        }

        DataTable References;

        private void btnAdviceHome_Click(object sender, EventArgs e)
        {
            frmAdviceHome ADHome = new frmAdviceHome();
            ADHome.Activate();
            ADHome.Show();
            this.Hide();
        }

        private void btnAddRef_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtPhoneNo.Text != "" && txtEmail.Text != "")
            {
                int RowsAffected = DAL.ReferralDAL.AddNewReferral(txtName.Text, txtPhoneNo.Text, txtEmail.Text);
                if (RowsAffected == 1)
                {
                    MessageBox.Show("Referral Added");
                    RefreshTable();
                }
                else
                {
                    MessageBox.Show("Referral was unable to be added.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a name, phone number and email.");
            }
        }

        private void btnEditRef_Click(object sender, EventArgs e)
        {
            int rowsUpdated = DAL.ReferralDAL.EditReferral(SelectedReferralID, txtName.Text, txtPhoneNo.Text, txtEmail.Text);

            if (rowsUpdated == 1)
            {
                MessageBox.Show("Referral's details have been updated.");
                RefreshTable();
            }
            else
            {
                MessageBox.Show("The details were not updated.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int RowsAffected = DAL.ReferralDAL.DeleteReferral(SelectedReferralID);

            if (RowsAffected == 1)
            {
                MessageBox.Show("Referral has been deleted");
                RefreshTable();
            }
            else
            {
                MessageBox.Show("The referral was unable to be deleted.");
            }
        }

        private void RefreshTable()
        {
            References = DAL.ReferralDAL.SelectAllReferrals();
            this.dgvReferral.DataSource = References;
        }

        private void Referrals_Load(object sender, EventArgs e)
        {
            RefreshTable();
        }

        private int SelectedReferralID;

        private void dgvReferral_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvReferral.Rows[e.RowIndex];

                SelectedReferralID = (int)row.Cells[0].Value;
                txtName.Text = row.Cells[1].Value.ToString();
                txtPhoneNo.Text = row.Cells[2].Value.ToString();
                txtEmail.Text = row.Cells[3].Value.ToString();
            }
        }

        private void txtFindRefID_TextChanged(object sender, EventArgs e)
        {
            if (txtFindRefID.Text == string.Empty)
            {
                RefreshTable();
            }
            else
            {
                dgvReferral.DataSource = DAL.ReferralDAL.SelectReferralsByID(Convert.ToInt32(txtFindRefID.Text));
            }
        }

        private void txtFindRefName_TextChanged(object sender, EventArgs e)
        {
            dgvReferral.DataSource = DAL.ReferralDAL.SelectReferralsByName(txtFindRefName.Text);
        }
    }
}
