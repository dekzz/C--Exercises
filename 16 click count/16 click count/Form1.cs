using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _16_click_count
{
    public partial class frmCount : Form
    {
        int counter;
        public frmCount()
        {
            InitializeComponent();
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            counter++;
            lblClicks.Text = counter.ToString();
            if (counter%2 == 0)
            {
                lblClicks.ForeColor = Color.Red;
            }
            else
            {
                lblClicks.ForeColor = Color.Black;
            }
            if (counter > 10)
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }
    }
}
