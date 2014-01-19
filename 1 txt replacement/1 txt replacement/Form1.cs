using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _1_txt_replacement
{
    public partial class frmTxtReplace : Form
    {
        public frmTxtReplace()
        {
            InitializeComponent();
        }

        private void txtFinal_TextChanged(object sender, EventArgs e)
        {
            string tekst = txtFinal.Text.ToString();
            if (tekst.Contains(txtA.Text))
            {
                tekst = tekst.Replace(txtA.Text, txtB.Text);
                txtFinal.Text = tekst;
            }
        }
    }
}
