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
    public partial class frmSifreDegistir : Form
    {
        public frmSifreDegistir()
        {
            InitializeComponent();
        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            if (txtEskiSifre.Text == "" || txtYeniSifre.Text == "" || txtYeniSifre.Text == "")
            {
                errorProvider1.SetError(lblBildirim, "Lütfen boş alan bırakmayınız!");
            }
            else
            {
                if (!kontroller.kullaniciKontrolu(frmGiris.kulAdi, Islemler.MD5eDonustur(txtEskiSifre.Text)))
                {
                    MessageBox.Show("Şifreniz Yanlış!");
                }
                else
                {
                    if (txtYeniSifre.Text == txtYeniSifreTekrar.Text)
                    {
                        if (Kullanici.KullaniciSifreDegistir(frmGiris.kulAdi, Islemler.MD5eDonustur(txtYeniSifre.Text)))
                        {
                            lblBildirim.ForeColor = Color.Green;
                            lblBildirim.Text = "Şifre Değiştirildi.";

                            txtEskiSifre.Text = txtYeniSifre.Text = txtYeniSifreTekrar.Text = "";

                        }
                        else
                        {
                            lblBildirim.ForeColor = Color.Red;
                            lblBildirim.Text = "Şifre Değiştirilemedi!";
                        }
                    }
                    else
                    {
                        lblBildirim.ForeColor = Color.Red;
                        lblBildirim.Text = "Şifreler Uyumuşmuyor!";
                    }
                }
            }
        }

        private void frmSifreDegistir_Load(object sender, EventArgs e)
        {
            this.Text = frmGiris.kulAdi + " Şifresi Değiştiriliyor";
        }
    }
}
