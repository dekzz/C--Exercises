using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _15_apli_shutdown
{
    public partial class frmShutdown : Form
    {
        int sdTime;
        public frmShutdown()
        {
            InitializeComponent();
        }

        private void btnShutdown_Click(object sender, EventArgs e)
        {
            shutdownTimer.Interval = 1000;
            shutdownTimer.Start();
            sdTime = Convert.ToInt32(txtShutTime.Text);
            btnShutdown.Text = txtShutTime.Text;
        }

        private void shutdownTimer_Tick(object sender, EventArgs e)
        {
            sdTime = sdTime - 1;
            btnShutdown.Text = sdTime.ToString();
            if (sdTime == 0)
            {
                this.Close();
            }
        }
    }
}
