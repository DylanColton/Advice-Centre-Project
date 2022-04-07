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
    public partial class frmRoomAppointments : Form
    {
        public frmRoomAppointments()
        {
            InitializeComponent();
            CenterToScreen();
        }

        DataSet Room;
        DataSet Report;

        private void btnBackToAdvice_Click(object sender, EventArgs e)
        {
            frmAdviceHome AdviceHome = new frmAdviceHome();
            AdviceHome.Show();
            AdviceHome.Activate();
            this.Hide();
        }

        private void frmRoomAppointments_Load(object sender, EventArgs e)
        {
            Room = DAL.AppointmentsDAL.PopulateRoomIDCombobox();
            cbxRoomID.DisplayMember = "RoomID";
            cbxRoomID.ValueMember = "RoomID";
            cbxRoomID.DataSource = Room.Tables[0];
            DateTime Today = dtpDate.Value;
            //DateTime Today = DateTime.Today;
            string btoday = Today.ToShortDateString();
            string today = Convert.ToDateTime(btoday).ToString("yyyy/MM/dd");
            int RoomID = Convert.ToInt16(cbxRoomID.Text);

            this.dataTable1TableAdapter.Fill(dataSet1.DataTable1, RoomID, today);
            this.dataTable1TableAdapter.GetData(RoomID, today);
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            DateTime Today = dtpDate.Value;
            //DateTime Today = DateTime.Today;
            string btoday = Today.ToShortDateString();
            string today = Convert.ToDateTime(btoday).ToString("yyyy/MM/dd");
            int RoomID = Convert.ToInt16(cbxRoomID.Text);

            this.dataTable1TableAdapter.Fill(dataSet1.DataTable1, RoomID, today);
            this.dataTable1TableAdapter.GetData(RoomID, today);
            this.reportViewer1.RefreshReport();
        }
    }
}
