using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _10_a_to_b
{
    public partial class frmSwitch : Form
    {
        public frmSwitch()
        {
            InitializeComponent();
        }

        private void txtContainer_TextChanged(object sender, EventArgs e)
        {
            if (txtContainer.Text.Contains("a"))
            {
                txtContainer.Text = txtContainer.Text.Replace("a", "b");
                txtContainer.SelectionStart = txtContainer.Text.Length;
            }
        }
    }
}
