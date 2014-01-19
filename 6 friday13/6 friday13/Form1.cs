using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

namespace _6_friday13
{
    public partial class frmFriday : Form
    {
        public frmFriday()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int year = Convert.ToInt32(txtYear.Text);
            int count = 0;
            
            Calendar cal = new GregorianCalendar();

            for (int i = 1; i < 13; i++)
			{
                DateTime day = new DateTime(year, i, 13, cal);

                if (day.DayOfWeek.Equals(DayOfWeek.Friday))
	            {
		            count++;
	            }
			}
            txtYear.Text = count + " Friday the 13th";
        }
    }
}
