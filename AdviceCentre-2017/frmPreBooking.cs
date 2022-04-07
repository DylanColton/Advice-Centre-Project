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
    public partial class frmPreBooking : Form
    {
        public frmPreBooking()
        {
            InitializeComponent();
            CenterToScreen();
        }

        DataSet Client;
        DataSet Staff;
        DataSet Advice;
        DataSet Room;
        DataTable Appointments;
        int SelectedAppointmentID;
        DataTable AvailableApp;

        private void PopulateCombo()
        {
            Client = DAL.AppointmentsDAL.PopulateClientIDCombobox();
            for (int i = 0; i < Client.Tables[0].Rows.Count; i++)
            {
                cbxClient.Items.Add(Client.Tables[0].Rows[i][0] + " " + Client.Tables[0].Rows[i][1]);
            }

            Staff = DAL.AppointmentsDAL.PopulateStaffIDCombobox();
            for (int i = 0; i < Staff.Tables[0].Rows.Count; i++)
            {
                cbxStaff.Items.Add(Staff.Tables[0].Rows[i][0] + " " + Staff.Tables[0].Rows[i][1]);
            }

            Room = DAL.AppointmentsDAL.PopulateRoomIDCombobox();
            cbxRoom.DisplayMember = "RoomID";
            cbxRoom.ValueMember = "RoomID";
            cbxRoom.DataSource = Room.Tables[0];

            Advice = DAL.AppointmentsDAL.PopulateAdviceIDCombobox();
            for (int i = 0; i < Advice.Tables[0].Rows.Count; i++)
            {
                cbxAdvice.Items.Add(Advice.Tables[0].Rows[i][0] + " " + Advice.Tables[0].Rows[i][1]);
            }
        }

        private void btnAdviceHome_Click(object sender, EventArgs e)
        {
            frmAdviceHome frmAdviceHome = new frmAdviceHome();
            frmAdviceHome.Show();
            frmAdviceHome.Activate();
            this.Hide();
        }

        private void btnTomor_Click(object sender, EventArgs e)
        {
            //day++;
        }

        private void btnYester_Click(object sender, EventArgs e)
        {
            //day--;
        }

        private void btnDate_Click(object sender, EventArgs e)
        {
            // DateTime today = Convert.ToDateTime(day);
            //btnDate.Text = Convert.ToString(day);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cbxAdvice.Text != "" && cbxClient.Text != "" && cbxRoom.Text != "" && cbxStaff.Text != "" && dtpAppDate.Text != "")
            {
                string Date = dtpAppDate.Value.ToShortDateString();
                txtDateTime.Text = Date;
                DateTime AppDate = Convert.ToDateTime(txtDateTime.Text);
                string[] SelectedClient = cbxClient.SelectedItem.ToString().Split();
                int ClientID = Convert.ToInt32(SelectedClient[0]);
                string[] SelectedStaff = cbxStaff.SelectedItem.ToString().Split();
                int StaffID = Convert.ToInt32(SelectedStaff[0]);
                string[] SelectedAdvice = cbxAdvice.SelectedItem.ToString().Split();
                int AdviceID = Convert.ToInt32(SelectedAdvice[0]);
                string Room = cbxRoom.Text;
                int RoomID = Convert.ToInt32(Room);
                int RowsAffected = DAL.AppointmentsDAL.AddNewAppointment(AppDate, ClientID, StaffID, RoomID, AdviceID);

                if (RowsAffected == 1)
                {
                    MessageBox.Show("Appointment Added");
                    RefreshTable();
                }
                else
                {
                    MessageBox.Show("Appointment was unable to be added.");
                }
            }
            else
            {
                MessageBox.Show("Enter all details for the appointment");
            }

            btnCheckAvailibility.Visible = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DateTime AppDate = Convert.ToDateTime(dtpAppDate.Value);
            AppDate.ToShortDateString();
            string[] SelectedClient = cbxClient.SelectedItem.ToString().Split();
            int ClientID = Convert.ToInt32(SelectedClient[0]);
            string[] SelectedStaff = cbxStaff.SelectedItem.ToString().Split();
            int StaffID = Convert.ToInt32(SelectedStaff[0]);
            string[] SelectedAdvice = cbxAdvice.SelectedItem.ToString().Split();
            int AdviceID = Convert.ToInt32(SelectedAdvice[0]);
            int RoomID = Convert.ToInt32(cbxRoom.Text);
            int rowsUpdated = DAL.AppointmentsDAL.EditAppointment(SelectedAppointmentID, AppDate, ClientID, StaffID, AdviceID, RoomID);

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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int RowsAffected = DAL.AppointmentsDAL.DeleteAppointment(SelectedAppointmentID);

            if (RowsAffected == 1)
            {
                MessageBox.Show("Appointment has been deleted");
                RefreshTable();
            }
            else
            {
                MessageBox.Show("The appointment was unable to be deleted.");
            }
        }

        private void frmPreBooking_Load(object sender, EventArgs e)
        {
            PopulateCombo();
            RefreshTable();
        }

        private void RefreshTable()
        {
            Appointments = DAL.AppointmentsDAL.SelectAllAppointments();
            this.dgvAppointment.DataSource = Appointments;
        }

        private void dgvAppointment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvAppointment.Rows[e.RowIndex];

                SelectedAppointmentID = (int)row.Cells[0].Value;
                dtpAppDate.Value = Convert.ToDateTime(row.Cells[1].Value.ToString());
                txtDateTime.Text = row.Cells[1].Value.ToString();

                dgvCheckAvailable.DataSource = DAL.AppointmentsDAL.SelectCertainClients(Convert.ToInt16(row.Cells[2].Value));
                string CliID = Convert.ToString(dgvCheckAvailable.Rows[0].Cells[0].Value);
                string CliName = Convert.ToString(dgvCheckAvailable.Rows[0].Cells[1].Value);
                cbxClient.Text = CliID + " " + CliName;

                dgvCheckAvailable.DataSource = DAL.AppointmentsDAL.SelectCertainStaff(Convert.ToInt16(row.Cells[3].Value));
                string StaID = Convert.ToString(dgvCheckAvailable.Rows[0].Cells[0].Value);
                string StaName = Convert.ToString(dgvCheckAvailable.Rows[0].Cells[1].Value);
                cbxStaff.Text = StaID + " " + StaName;

                dgvCheckAvailable.DataSource = DAL.AppointmentsDAL.SelectCertainAdvice(Convert.ToInt16(row.Cells[4].Value));
                string AdvID = Convert.ToString(dgvCheckAvailable.Rows[0].Cells[0].Value);
                string AdvType = Convert.ToString(dgvCheckAvailable.Rows[0].Cells[1].Value);
                cbxAdvice.Text = AdvID + " " + AdvType;

                cbxRoom.Text = row.Cells[5].Value.ToString();
            }
        }

        private void btnCheckAvailibility_Click(object sender, EventArgs e)
        {
            string Date = dtpAppDate.Value.ToShortDateString();
            txtDateTime.Text = Date;
            DateTime AppDate = Convert.ToDateTime(txtDateTime.Text);
            string[] SelectedStaff = cbxStaff.SelectedItem.ToString().Split();
            int StaffID = Convert.ToInt32(SelectedStaff[0]);
            int RoomID = Convert.ToInt32(cbxRoom.Text);
            AvailableApp = DAL.AppointmentsDAL.SelectAppointmentbyCriteria(AppDate, RoomID, StaffID);
            this.dgvCheckAvailable.DataSource = AvailableApp;

            DataGridViewRow dgRow = dgvCheckAvailable.Rows[1];
            var cell = dgRow.Cells[0].Value;
            if (cell != null)   //Check for null reference
            {
                MessageBox.Show("appointments available");
                btnCheckAvailibility.Visible = false;
            }
            else
            {
                MessageBox.Show("No appointments available, choose a new date.  If the priority is 3, override a booking");
            }
        }

        private void btnSearchByClient_Click(object sender, EventArgs e)
        {
            if (cbxClient.Text == string.Empty)
            {
                RefreshTable();
            }
            else
            {
                string[] SelectedClient = cbxClient.SelectedItem.ToString().Split();
                int ClientID = Convert.ToInt32(SelectedClient[0]);
                dgvAppointment.DataSource = DAL.AppointmentsDAL.SelectAppointmentbyClient(ClientID);
            }
        }

        private void btnSearchByStaff_Click(object sender, EventArgs e)
        {
            if (cbxStaff.Text == string.Empty)
            {
                RefreshTable();
            }
            else
            {
                string[] SelectedStaff = cbxStaff.SelectedItem.ToString().Split();
                int StaffID = Convert.ToInt32(SelectedStaff[0]);
                dgvAppointment.DataSource = DAL.AppointmentsDAL.SelectAppointmentbyStaff(StaffID);
            }
        }

        private void btnSearchByDate_Click(object sender, EventArgs e)
        {
            DateTime Date = dtpAppDate.Value;
            txtDateTime.Text = Date.ToShortDateString();
            Date = Convert.ToDateTime(txtDateTime.Text);

            if (txtDateTime.Text == string.Empty)
            {
                RefreshTable();
            }
            else
            {
                dgvAppointment.DataSource = DAL.AppointmentsDAL.SelectAppointmentbyDate(Date);
            }
        }

        private void dtpAppDate_ValueChanged(object sender, EventArgs e)
        {
            txtDateTime.Text = dtpAppDate.Value.ToShortDateString();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            RefreshTable();
        }
    }
}
