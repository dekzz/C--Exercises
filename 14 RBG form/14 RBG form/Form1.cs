using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _14_RBG_form
{
    public partial class frmRBG : Form
    {
        public frmRBG()
        {
            InitializeComponent();
        }

        private void txtR_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtR.Text) < 0 || Convert.ToInt32(txtR.Text) > 255)
            {
                txtR.Text = "";
                MessageBox.Show("0-255");
            }
        }

        private void txtB_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtB.Text) < 0 || Convert.ToInt32(txtB.Text) > 255)
            {
                txtR.Text = "";
                MessageBox.Show("0-255");
            }
        }

        private void txtG_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtG.Text) < 0 || Convert.ToInt32(txtG.Text) > 255)
            {
                txtR.Text = "";
                MessageBox.Show("0-255");
            }
        }

        private void btnClorize_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(Convert.ToInt32(txtR.Text), Convert.ToInt32(txtG.Text), Convert.ToInt32(txtB.Text));
        }
    }
}
