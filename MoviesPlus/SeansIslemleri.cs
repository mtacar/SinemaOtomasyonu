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
    public partial class SeansIslemleri : Form
    {
        public SeansIslemleri()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=;Initial Catalog=SinemaOtomasyonu;Integrated Security=SSPI");
        SqlCommand cmd;
        SqlDataReader dr;
        SqlDataAdapter da;

        int id1;
        int id2;
        private void kayitGetirSeans()
        {
            //Dil DatagridWiewine Ver Çekme
            cmd = new SqlCommand();
            con.Open();
            cmd.CommandText = "select * from Zaman";
            cmd.Connection = con;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();


            //Dil DatagridWiewine Ver Çekme
        }
        private void SeansIslemleri_Load(object sender, EventArgs e)
        {
            kayitGetirSeans();


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

        //DATAGRİDVİEWDEN TIKLANAN KAYDIN ID Sİ ALINIYOR 
        //YİNE TIKLANAN KAYIT TEXTBOXLARA AKTARILIYOR
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            id1 = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //SEANS EKLEME İŞLEMLERİ
            try
            {
                if (textBox1.Text != "")
                {

                    cmd = new SqlCommand();
                    con.Open();
                    cmd.CommandText = "insert into Zaman (zamanAralik,saat) values (@ad,@saat)";
                    cmd.Connection = con;
                    cmd.Parameters.AddWithValue("@ad", textBox1.Text);
                    cmd.Parameters.AddWithValue("@saat", textBox2.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    kayitGetirSeans();
                    MessageBox.Show("Kayıt Eklendi..", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("İsim Girmediniz..", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //SEANS EKLEME İŞLEMLERİ
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
            //SEANS SİLME İŞLEMLERİ
            try
            {
                if (textBox1.Text != "")
                {
                    if (Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value) == id1)
                    {
                        cmd = new SqlCommand();
                        con.Open();
                        cmd.CommandText = "delete from Zaman where zaman_id='" + id1 + "'";
                        cmd.Connection = con;
                        cmd.ExecuteNonQuery();
                        con.Close();
                        kayitGetirSeans();
                        MessageBox.Show("Kayıt Silindi..", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Kayıt Silinemedi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                    MessageBox.Show("Silinecek Kaydı seçiniz..", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //SEANS SİLME İŞLEMLERİ
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
            //SEANS GÜNCELLEME İŞLEMLERİ
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
                        cmd.CommandText = "update Zaman set zamanAralik='" + textBox1.Text + "', saat='" + textBox2.Text + "' where zaman_id='" + id1 + "'";
                        cmd.Connection = con;
                        cmd.ExecuteNonQuery();
                        con.Close();
                        kayitGetirSeans();
                        MessageBox.Show("Kayıt Güncellendi..", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Güncellenecek Kaydı seçiniz..", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //SEANS GÜNCELLEME İŞLEMLERİ
                }
            }
            catch (Exception)
            {

                con.Close();
                MessageBox.Show("HATA", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            YoneticiIslemleri yi = new YoneticiIslemleri();
            yi.Show();
        }
    }
}
