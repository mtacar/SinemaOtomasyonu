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
    public partial class frmUrunEkle : Form
    {
        public frmUrunEkle()
        {
            InitializeComponent();
        }


        private void btnGrupEkle_Click(object sender, EventArgs e)
        {
            frmUrunGrup frm = new frmUrunGrup();
            frm.ShowDialog();
        }
        object comboValue;
        private void comboDoldur()
        {
            DataTable dt = Veritabani.VeriGetir("select * from UrunGrubu");
            comboGrup.DataSource = dt;
            comboGrup.DisplayMember = "Adi";
            comboGrup.ValueMember = "UrunGrupNo";
            comboValue = comboGrup.SelectedValue;
        }

        private void frmUrunEkle_Load(object sender, EventArgs e)
        {
            
            comboDoldur();
            
        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
           
            if (txtUrunAdi.Text == "" || txtUrunFiyati.Text == "" || comboGrup.Text=="")
            {

                if (txtUrunAdi.Text == "")
                {
                    MessageBox.Show("Boş Geçmeyiniz.");
                }
                if (txtUrunFiyati.Text == "")
                {
                    MessageBox.Show("Boş Geçmeyiniz.");
                }
                if (comboGrup.Text=="")
                {
                    MessageBox.Show("Lütfen Grup Seçiniz.");
                }
            }
            else
            {
                if (kontroller.veriVarmi("select Adi from Urun where Adi='" + txtUrunAdi.Text + "'"))
                {
                    lblBildirim.Text = "Böyle bir ürün vardır.";
                }
                else
                {
                    if (lblGozat.Text=="")
                    {
                        MessageBox.Show("Resim ekleyiniz");
                    }
                    if (Urun.urunEkle(txtUrunAdi.Text, txtUrunFiyati.Text, comboValue, lblGozat.Text))
                    {
                        txtUrunAdi.Clear();
                        txtUrunFiyati.Clear();
                        comboGrup.SelectedIndex = 0;
                        pictureBox1.Image = null;
                        lblGozat.Text = "";
                        lblBildirim.ForeColor = Color.Green;
                        lblBildirim.Text = "Ürün Başarıyla Eklenmiştir.";
                    }
                    else
                    {
                        txtUrunAdi.Clear();
                        txtUrunFiyati.Clear();
                        comboGrup.SelectedIndex = 0;
                        pictureBox1.Image = null;
                        lblGozat.Text = "";
                        lblBildirim.ForeColor = Color.Red;
                        lblBildirim.Text = "Ürün Eklenirken Hata!";
                    }
                }
            }
           
        }

        private void frmUrunEkle_Resize(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void comboGrup_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboValue = comboGrup.SelectedValue;
        }

        private void comboGrup_Click(object sender, EventArgs e)
        {
            DataTable dt = Veritabani.VeriGetir("select * from UrunGrubu");
            comboGrup.DataSource = dt;
            comboGrup.DisplayMember = "Adi";
            comboGrup.ValueMember = "UrunGrupNo";
        }

        private void txtUrunFiyati_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtUrunFiyati.Text.IndexOf(',') != -1)
            {
                if (e.KeyChar == (char)44)
                {
                    e.Handled = true;
                }
            }
            kontroller.txtParaKontrol(e);
        }

        

        private void btnUrunGoster_Click(object sender, EventArgs e)
        {
            frmUrunGoster frm = new frmUrunGoster();
            frm.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
