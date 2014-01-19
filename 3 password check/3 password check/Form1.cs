using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace _3_password_check
{
    public partial class frmLog : Form
    {
        public frmLog()
        {
            InitializeComponent();
        }

        private void bntLog_Click(object sender, EventArgs e)
        {
            if (txtPass.Text == txtRePass.Text)
            {
                Regex rgx = new Regex(@"^.*(?=.{5,})(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[@#$%^&+=]).*$");
                if (rgx.IsMatch(txtPass.Text))
                {
                    MessageBox.Show("Login successfull!");
                }
                else
                {
                    MessageBox.Show("Password does not contain U/L case, number or special character!");
                }
            }
            else
            {
                MessageBox.Show("Passowrds do not match!");
            }
        }
    }
}
