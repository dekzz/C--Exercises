using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _21_mouse_coordinates
{
    public partial class frmMouseCoord : Form
    {
        public frmMouseCoord()
        {
            InitializeComponent();
        }

        private void frmMouseCoord_MouseMove(object sender, MouseEventArgs e)
        {
            //lblCoord.Text = Cursor.Position.X.ToString() + "," + Cursor.Position.Y.ToString();
            lblCoord.Text = e.X.ToString() + "," + e.Y.ToString();
        }
    }
}
