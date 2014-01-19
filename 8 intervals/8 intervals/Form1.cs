using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _8_intervals
{
    public partial class frmInerval : Form
    {
        public frmInerval()
        {
            InitializeComponent();
        }

        private void btnMerge_Click(object sender, EventArgs e)
        {
            int lower = Math.Max(Convert.ToInt32(txtInterval1.Text), Convert.ToInt32(txtInterval3.Text));
            int upper = Math.Min(Convert.ToInt32(txtInterval2.Text), Convert.ToInt32(txtInterval4.Text));

            if (lower < upper)
            {
                string interval = "Union of intervals [" + txtInterval1.Text + ", " + txtInterval2.Text + "] and [" + txtInterval3.Text + ", " + txtInterval4.Text + "] is\n" + "[" + lower.ToString() + ", " + upper.ToString() + "]";
                MessageBox.Show(interval);
            }
            else
            {
                MessageBox.Show("There is no union of this two intervals");
            }
        }
    }
}
