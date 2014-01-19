using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _19_position_switcher
{
    public partial class frmPosSwitch : Form
    {
        public frmPosSwitch()
        {
            InitializeComponent();
        }

        private void frmPosSwitch_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random R = new Random();
            Random G = new Random();
            Random B = new Random();

            Random X = new Random();
            Random Y = new Random();

            this.BackColor = Color.FromArgb(R.Next(0, 256), G.Next(0, 256), B.Next(0, 256));
            this.Location = new Point(X.Next(0, 650), Y.Next(0, 500));
        }
    }
}
