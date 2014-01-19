using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _9_season_of_year
{
    public partial class frmSeason : Form
    {
        public frmSeason()
        {
            InitializeComponent();
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            if (dtpDate.Value.Month == 12  || dtpDate.Value.Month < 3)
            {
                lblSeason.Text = "Winter";
            }
            if (dtpDate.Value.Month >= 3 && dtpDate.Value.Month < 6)
            {
                lblSeason.Text = "Spring";
            }
            if (dtpDate.Value.Month >= 6 && dtpDate.Value.Month < 9)
            {
                lblSeason.Text = "Summer";
            }
            if (dtpDate.Value.Month >= 9 && dtpDate.Value.Month < 12)
            {
                lblSeason.Text = "Autumn";
            }
        }
    }
}
