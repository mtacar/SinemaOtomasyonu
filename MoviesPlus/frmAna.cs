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
using System.Data.OleDb;



namespace Kafe_Restorant_Yonetim_Sistemi
{
    public partial class frmAna : Form
    {
        public frmAna()
        {
            InitializeComponent();
        }


        public static int MasaNumarasi;
        public static int masaSayisi;
        public static Boolean ayaraGit;
        int doluMasaSayisi = 0;
        public static frmAna anaFrm;





        private void frmAna_Load(object sender, EventArgs e)
        {

            anaFrm = this;

            DataTable dt = Veritabani.VeriGetir("select * from Ayar");

            DataTable masa = Veritabani.VeriGetir("select MasaSayisi from Ayar");
            for (int i = 0; i < int.Parse(masa.Rows[0]["MasaSayisi"].ToString()); i++)
            {

                if (kontroller.veriVarmi("select * from Siparis where MasaNo=" + (i + 1) + " AND Hesap=True"))
                {
                    lstMasa.Items.Add((i + 1) + ".Masa");
                    lstMasa.Items[i].ImageKey = "doluMasa.png";
                    doluMasaSayisi++;
                }
                else
                {
                    lstMasa.Items.Add((i + 1) + ".Masa");
                    lstMasa.Items[i].ImageKey = "bosMasa.png";
                }

            }
            masaSayisi = Convert.ToInt32(masa.Rows[0]["MasaSayisi"].ToString());


            //    frmGiris frmg = new frmGiris();
            //   frmg.ShowDialog();
        }



        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                MasaNumarasi = (int.Parse(lstMasa.SelectedIndices[0].ToString()) + 1);


                frmMasa frmMasa = new frmMasa();
                frmMasa.ShowDialog();
            }
            catch
            {

            }

        }

        private void ürünEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUrunEkle frmUrunEkle = new frmUrunEkle();
            frmUrunEkle.ShowDialog();
        }

        private void ürünDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUrunDuzenle frm = new frmUrunDuzenle();
            frm.ShowDialog();
        }

        private void ürünSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUrunGoster frmUrunGoster = new frmUrunGoster();
            frmUrunGoster.ShowDialog();
        }




        public void lstMasa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstMasa.SelectedItems.Count > 0)
            {
                int masaNo = Convert.ToInt32(lstMasa.SelectedItems[0].Text.Substring(0, lstMasa.SelectedItems[0].Text.IndexOf('.')));

            }


        }

        private void lstMasa_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (lstMasa.FocusedItem.Bounds.Contains(e.Location) == true)
                {
                    contextMenuStrip1.Show(Cursor.Position);
                }
            }
        }

        private void masayiKapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lstMasa.SelectedItems.Count > 0 && lstMasa.SelectedItems[0].ImageKey == "doluMasa.png")
            {
                int masaNo = Convert.ToInt32(lstMasa.SelectedItems[0].Text.Substring(0, lstMasa.SelectedItems[0].Text.IndexOf('.')));
                int siparisNo = Siparis.siparisNoGetir(masaNo);
                if (MessageBox.Show("Eğer masayı kapatırsanız hesap ödenmeden masa içerisindeki ürünler kaldırılacaktır." +
                    "\n(*Raporlarda kapatılan masaların bilgilerini göremezsiniz.)" +
                    "\nDevam etmek istiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    if (Siparis.siparisUrunTemizle(siparisNo))
                    {

                        if (Siparis.siparisTemizle(siparisNo))
                        {
                            lstMasa.SelectedItems[0].ImageKey = "bosMasa.png";
                            frmAna.anaFrm.lstMasa_SelectedIndexChanged(null, null);
                        }
                    }
                }
            }
        }
        private void satışlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSatislar frm = new frmSatislar();
            frm.ShowDialog();
        }       
        
              
        private void yeniKullanıcıOluşturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKullaniciEkle frm = new frmKullaniciEkle();
            frm.ShowDialog();
        }

        private void şifreDeğiştirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSifreDegistir frm = new frmSifreDegistir();
            frm.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void frmAna_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }

}
