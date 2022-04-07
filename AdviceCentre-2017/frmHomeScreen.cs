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
    public partial class frmHomeScreen : Form
    {
        public frmHomeScreen()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void btnAdviceCentre_Click(object sender, EventArgs e)
        {
            frmAdviceHome frmAdviceHome = new frmAdviceHome();
            frmAdviceHome.Show();
            frmAdviceHome.Activate();
            this.Hide();
        }
    }
}
