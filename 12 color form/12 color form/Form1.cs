using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _12_color_form
{
    public partial class frmColor : Form
    {
        int counter = 0;
        public frmColor()
        {
            InitializeComponent();
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            counter++;
            btnCount.Text = counter.ToString();
            if (counter%10 == 0)
            {
                this.BackColor = Color.Red;
            }
            else
            {
                this.BackColor = Color.Green;
            }
        }
    }
}
