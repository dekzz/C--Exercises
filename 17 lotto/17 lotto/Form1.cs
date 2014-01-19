using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _17_lotto
{
    public partial class frmLotto : Form
    {
        public frmLotto()
        {
            InitializeComponent();
        }

        private void btnRoll_Click(object sender, EventArgs e)
        {
            Random nr = new Random();
            List<int> numbers = new List<int>();
            int rand;

            do
            {
                rand = nr.Next(1, 40);
            } while (numbers.Contains(rand));
            numbers.Add(rand);
            int rand1 = rand;
            lblNr1.Text = rand1.ToString();
            if (rand1 < 20)
            {
                lblNr1.ForeColor = Color.Green;
            }
            else
            {
                lblNr1.ForeColor = Color.Red;
            }

            do
            {
                rand = nr.Next(1, 40);
            } while (numbers.Contains(rand));
            numbers.Add(rand);
            int rand2 = rand;
            lblNr2.Text = rand2.ToString();
            if (rand2 < 20)
            {
                lblNr2.ForeColor = Color.Green;
            }
            else
            {
                lblNr2.ForeColor = Color.Red;
            }

            do
            {
                rand = nr.Next(1, 40);
            } while (numbers.Contains(rand));
            numbers.Add(rand);
            int rand3 = rand;
            lblNr3.Text = rand3.ToString();
            if (rand3 < 20)
            {
                lblNr3.ForeColor = Color.Green;
            }
            else
            {
                lblNr3.ForeColor = Color.Red;
            }

            do
            {
                rand = nr.Next(1, 40);
            } while (numbers.Contains(rand));
            numbers.Add(rand);
            int rand4 = rand;
            lblNr4.Text = rand4.ToString();
            if (rand4 < 20)
            {
                lblNr4.ForeColor = Color.Green;
            }
            else
            {
                lblNr4.ForeColor = Color.Red;
            }

            do
            {
                rand = nr.Next(1, 40);
            } while (numbers.Contains(rand));
            numbers.Add(rand);
            int rand5 = rand;
            lblNr5.Text = rand5.ToString();
            if (rand5 < 20)
            {
                lblNr5.ForeColor = Color.Green;
            }
            else
            {
                lblNr5.ForeColor = Color.Red;
            }

            do
            {
                rand = nr.Next(1, 40);
            } while (numbers.Contains(rand));
            numbers.Add(rand);
            int rand6 = rand;
            lblNr6.Text = rand6.ToString();
            if (rand6 < 20)
            {
                lblNr6.ForeColor = Color.Green;
            }
            else
            {
                lblNr6.ForeColor = Color.Red;
            }

            do
            {
                rand = nr.Next(1, 40);
            } while (numbers.Contains(rand));
            numbers.Add(rand);
            int rand7 = rand;
            lblNr7.Text = rand7.ToString();
            if (rand7 < 20)
            {
                lblNr7.ForeColor = Color.Green;
            }
            else
            {
                lblNr7.ForeColor = Color.Red;
            }
        }
    }
}
