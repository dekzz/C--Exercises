using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _11_picture_viewer
{
    public partial class frmPicView : Form
    {
        public frmPicView()
        {
            InitializeComponent();
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                picFrame.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }
    }
}
