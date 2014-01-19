using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _7_divider
{
    public partial class frmDivide : Form
    {
        public frmDivide()
        {
            InitializeComponent();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtB.Text) > 0)
            {
                decimal res = Convert.ToDecimal(txtA.Text) / Convert.ToDecimal(txtB.Text);
                txtResult.Text = res.ToString();
            }
            else
            {
                MessageBox.Show("Divider must be greater then 0");
            }
        }

        private void txtA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), "\\d+"))
            {
                e.Handled = true;
            }
        }

        private void txtB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), "\\d+"))
            {
                e.Handled = true;
            }
        }
    }
}
