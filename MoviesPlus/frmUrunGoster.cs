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
    public partial class frmUrunGoster : Form
    {
        public frmUrunGoster()
        {
            InitializeComponent();
        }
        private void urunGoster()
        {
            DataTable UrunDT = Veritabani.VeriGetir("select * from Urun where SilinmisMi=False");
            DataTable urun = Veritabani.VeriGetir("select * from Urun");
            DataTable grup = Veritabani.VeriGetir("select * from UrunGrubu");
            for (int groupIndex = 0; groupIndex < grup.Rows.Count; ++groupIndex)
            {
                //grubları listviewe ekliyor
                this.lstUrun.Groups.Add(grup.Rows[groupIndex]["UrunGrupNo"].ToString(), grup.Rows[groupIndex]["Adi"].ToString());

                for (int urunIndex = 0; urunIndex < UrunDT.Rows.Count; ++urunIndex)
                {
                    if (UrunDT.Rows[urunIndex]["UrunGrupNo"].ToString() == grup.Rows[groupIndex]["UrunGrupNo"].ToString())
                    {


                        if (File.Exists(UrunDT.Rows[urunIndex]["ResimYolu"].ToString()))//resimyolunda resim var mı diye kontrol ediyoruz
                        {
                            Image myImage = Image.FromFile(UrunDT.Rows[urunIndex]["ResimYolu"].ToString());//resimi alıyoruz
                            imageList1.Images.Add(UrunDT.Rows[urunIndex]["UrunNo"].ToString(), myImage);//resmi imageliste ekliyoruz
                            ListViewItem item = new ListViewItem(UrunDT.Rows[urunIndex]["Adi"].ToString() + "\n" + UrunDT.Rows[urunIndex]["Fiyati"].ToString() + " ₺",
                                UrunDT.Rows[urunIndex]["UrunNo"].ToString(), this.lstUrun.Groups[groupIndex]);//Ürünü,resmi,grubu bağlıyoruz
                            this.lstUrun.Items.Insert(0, item);//ürünü ekliyor
                            this.lstUrun.Groups[groupIndex].Items.Insert(0, item);//ürünü gruba ekliyor
                        }
                        else //resimyolunda resim yoksa imagekey yinede ürünNo dan oluşturulur. imagekeyden de ürün bilgilerini çekeceğiz.
                        {
                            ListViewItem item = new ListViewItem(UrunDT.Rows[urunIndex]["Adi"].ToString(), UrunDT.Rows[urunIndex]["UrunNo"].ToString(),
                            this.lstUrun.Groups[groupIndex]);//Ürünü,resmi,grubu bağlıyoruz
                            this.lstUrun.Items.Insert(0, item);//ürünü ekliyor
                            this.lstUrun.Groups[groupIndex].Items.Insert(0, item);//ürünü gruba ekliyor
                        }

                    }

                }
            }
        }

        private void frmUrunGoster_Load(object sender, EventArgs e)
        {
           
           
            urunGoster();

        }

        private void ürünüDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUrunDuzenle frm = new frmUrunDuzenle();
            frm.seciliUrunNo = seciliUrunNo;
            frm.ShowDialog();
        }

        private void yeniÜrünEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUrunEkle frm = new frmUrunEkle();
            frm.ShowDialog();
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (lstUrun.FocusedItem.Bounds.Contains(e.Location) == true)
                {
                    contextMenuStrip1.Show(Cursor.Position);
                }
            } 
        }

        public int seciliUrunNo;
        private void lstUrun_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstUrun.SelectedItems.Count > 0)
            {
                seciliUrunNo = int.Parse(lstUrun.SelectedIndices[0].ToString()) + 1;
            }
          
        }
    }
}
