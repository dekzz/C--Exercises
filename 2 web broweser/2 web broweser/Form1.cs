using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _2_web_broweser
{
    public partial class frmBrowser : Form
    {
        public frmBrowser()
        {
            InitializeComponent();
        }

        private void btnGO_Click(object sender, EventArgs e)
        {
            browserWindow.Navigate(txtURL.Text);
        }

        private void browserWindow_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (this.browserWindow.ReadyState == WebBrowserReadyState.Complete)
            {
                this.BackColor = Color.Green;
            }
            else
            {
                this.BackColor = Color.Red;
            }
        }
    }
}
