using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _20_color_form
{
    public partial class frmColored : Form
    {
        public frmColored()
        {
            InitializeComponent();
        }

        private void tbR_Scroll(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(tbR.Value, tbG.Value, tbB.Value);
        }

        private void tbG_Scroll(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(tbR.Value, tbG.Value, tbB.Value);
        }

        private void tbB_Scroll(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(tbR.Value, tbG.Value, tbB.Value);
        }
    }
}
