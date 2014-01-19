using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _5_countdown
{
    public partial class frmCountdown : Form
    {
        DateTime timeLeft;
        public frmCountdown()
        {
            InitializeComponent();
        }

        private void frmCountdown_Load(object sender, EventArgs e)
        {
            countdownTimer.Interval = 1000;
            countdownTimer.Start();
            timeLeft = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 20, 45, 0);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = timeLeft.Subtract(DateTime.Now).ToString();
        }
    }
}
