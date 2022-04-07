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
    public partial class Referral_Client : Form
    {
        public Referral_Client()
        {
            InitializeComponent();
            CenterToScreen();
        }

        DataTable RefCli;
        DataTable Clients;
        DataTable Referrals;
        DataSet Client;
        DataSet Referral;

        private void btnAdviceHome_Click(object sender, EventArgs e)
        {
            frmAdviceHome ADHome = new frmAdviceHome();
            ADHome.Activate();
            ADHome.Show();
            this.Hide();
        }

        private void RefreshTables()
        {
            RefCli = DAL.ClientReferralDAL.SelectAllClientReferrals();
            this.dgvRefCli.DataSource = RefCli;
            Clients = DAL.ClientDAL.SelectAllClients();
            this.dgvClient.DataSource = Clients;
            Referrals = DAL.ReferralDAL.SelectAllReferrals();
            this.dgvReferrals.DataSource = Referrals;
        }

        private void PopulateComboBoxes()
        {
            Client = DAL.AppointmentsDAL.PopulateClientIDCombobox();
            for (int i = 0; i < Client.Tables[0].Rows.Count; i++)
            {
                cbxClientID.Items.Add(Client.Tables[0].Rows[i][0] + " " + Client.Tables[0].Rows[i][1]);
            }
            Referral = DAL.ReferralDAL.PopulateReferralIDCombobox();
            for (int i = 0; i < Referral.Tables[0].Rows.Count; i++)
            {
                cbxRefID.Items.Add(Referral.Tables[0].Rows[i][0] + " " + Referral.Tables[0].Rows[i][1]);
            }
        }

        private void Referral_Client_Load(object sender, EventArgs e)
        {
            RefreshTables();
            PopulateComboBoxes();
        }

        private void btnAddCliRef_Click(object sender, EventArgs e)
        {
            if (cbxClientID.Text != "" || cbxRefID.Text != "")
            {
                string[] SelectedClient = cbxClientID.SelectedItem.ToString().Split();
                int ClientID = Convert.ToInt32(SelectedClient[0]);
                string[] SelectedReferral = cbxRefID.SelectedItem.ToString().Split();
                int ReferralID = Convert.ToInt32(SelectedReferral[0]);

                int RowsAffected = DAL.ClientReferralDAL.AddNewClientReferral(ClientID, ReferralID);
                if (RowsAffected == 1)
                {
                    MessageBox.Show("Client reference Added");
                    RefreshTables();
                }
                else
                {
                    MessageBox.Show("Client reference was unable to be added.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a client ID and reference ID.");
            }
        }

        private void btnDelCliRef_Click(object sender, EventArgs e)
        {
            if (cbxClientID.Text != "" || cbxRefID.Text != "")
            {
                int ClientID = Convert.ToInt16(cbxClientID.Text);
                int ReferralID = Convert.ToInt16(cbxRefID.Text);
                int RowsAffected = DAL.ClientReferralDAL.DeleteClientReferral(ClientID, ReferralID);

                if (RowsAffected == 1)
                {
                    MessageBox.Show("Client reference has been deleted");
                    RefreshTables();
                }
                else
                {
                    MessageBox.Show("The client reference was unable to be deleted.");
                }
            }
            else
            {

            }
        }

        private void txtSearchCliID_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchCliID.Text == string.Empty)
            {
                RefreshTables();
            }
            else
            {
                dgvClient.DataSource = DAL.ClientDAL.SelectClientsByID(Convert.ToInt32(txtSearchCliID.Text));
            }
        }

        private void txtSearchCliName_TextChanged(object sender, EventArgs e)
        {
            dgvClient.DataSource = DAL.ClientDAL.SelectClientsByName(txtSearchCliName.Text);
        }

        private void txtSearchRefID_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchRefID.Text == string.Empty)
            {
                RefreshTables();
            }
            else
            {
                dgvReferrals.DataSource = DAL.ReferralDAL.SelectReferralsByID(Convert.ToInt32(txtSearchRefID.Text));
            }
        }

        private void txtSearchRefName_TextChanged(object sender, EventArgs e)
        {
            dgvReferrals.DataSource = DAL.ReferralDAL.SelectReferralsByName(txtSearchRefName.Text);
        }

        private void dgvRefCli_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvRefCli.Rows[e.RowIndex];
                
                cbxClientID.Text = row.Cells[0].Value.ToString();
                cbxRefID.Text = row.Cells[1].Value.ToString();
            }
        }

        private void txtFindCliID_TextChanged(object sender, EventArgs e)
        {
            if (txtFindCliID.Text == string.Empty)
            {
                RefreshTables();
            }
            else
            {
                dgvRefCli.DataSource = DAL.ClientReferralDAL.SelectClientReferralsFromClients(Convert.ToInt32(txtFindCliID.Text));
            }
        }

        private void txtFindRefID_TextChanged(object sender, EventArgs e)
        {
            if (txtFindRefID.Text == string.Empty)
            {
                RefreshTables();
            }
            else
            {
                dgvRefCli.DataSource = DAL.ClientReferralDAL.SelectClientReferralsFromReferrals(Convert.ToInt32(txtFindRefID.Text));
            }
        }
    }
}
