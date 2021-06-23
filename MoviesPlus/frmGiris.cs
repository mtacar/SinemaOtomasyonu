using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// admin 
// 123
namespace Kafe_Restorant_Yonetim_Sistemi
{

    
    public partial class frmGiris : Form
    {
        public static bool durum;
        public static string kulAdi;
        public frmGiris()
        {
            InitializeComponent();
        }

        private void frmGiris_Resize(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void btnGiris_Click(object sender, EventArgs e)
        { 
            if (txtKullaniciAdi.Text=="")
            {
                MessageBox.Show("Alanları Boş Geçmeyiniz!");
            }
            else if (txtSifre.Text == "")
            {
                 MessageBox.Show("Şifreyi Boş Geçmeyiniz!");
            }
            else
            {
                if (kontroller.kullaniciKontrolu(txtKullaniciAdi.Text,Islemler.MD5eDonustur(txtSifre.Text)) == false)
                {
                    MessageBox.Show("Kullanıcı Adı veya Şifre Yanlış!");
                }
                else
                {
                    durum = true;
                    kulAdi = txtKullaniciAdi.Text;
                    //this.Close();
                     frmAna frmAna = new frmAna();
                     frmAna.ShowDialog();
                   
                }
            }
           
            
            
        }

        private void frmGiris_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!durum)
            {
                Application.Exit(); //prog durdurmak için
            }
        }

        private void frmGiris_Load(object sender, EventArgs e)
        {
         
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Application.Exit(); //prog durdurmak için
        }   
    }
}
