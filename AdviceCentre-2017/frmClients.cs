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
    public partial class frmClients : Form
    {
        public frmClients()
        {
            InitializeComponent();
            CenterToScreen();
        }
            
        DataTable Clients;

        private void btnAdviceHome_Click(object sender, EventArgs e)
        {
            frmAdviceHome Home = new frmAdviceHome();
            Home.Activate();
            Home.Show();
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtPhoneNo.Text != "" && txtEmail.Text != "" && rtxtDescription.Text != "")
            {
                int RowsAffected = DAL.ClientDAL.AddNewClient(txtName.Text, rtxtDescription.Text, txtPhoneNo.Text, txtEmail.Text);
                if (RowsAffected == 1)
                {
                    MessageBox.Show("Client Added");
                    RefreshTable();
                }
                else
                {
                    MessageBox.Show("Client was unable to be added.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a name, description, phone number and email.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int RowsAffected = DAL.ClientDAL.DeleteClient(SelectedClientID);

            if (RowsAffected == 1)
            {
                MessageBox.Show("Client has been deleted");
                RefreshTable();
            }
            else
            {
                MessageBox.Show("The client was unable to be deleted.");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int rowsUpdated = DAL.ClientDAL.EditClient(SelectedClientID, txtName.Text, rtxtDescription.Text, txtPhoneNo.Text, txtEmail.Text);

            if (rowsUpdated == 1)
            {
                MessageBox.Show("Client's details have been updated.");
                RefreshTable();
            }
            else
            {
                MessageBox.Show("The details were not updated.");
            }
        }

        private void frmClients_Load(object sender, EventArgs e)
        {
            RefreshTable();
        }

        private void RefreshTable()
        {
            Clients = DAL.ClientDAL.SelectAllClients();
            this.dgvClients.DataSource = Clients;
        }

        int SelectedClientID;

        private void dgvClients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvClients.Rows[e.RowIndex];

                SelectedClientID = (int)row.Cells[0].Value;
                txtName.Text = row.Cells[1].Value.ToString();
                rtxtDescription.Text = row.Cells[2].Value.ToString();
                txtPhoneNo.Text = row.Cells[3].Value.ToString();
                txtEmail.Text = row.Cells[4].Value.ToString();
            }
        }

        private void txtClientName_TextChanged(object sender, EventArgs e)
        {
            dgvClients.DataSource = DAL.ClientDAL.SelectClientsByName(txtClientName.Text);
        }

        private void txtClientID_TextChanged(object sender, EventArgs e)
        {
            if (txtClientID.Text == string.Empty)
            {
                RefreshTable();
            }
            else
            {
                dgvClients.DataSource = DAL.ClientDAL.SelectClientsByID(Convert.ToInt32(txtClientID.Text));
            }
        }
    }
}
