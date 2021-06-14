using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookMyshow
{
    public partial class Payment : Form

    {
        public static String Amt;
        public pwait p = new pwait();
        public Payment(String Amt)
        {
            InitializeComponent();
            amt.Text = Amt;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (ytxt.Text.Length == 4)
            {
                cvtxt.Focus();
            }
        }

        private void paybtn_Click(object sender, EventArgs e)
        {
            if (cardtxt.Text != String.Empty && nametxt.Text != String.Empty && mtxt.Text != String.Empty && ytxt.Text != String.Empty && cvtxt.Text != String.Empty && pwdtxt.Text != String.Empty)
            {
                p.Show();
                timer.Interval = 3000;
                timer.Tick += Timer_Tick;
                timer.Start();
            }
            else
                MessageBox.Show("Lütfen Tüm Alanları Doldurun.");
            
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            p.Close();
            this.DialogResult = DialogResult.OK;


        }

        private void crebtn_Click(object sender, EventArgs e)
        {
            debbtn.BackColor = Color.Black;
            crebtn.BackColor = Color.Navy;        }

        private void debbtn_Click(object sender, EventArgs e)
        {
            debbtn.BackColor = Color.Navy;
            crebtn.BackColor = Color.Black;

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cardtxt_TextChanged(object sender, EventArgs e)
        {
            if (cardtxt.Text.Length == 4)
            {
                cardtxt.Text = cardtxt.Text + " ";
                cardtxt.SelectionStart = 5;
            }
            else
            if (cardtxt.Text.Length == 9)
            {
                cardtxt.Text = cardtxt.Text + " ";
                cardtxt.SelectionStart = 10;
            }
            else
            if (cardtxt.Text.Length == 14)
            {
                cardtxt.Text = cardtxt.Text + " ";
                cardtxt.SelectionStart = 15;
            }
            else
            if (cardtxt.Text.Length ==19)
            {
                nametxt.Focus();
            }
        }

        private void mtxt_TextChanged(object sender, EventArgs e)
        {
            if (mtxt.Text.Length ==2)
            {
                ytxt.Focus();
            }
        }

        private void cvtxt_TextChanged(object sender, EventArgs e)
        {
            if (cvtxt.Text.Length == 3)
            {
                pwdtxt.Focus();
            }
        }

        private void paybox_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
