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
    public partial class frmAdviceHome : Form
    {
        public frmAdviceHome()
        {
            InitializeComponent();
            CenterToScreen();
            AnActualClock.Start();
            DateTime Today = DateTime.Now;
            string today = Convert.ToString(Today);
            btnDate.Text = today;
        }

        private void AnActualClock_Tick(object sender, EventArgs e)
        {
            DateTime Today = DateTime.Now;
            string today = Convert.ToString(Today);
            btnDate.Text = today;
        }

        private void btnHubHome_Click(object sender, EventArgs e)
        {
            frmHomeScreen frmHomeScreen = new frmHomeScreen();
            frmHomeScreen.Show();
            frmHomeScreen.Activate();
            this.Hide();
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            frmPreBooking frmPreBooking = new frmPreBooking();
            frmPreBooking.Show();
            frmPreBooking.Activate();
            this.Hide();
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            frmClients Clients = new frmClients();
            Clients.Activate();
            Clients.Show();
            this.Hide();
        }

        private void btnReferrals_Click(object sender, EventArgs e)
        {
            Referrals Referrals = new Referrals();
            Referrals.Activate();
            Referrals.Show();
            this.Hide();
        }

        private void btnRefCli_Click(object sender, EventArgs e)
        {
            Referral_Client RefCli = new Referral_Client();
            RefCli.Activate();
            RefCli.Show();
            this.Hide();
        }

        private void frmAdviceHome_Load(object sender, EventArgs e)
        {
            DataTable Appointments = DAL.AppointmentsDAL.SelectAllAppointments();
            dgvBackground.DataSource = Appointments;
            DataTable dt = new DataTable();
            dt.Columns.Add("Time Slot");
            DataRow dr1 = dt.NewRow();
            dr1["Time Slot"] = "10:00 - 10:30";
            dt.Rows.Add(dr1);
            DataRow dr2 = dt.NewRow();
            dr2["Time Slot"] = "10:30 - 11:00";
            dt.Rows.Add(dr2);
            DataRow dr3 = dt.NewRow();
            dr3["Time Slot"] = "11:00 - 11:30";
            dt.Rows.Add(dr3);
            DataRow dr4 = dt.NewRow();
            dr4["Time Slot"] = "11:30 - 12:00";
            dt.Rows.Add(dr4);
            DataRow dr5 = dt.NewRow();
            dr5["Time Slot"] = "12:00 - 12:30";
            dt.Rows.Add(dr5);
            DataRow dr6 = dt.NewRow();
            dr6["Time Slot"] = "12:30 - 13:00";
            dt.Rows.Add(dr6);
            DataRow dr7 = dt.NewRow();
            dr7["Time Slot"] = "13:00 - 13:30";
            dt.Rows.Add(dr7);
            DataRow dr8 = dt.NewRow();
            dr8["Time Slot"] = "13:30 - 14:00";
            dt.Rows.Add(dr8);
            DataRow dr9 = dt.NewRow();
            dr9["Time Slot"] = "14:00 - 14:30";
            dt.Rows.Add(dr9);
            DataRow dr10 = dt.NewRow();
            dr10["Time Slot"] = "14:30 - 15:00";
            dt.Rows.Add(dr10);
            DataRow dr11 = dt.NewRow();
            dr11["Time Slot"] = "15:00 - 15:30";
            dt.Rows.Add(dr11);
            DataRow dr12 = dt.NewRow();
            dr12["Time Slot"] = "15:30 - 16:00";
            dt.Rows.Add(dr12);

            DateTime today = DateTime.Today;
            int StaffID = 0;
            dt.Columns.Add("Staff 1");
            //StaffID = 1;
            //dgvBackground.DataSource = DAL.AppointmentsDAL.SelectStaffAppointments(today, StaffID);
            //DataTable data = DAL.AppointmentsDAL.SelectStaffAppointments(today, StaffID);
            //for (int i = 0; dgvBackground.Rows[i].Cells[0] != null; i++)
            //{
            //    if (dr1["Staff 1"] == "")
            //    {
            //        dr1["Staff 1"] = "Appointment Booked";
            //    }
            //    else if (dr1["Staff 1"] != string.Empty)
            //    {
            //        dr2["Staff 1"] = "Appointment Booked";
            //    }
            //    else if ((dr1["Staff 1"] != string.Empty) && (dr2["Staff 1"] != ""))
            //    {
            //        dr3["Staff 1"] = "Appointment Booked";
            //    }
            //    else if ((dr1["Staff 1"] != string.Empty) && (dr2["Staff 1"] != "") && (dr3["Staff 1"] != ""))
            //    {
            //        dr4["Staff 1"] = "Appointment Booked";
            //    }
            //    else if ((dr1["Staff 1"] != string.Empty) && (dr2["Staff 1"] != "") && (dr3["Staff 1"] != "") && (dr4["Staff 1"] != ""))
            //    {
            //        dr5["Staff 1"] = "Appointment Booked";
            //    }
            //}
            dt.Columns.Add("Staff 2");
            //StaffID = 2;
            //dgvBackground.DataSource = DAL.AppointmentsDAL.SelectStaffAppointments(today, StaffID);
            //if (dr1["Staff 2"] == "")
            //{
            //    dr1["Staff 2"] = "Appointment Booked";
            //}
            //else if (dr1["Staff 2"] != string.Empty)
            //{
            //    dr2["Staff 2"] = "Appointment Booked";
            //}
            //else if ((dr1["Staff 2"] != string.Empty) && (dr2["Staff 2"] != ""))
            //{
            //    dr3["Staff 2"] = "Appointment Booked";
            //}
            //else if ((dr1["Staff 2"] != string.Empty) && (dr2["Staff 2"] != "") && (dr3["Staff 2"] != ""))
            //{
            //    dr4["Staff 2"] = "Appointment Booked";
            //}
            //else if ((dr1["Staff 2"] != string.Empty) && (dr2["Staff 2"] != "") && (dr3["Staff 2"] != "") && (dr4["Staff 2"] != ""))
            //    {
            //    dr5["Staff 2"] = "Appointment Booked";
            //}
            dt.Columns.Add("Staff 3");
            //StaffID = 3;
            //dgvBackground.DataSource = DAL.AppointmentsDAL.SelectStaffAppointments(today, StaffID);
            //if (dr1["Staff 3"] == "")
            //{
            //    dr1["Staff 3"] = "Appointment Booked";
            //}
            //else if (dr1["Staff 3"] != string.Empty)
            //{
            //    dr2["Staff 3"] = "Appointment Booked";
            //}
            //else if ((dr1["Staff 3"] != string.Empty) && (dr2["Staff 3"] != ""))
            //{
            //    dr3["Staff 3"] = "Appointment Booked";
            //}
            //else if ((dr1["Staff 3"] != string.Empty) && (dr2["Staff 3"] != "") && (dr3["Staff 3"] != ""))
            //{
            //    dr4["Staff 3"] = "Appointment Booked";
            //}
            //else if ((dr1["Staff 3"] != string.Empty) && (dr2["Staff 3"] != "") && (dr3["Staff 3"] != "") && (dr4["Staff 3"] != ""))
            //    {
            //    dr5["Staff 3"] = "Appointment Booked";
            //}
            dt.Columns.Add("Staff 4");
            //StaffID = 4;
            //dgvBackground.DataSource = DAL.AppointmentsDAL.SelectStaffAppointments(today, StaffID);
            //if (dr1["Staff 4"] == "")
            //{
            //    dr1["Staff 4"] = "Appointment Booked";
            //}
            //else if (dr1["Staff 4"] != string.Empty)
            //{
            //    dr2["Staff 4"] = "Appointment Booked";
            //}
            //else if ((dr1["Staff 4"] != string.Empty) && (dr2["Staff 4"] != ""))
            //{
            //    dr3["Staff 4"] = "Appointment Booked";
            //}
            //else if ((dr1["Staff 4"] != string.Empty) && (dr2["Staff 4"] != "") && (dr3["Staff 4"] != ""))
            //{
            //    dr4["Staff 4"] = "Appointment Booked";
            //}
            //else if ((dr1["Staff 4"] != string.Empty) && (dr2["Staff 4"] != "") && (dr3["Staff 4"] != "") && (dr4["Staff 4"] != ""))
            //    {
            //    dr5["Staff 4"] = "Appointment Booked";
            //}


            dgvTimetable.DataSource = dt;
        }

        private void btnAppReport_Click(object sender, EventArgs e)
        {
            frmRoomAppointments RoomApp = new frmRoomAppointments();
            RoomApp.Show();
            RoomApp.Activate();
            this.Hide();
        }
    }
}
