using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _18_month_calendar
{
    public partial class frmMonthCal : Form
    {
        public frmMonthCal()
        {
            InitializeComponent();
        }

        private void frmMonthCal_Load(object sender, EventArgs e)
        {
            for (int i = 1; i < 13; i++)
            {
                cmbMonth.Items.Add(i);
            }
        }

        private void cmbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            monthCalendar.SelectionStart = new DateTime(DateTime.Now.Year, Convert.ToInt32(cmbMonth.SelectedItem), DateTime.Now.Day);
        }
    }
}
