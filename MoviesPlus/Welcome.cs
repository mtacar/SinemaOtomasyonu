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
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void Welcome_Load(object sender, EventArgs e)
        {
            progressBar.Value = 0;
            timer.Interval = 50;
            timer.Enabled = true;
        }
  
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer_Tick_1(object sender, EventArgs e)
        {
            progressBar.Visible = true;
            progressBar.Increment(1);
            if (progressBar.Value <= 20)
            {
                label1.Text = "Başlatılıyor...........";

            }
            else if (progressBar.Value <= 30)
            {
                label1.Text = "Bileşenler Yükleniyor......";

            }
            else if (progressBar.Value <= 55)
            {
                label1.Text = "Arayüz Yükleniyor.......";

            }
            else if (progressBar.Value <= 80)
            {
                label1.Text = "Kullanıma Hazırlanıyor...";

            }
            else
            {
                if (progressBar.Value == 100)
                {

                    timer.Enabled = false;
                    progressBar.Visible = false;
                    this.DialogResult = DialogResult.OK;
                }

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void progressBar_Click(object sender, EventArgs e)
        {

        }
    }
}
