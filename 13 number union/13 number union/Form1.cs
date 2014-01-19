using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _13_number_union
{
    public partial class frmNumUnion : Form
    {
        public frmNumUnion()
        {
            InitializeComponent();
        }

        private void btnUnion_Click(object sender, EventArgs e)
        {
            txtResult.Text = "";
            int[] x = txtFirst.Text.Split(',').Select(s => int.Parse(s)).ToArray();
            int[] y = txtSecond.Text.Split(',').Select(s => int.Parse(s)).ToArray();
            for (int i = 0; i < x.Length; i++)
            {
                for (int j = 0; j < y.Length; j++)
                {
                    if (x[i]==y[j])
                    {
                        txtResult.Text += x[i].ToString() + ", ";
                    }   
                }
            }
        }
    }
}
