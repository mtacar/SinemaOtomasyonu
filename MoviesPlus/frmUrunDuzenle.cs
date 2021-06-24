using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kafe_Restorant_Yonetim_Sistemi
{
    public partial class frmUrunDuzenle : Form
    {
        public frmUrunDuzenle()
        {
            InitializeComponent();
        }
        #region Degiskenler

        int urunNo = 0;
        object comboValue;

        #endregion

        public int seciliUrunNo;

        private void frmUrunDuzenle_Load(object sender, EventArgs e)
        {
            
            comboDoldur();
            DataTable urun = Veritabani.VeriGetir("select * from Urun where SilinmisMi=False");
            DataTable grup = Veritabani.VeriGetir("select * from UrunGrubu");
            for (int groupIndex = 0; groupIndex < grup.Rows.Count; ++groupIndex)
            {
                //grubları listviewe ekliyor
                this.listView1.Groups.Add(grup.Rows[groupIndex]["UrunGrupNo"].ToString(), grup.Rows[groupIndex]["Adi"].ToString());

                for (int urunIndex = 0; urunIndex < urun.Rows.Count; ++urunIndex)
                {
                    if (urun.Rows[urunIndex]["UrunGrupNo"].ToString() == grup.Rows[groupIndex]["UrunGrupNo"].ToString())
                    {


                        if (File.Exists(urun.Rows[urunIndex]["ResimYolu"].ToString()))//resimyolunda resim var mı diye kontrol ediyoruz
                        {
                            
                                Image myImage = Image.FromFile(urun.Rows[urunIndex]["ResimYolu"].ToString());//resimi alıyoruz
                                imageList1.Images.Add(urun.Rows[urunIndex]["UrunNo"].ToString(), myImage);//resmi imageliste ekliyoruz
                                ListViewItem item = new ListViewItem(urun.Rows[urunIndex]["Adi"].ToString(),
                                    urun.Rows[urunIndex]["UrunNo"].ToString(), this.listView1.Groups[groupIndex]);//Ürünü,resmi,grubu bağlıyoruz
                                this.listView1.Items.Insert(0, item);//ürünü ekliyor
                                // this.listView1.Groups[groupIndex].Items.Insert(0, item);//ürünü gruba ekliyor
                            

                        }
                        else //resimyolunda resim yoksa imagekey yinede ürünNo dan oluşturulur. imagekeyden de ürün bilgilerini çekeceğiz.
                        {

                            ListViewItem item = new ListViewItem(urun.Rows[urunIndex]["Adi"].ToString(), urun.Rows[urunIndex]["UrunNo"].ToString(),
                            this.listView1.Groups[groupIndex]);//Ürünü,resmi,grubu bağlıyoruz
                            this.listView1.Items.Insert(0, item);//ürünü ekliyor
                            //this.listView1.Groups[groupIndex].Items.Insert(0, item);//ürünü gruba ekliyor

                        }

                    }

                }
            }

            if (seciliUrunNo >0)
            {
                listView1.Items[seciliUrunNo - 1].Selected = true;
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            if (listView1.SelectedItems.Count > 0)
                urunNo = Convert.ToInt32(listView1.SelectedItems[0].ImageKey);

            DataTable urunDT = Veritabani.VeriGetir("select * from Urun where UrunNo=" + urunNo + "");
            txtUrunAdi.Text = urunDT.Rows[0]["Adi"].ToString();
            txtUrunFiyati.Text = urunDT.Rows[0]["Fiyati"].ToString();
            lblResimYolu.Text = urunDT.Rows[0]["ResimYolu"].ToString();

            comboUrunGrubu.SelectedValue = urunDT.Rows[0]["UrunGrupNo"];
            if (File.Exists(lblResimYolu.Text))//resimyolunda resim var mı diye kontrol ediyoruz
            {
                pictureBox1.Image = Image.FromFile(lblResimYolu.Text);
                pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            }
        }
        private void comboDoldur()
        {
            DataTable dt = Veritabani.VeriGetir("select * from UrunGrubu");
            comboUrunGrubu.DataSource = dt;
            comboUrunGrubu.DisplayMember = "Adi";
            comboUrunGrubu.ValueMember = "UrunGrupNo";
            comboValue = comboUrunGrubu.SelectedValue;
        }
        private void temizle()
        {
            txtUrunAdi.Clear();
            txtUrunFiyati.Clear();
            pictureBox1.Image = null;
            lblResimYolu.Text = "";
        }
        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            
            if (txtUrunAdi.Text == "" || txtUrunFiyati.Text == "" || lblResimYolu.Text == "" || comboUrunGrubu.Text == "")
            {

                if (txtUrunAdi.Text == "")
                {
                    MessageBox.Show("Boş Alan Bırakmayınız.");
                }
                if (txtUrunFiyati.Text == "")
                {
                    MessageBox.Show("Boş Alan Bırakmayınız.");
                }
                if (lblResimYolu.Text == "")
                {
                    MessageBox.Show("Lütfen Bir Resim Yolu Seçiniz.");
                }
                if (comboUrunGrubu.Text == "")
                {
                    MessageBox.Show("Lütfen Grup Seçiniz.");
                }
            }
            else
            {

                if (Urun.urunDuzenle(urunNo, lblResimYolu.Text, txtUrunFiyati.Text, comboValue, txtUrunAdi.Text))
                {
                    temizle();
                    lblBildirim.ForeColor = Color.Green;
                    lblBildirim.Text = "Ürün Başarıyla Düzenlendi.";
                }
                else
                {

                    temizle();
                    lblBildirim.ForeColor = Color.Red;
                    lblBildirim.Text = "Ürün Düzenlenirken Hata!";
                }




            }
            listView1.Items.Clear();
            frmUrunDuzenle_Load(null, null);
        }

        private void btnGozat_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Resimi Seçiniz";
            openFileDialog1.Filter = "Tümü|*.png;*.jpg;*ico;*.gif|png|*.png|jpeg|*.jpg|icon|*ico|gif|*.gif";
            openFileDialog1.DefaultExt = "jpg";
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.FileName = "";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    System.IO.File.Copy(@openFileDialog1.FileName, @"Web\resim\urunler\" + openFileDialog1.SafeFileName);
                    lblResimYolu.Text = @"Web\resim\urunler\" + openFileDialog1.SafeFileName;
                    pictureBox1.Image = Image.FromFile(lblResimYolu.Text);
                    pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                }
                catch 
                {
                    MessageBox.Show("Aynı ürün resmi mevcut");
                }
                
            }
        }

        private void comboUrunGrubu_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboValue = comboUrunGrubu.SelectedValue;
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

        private void btnUrunSil_Click(object sender, EventArgs e)
        {

            if (txtUrunAdi.Text == "" || txtUrunFiyati.Text == "" || lblResimYolu.Text == "" || comboUrunGrubu.Text == "" || urunNo == 0)
            {
                MessageBox.Show("Lütfen ürün seçiniz!","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                DialogResult sonuc = MessageBox.Show("Ürünü silmek istediğinizden emin misiniz?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (sonuc == DialogResult.Yes)
                {
                    Urun.urunDuzenle(urunNo, true);
                    temizle();
                    listView1.Items.Clear();
                    frmUrunDuzenle_Load(null, null);
                }
            }
                
           
        }
    }
}

