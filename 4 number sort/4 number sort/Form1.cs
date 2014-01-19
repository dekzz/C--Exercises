using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _4_number_sort
{
    public partial class frmSort : Form
    {
        public frmSort()
        {
            InitializeComponent();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            Int32[] nr = txtNumbers.Text.Split(',').Select(s => Int32.Parse(s)).ToArray();
            Array.Sort(nr);
            string result = string.Join(", ", nr.Select(i => i.ToString()).ToArray());
            txtNumbers.Text = result;
        }
    }
}
