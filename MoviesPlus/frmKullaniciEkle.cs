using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kafe_Restorant_Yonetim_Sistemi
{
    public partial class frmKullaniciEkle : Form
    {
        public frmKullaniciEkle()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtKulAdi.Text == "" || txtSifre.Text == "" || txtAdi.Text == "" || txtSoyadi.Text == "")
            {
                MessageBox.Show("Lütfen boş alan bırakmayınız!");
            }
            else
            {
                if (kontroller.veriVarmi("select KullaniciAdi from Kullanici where KullaniciAdi='"+txtKulAdi.Text+"'"))
                {
                    lblBildirim.ForeColor = Color.Red;
                    lblBildirim.Text = "Böyle bir kullanıcı var!.";
                }
                else
                {
                    if (Kullanici.KullaniciEkle(txtKulAdi.Text, Islemler.MD5eDonustur(txtSifre.Text), txtAdi.Text, txtSoyadi.Text))
                    {
                        lblBildirim.ForeColor = Color.Green;
                        lblBildirim.Text = "Başarıyla kullanıcı eklenmiştir.";
                        txtAdi.Text = "";
                        txtKulAdi.Text = "";
                        txtSifre.Text = "";
                        txtSoyadi.Text = "";
                    }
                    else
                    {
                        lblBildirim.ForeColor = Color.Red;
                        lblBildirim.Text = "Kullanıcı eklenemedi!.";
                    }
                }
                
            }
            
        }

        private void frmKullaniciEkle_Load(object sender, EventArgs e)
        {
           
        }
    }
}
