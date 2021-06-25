using System;
using System.Collections;
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
    public partial class frmSatislar : Form
    {
        public frmSatislar()
        {
            InitializeComponent();
        }

        

        private void frmSatislar_Load(object sender, EventArgs e)
        {
            gridSatislar.DataSource = Veritabani.VeriGetir("select * from Satislar");
            gridSatislar.Columns[4].Visible = false;
            gridSatislar.Columns[5].Visible =false;

            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy/MM/dd HH:mm";

            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "yyyy/MM/dd HH:mm";

            dateTimePicker1.Value = DateTime.Now.AddDays(-1);
            dateTimePicker2.Value = DateTime.Now;

            dateTimePicker1_ValueChanged(null, null);
        }


        private void txtMasaNo_TextChanged(object sender, EventArgs e)
        {
            dateTimePicker1_ValueChanged(null, null);
        }

    

        private void txtMasaNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            kontroller.txtSayiKontrol(e);
        }
        private void gridSatislar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            gridSatisDetayUrun.DataSource = Veritabani.VeriGetir("select * from SatisDetayUrun where SiparisNo = " + gridSatislar.SelectedRows[0].Cells[5].Value + "");
            

            gridSatisDetayUrun.Columns[0].Visible = false;
            gridSatisDetayUrun.Columns[1].Visible = false;

          
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (txtMasaNo.Text == "")
            {
                DataTable dt = Veritabani.VeriGetir("select * from Satislar where Tarih >= #" + dateTimePicker1.Text + "# and Tarih <= #" + dateTimePicker2.Text + "#  ");
                gridSatislar.DataSource = dt;
            }
            else
            {
                DataTable dt = Veritabani.VeriGetir("select * from Satislar where [Masa Numarası] = " + txtMasaNo.Text + " and Tarih >= #" + dateTimePicker1.Text + "# and Tarih <= #" + dateTimePicker2.Text + "#  ");
                gridSatislar.DataSource = dt;
            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1_ValueChanged(null, null);
        }

        private void gridSatislar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       
    }
}
