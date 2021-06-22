using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class SehirIslemleri : Form
    {
        public SehirIslemleri()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=;Initial Catalog=SinemaOtomasyonu;Integrated Security=SSPI");
        SqlCommand cmd;
        SqlDataReader dr;
        SqlDataAdapter da;


        int id1;
        int id2;
        private void kayitGetirSehir()
        {
            //Dil DatagridWiewine Ver Çekme
            cmd = new SqlCommand();
            con.Open();
            cmd.CommandText = "select * from Sehirler";
            cmd.Connection = con;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();


            //Dil DatagridWiewine Ver Çekme
        }

        //FORM YÜKLENDİĞİNDE ŞEHİRLER COMBOBAXA YÜKLENSİN
        private void SehirIslemleri_Load(object sender, EventArgs e)
        {
            kayitGetirSehir();


            DataGridViewColumn column;
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                column = dataGridView1.Columns[i];
                if (i == 0)
                {
                    column.Width = 35;
                }
                else
                    column.Width = 95;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //ŞEHİR EKLEME İŞLEMLERİ
                if (textBox1.Text != "")
                {

                    cmd = new SqlCommand();
                    con.Open();
                    cmd.CommandText = "insert into Sehirler(sehirAd) values (@ad)";
                    cmd.Connection = con;
                    cmd.Parameters.AddWithValue("@ad", textBox1.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    kayitGetirSehir();
                    MessageBox.Show("Kayıt Eklendi..", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("İsim Girmediniz..", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //ŞEHİR EKLEME İŞLEMLERİ
            }
            catch (Exception)
            {
                con.Close();
                MessageBox.Show("HATA", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                //ŞEHİR SİLME İŞLEMLERİ
                if (textBox1.Text != "")
                {
                    if (Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value) == id1)
                    {
                        cmd = new SqlCommand();
                        con.Open();
                        cmd.CommandText = "delete from Sehirler where sehir_id='" + id1 + "'";
                        cmd.Connection = con;
                        cmd.ExecuteNonQuery();
                        con.Close();
                        kayitGetirSehir();
                        MessageBox.Show("Kayıt Silindi..", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Kayıt Silinemedi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                    MessageBox.Show("Silinecek Kaydı seçiniz..", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //ŞEHİR SİLME İŞLEMLERİ
            }
            catch (Exception)
            {

                con.Close();
                MessageBox.Show("HATA", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //GÜNCELLEME İŞLEMLERİ
            try
            {
                if (id1 == 0 || id1 == -1)
                {
                    MessageBox.Show("Güncellenecek Kaydı Seçiniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (textBox1.Text != "")
                    {

                        cmd = new SqlCommand();
                        con.Open();
                        cmd.CommandText = "update Sehirler set sehirAd='" + textBox1.Text + "' where sehir_id='" + id1 + "'";
                        cmd.Connection = con;
                        cmd.ExecuteNonQuery();
                        con.Close();
                        kayitGetirSehir();
                        MessageBox.Show("Kayıt Güncellendi..", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Güncellenecek Kaydı seçiniz..", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

                //GÜNCELLEME İŞLEMLERİ
            }
            catch (Exception)
            {

                con.Close();
                MessageBox.Show("HATA", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
           
        }


        //DATAGRİDVİEWDEKİ TIKLANAN KAYDIN ID Sİ ALINIYOR
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            id1 = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
        }


        //ANASAYFAYA YÖNLENDİRİYOR
        private void button4_Click(object sender, EventArgs e)
        {
            YoneticiIslemleri yi = new YoneticiIslemleri();
            yi.Show();
        }
    }
}
