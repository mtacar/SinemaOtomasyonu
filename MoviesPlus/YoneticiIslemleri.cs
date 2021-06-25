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
    public partial class YoneticiIslemleri : Form
    {
        public YoneticiIslemleri()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=;Initial Catalog=SinemaOtomasyonu;Integrated Security=SSPI");
        SqlCommand cmd;
        SqlDataReader dr;
        SqlDataAdapter da;

        //Datagrid Tıklama ID leri
        int id;
        int id2;
        int id3;
        //Datagrid Tıklama ID leri



        int film;//Gösterim Tablosuna Fİlm Id Si Ekleme

        //Combo ID leri
        int sehirid;
        public int sinemaid;
        int filmid;//Film İşlemlerinde Seçilen Filmin Idsi buraya atanıyor
        int aktorid;
        int aktrisid;
        int seansid;
        int dilid;
        int filmyil;
        int salonid;
        int filminidisi;
        int filminidsi;// Salon İşlemlerinde Seçilen Filmin Id si buraya atanıyor
        int toplamSalon;//Sinemaya Eklenen Toplam Salon Sayısı
        int salonSayisi;//Sinema Tablosundaki Eklenen Salon Sayısı
        //Combo ID leri

        string filminAdi;//Salon İşlemlerinde Filmin Adını Bu stringe çekip Comboboxta Göstereceğiz


        private void YoneticiIslemleri_Load(object sender, EventArgs e)
        {
            //Comboboxlara Veri Çekme İşlemleri
           //this.FormBorderStyle = FormBorderStyle.FixedSingle;
            maskedTextBox1.Mask = "00.00.0000";
            KayitGetirCombo4();
            kayitGetirSalon();
            kayitGetirFilm();
            kayitGetir();
            
            textBox3.Hide();
            cmd = new SqlCommand();
            con.Open();
            cmd.CommandText = "select * from Sehirler";
            cmd.Connection = con;
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                comboBox1.Items.Add(dr["sehirAd"]);
                comboBox2.Items.Add(dr["sehirAd"]);
               
            }
            con.Close();


            //verileri DataGridwieve Getir
            kayitGetir();
            kayitGetirSalon();
            kayitGetirFilm();

            //Aktör Tablosunu Comboboxa Çekme
            con.Open();
            string aktor = "select * from Aktorler";
            cmd = new SqlCommand(aktor, con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox5.Items.Add(dr["aktorAdi"]);

            }
            con.Close();


            //Aktör Tablosunu Comboboxa Çekme







            //Aktris Tablosunu Comboboxa Çekme

            con.Open();
            string aktris = "select * from Aktrisler";
            cmd = new SqlCommand(aktris, con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox6.Items.Add(dr["aktrisAdi"]);
            }
            con.Close();

            //Aktris Tablosunu Comboboxa Çekme





            //Seans Tablosunu Comboboxa Çekme

            con.Open();
            string seans = "select * from Zaman";
            cmd = new SqlCommand(seans,con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox7.Items.Add(dr["zamanAralik"]);
            }
            con.Close();
            //Seans Tablosunu Comboboxa Çekme


            //Dil Tablosunu Çekme
            con.Open();
            string dil = "select * from Dil";
            cmd = new SqlCommand(dil, con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox8.Items.Add(dr["dil"]);
            }
            con.Close();

            //Dil Tablosunu Çekme


            //DATAGRID SÜTUN ALANLARI AYARLARI
            //DataGrid1 Ayarları 
            DataGridViewColumn column;
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                column = dataGridView1.Columns[i];

                column.Width = 55;
            }
            //DataGrid2 Ayarları
            DataGridViewColumn column1;

            for (int i = 0; i < dataGridView2.ColumnCount; i++)
            {
                column = dataGridView2.Columns[i];

                column.Width = 55;
            }
            //DataGrid3 Ayarları
            for (int i = 0; i < dataGridView3.ColumnCount; i++)
            {
                column = dataGridView3.Columns[i];
                if (i == 0 || i == 2 || i == 4 || i == 7 || i == 8)
                {
                    column.Width = 35;
                }
                else
                    column.Width = 75;
            }
            //DATAGRID SÜTUN ALANLARI AYARLARI

            //Comboboxlara Veri Çekme İşlemleri
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //SİNEMA EKLEME İŞLEMLERİ
            try
            {
                if (textBox1.Text == "" || textBox2.Text == "" || comboBox1.SelectedItem.ToString() == "")
                {
                    MessageBox.Show("Bütün Alanları Doldurun", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    cmd = new SqlCommand();
                    con.Open();
                    cmd.CommandText = "select * from Sehirler where sehirAd='" + comboBox1.SelectedItem + "'";
                    cmd.Connection = con;
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        id = Convert.ToInt32(dr["sehir_id"]);
                    }


                    //MessageBox.Show(id.ToString());
                    con.Close();
                    con.Open();
                    string kayit = "Insert into Sinema(sinemaAd,sinemaSalonSayisi,sehir_id) values(@ad,@salonSayisi,@id)";
                    cmd = new SqlCommand(kayit, con);
                    cmd.Parameters.AddWithValue("@ad", textBox1.Text);
                    cmd.Parameters.AddWithValue("@salonSayisi", Convert.ToInt32(textBox2.Text));
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Kayit Başarılı", "KAYIT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
                    kayitGetir();
                }
                //SİNEMA EKLEME İŞLEMLERİ
            }
            catch (Exception)
            {
                con.Close();
                MessageBox.Show("Kayıt Yapılamadı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }









        //**************************************************************KAYIT GETİR******************************************//


        private void FilmIdGetir()
        {
   
            con.Open();
            cmd = new SqlCommand();
            cmd.CommandText = "select * from Filmler where filmAdi='" + comboBox4.SelectedItem.ToString() + "' and filmYil='" + comboBox9.SelectedItem.ToString() + "' ";
            cmd.Connection = con;
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                filminidisi = Convert.ToInt32(dr["film_id"]);
            }
            con.Close();
           

        }

        private void KayitGetirCombo4()
        {
            comboBox4.Items.Clear();


            cmd = new SqlCommand();
            con.Open();
            cmd.CommandText = "select * from Filmler";
            cmd.Connection = con;
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                comboBox4.Items.Add(dr["filmAdi"]);
            }
            con.Close();
        }
        private void kayitGetirFilm()
        {
            //Film DatagridWiewine Ver Çekme
            cmd = new SqlCommand();
            con.Open();
            cmd.CommandText = "select f.film_id as 'id', f.filmAdi as 'Film Adı', f.filmYil as 'Yılı', f.filmYonetmen as 'Yönetmeni', f.filmSure as 'Süre', a.aktorAdi as 'Aktör Adı',ak.aktrisAdi as 'Aktiris Adı',z.zamanAralik as 'Seans',d.dil as 'Dil', g.gosterimTarih as 'Gösterim Tarihi' from Filmler f inner join Aktorler a on f.aktor_id=a.aktor_id  inner join Aktrisler ak on f.aktris_id=ak.aktiris_id inner join Dil d on f.dil_id=d.dil_id inner join Zaman z on f.zaman_id=z.zaman_id inner join Gosterim g on g.film_id=f.film_id";
            cmd.Connection = con;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView3.DataSource = dt;
            con.Close();


            //Film DatagridWiewine Ver Çekme
        }
        private void kayitGetirSalon()
        {
            con.Open();
            string kayit = "select Salonlar.salon_id as 'id', Salonlar.salonAdi as 'Salon',Salonlar.SalonKapasite as 'Kapasite',Sinema.sinemaAd as 'Sinema Adı',Salonlar.sesSistemi as 'Ses Sistemi', Filmler.filmAdi as 'Film' from Salonlar inner join Sinema on Sinema.sinema_id=Salonlar.sinema_id  inner join Filmler on Filmler.film_id=Salonlar.film_id";
            SqlCommand komut = new SqlCommand(kayit, con);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            con.Close();
        }
        private void kayitGetir()
        {
            con.Open();
            string kayit = "SELECT sinema_id as id, sinemaAd as ad,sinemaSalonSayisi as salon,Sehirler.sehirAd as sehirId from Sinema inner join Sehirler on Sinema.sehir_id=Sehirler.sehir_id ";
            
            SqlCommand komut = new SqlCommand(kayit, con);
            
            SqlDataAdapter da = new SqlDataAdapter(komut);
           
            DataTable dt = new DataTable();
            da.Fill(dt);
          
            dataGridView1.DataSource = dt;
            
            con.Close();
        }

        //**************************************************************KAYIT GETİR******************************************//

        private void SalonSayisiniGetir()
        {
            cmd = new SqlCommand();
            con.Open();
            cmd.CommandText = "select * from Sinema s inner join Sehirler se on se.sehir_id=s.sehir_id where se.sehir_id='"+sehirid+"' and s.sinema_id='"+sinemaid+"'";
            cmd.Connection = con;
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                salonSayisi = Convert.ToInt32(dr["sinemaSalonSayisi"]);

            }
            con.Close();
        }









     //*******************************************************************BUTON İŞLEMLERİ****************************************//
        private void button2_Click(object sender, EventArgs e)
        {
            //SİNEMA SİLME İŞLEMLERİ
            try
            {
                if (Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value) == id)
                {
                    con.Open();
                    cmd = new SqlCommand();
                    cmd.CommandText = "delete from Sinema where sinema_id='" + id + "'";
                    cmd.Connection = con;
                    cmd.ExecuteNonQuery();
                    con.Close();
                    kayitGetir();
                    MessageBox.Show("Kayıt Silindi..", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Kayıt Silinemedi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            //SİNEMA SİLME İŞLEMLERİ
            catch (Exception)
            {
                MessageBox.Show("Kayıt Silinemedi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
                return;
            }
        }


        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //SİNEMA GÜNCELLEME İŞLEMLERİ
            try
            {
                if (id == 0 || id == -1)
                {
                    MessageBox.Show("Güncellenecek Kaydı Seçiniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    cmd = new SqlCommand();
                    con.Open();
                    cmd.CommandText = "select * from Sehirler where sehirAd='" + comboBox1.SelectedItem + "'";
                    cmd.Connection = con;
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        sehirid = Convert.ToInt32(dr["sehir_id"]);
                    }

                    con.Close();
                    con.Open();
                    cmd = new SqlCommand();
                    cmd.CommandText = "update Sinema set sinemaAd='" + textBox1.Text + "', sinemaSalonSayisi='" + textBox2.Text + "', sehir_id='" + sehirid + "' where sinema_id='" + id + "'";
                    cmd.Connection = con;
                    cmd.ExecuteNonQuery();
                    con.Close();
                    kayitGetir();
                    MessageBox.Show("Kayıt Güncellendi..", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                //SİNEMA GÜNCELLEME İŞLEMLERİ
            }
            catch (Exception)
            {

                con.Close();
                MessageBox.Show("HATA", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                //SALON İŞLEMLERİ EKLEME
                if (comboBox2.SelectedItem.ToString() != "")
                {
                    if (comboBox3.SelectedItem.ToString() != "")
                    {
                        if (comboBox4.SelectedItem.ToString() != "")
                        {
                            //Film ID Çekme

                            con.Open();
                            cmd = new SqlCommand();
                            cmd.CommandText = "select * from Filmler where filmAdi='" + comboBox4.Text + "'";
                            cmd.Connection = con;
                            dr = cmd.ExecuteReader();
                            if (dr.Read())
                            {
                                filmid = Convert.ToInt32(dr["film_id"]);

                            }
                            con.Close();
                            //Film ID Çekme


                            //Sinema ID Çekme
                            con.Open();
                            cmd = new SqlCommand();
                            cmd.CommandText = "select * from Sinema inner join Sehirler on Sehirler.sehir_id=Sinema.sehir_id where Sinema.sinemaAd='" + comboBox3.SelectedItem.ToString() + "' and Sehirler.sehirAd='"+comboBox2.SelectedItem.ToString()+"'";
                            cmd.Connection = con;
                            dr = cmd.ExecuteReader();
                            if (dr.Read())
                            {
                                sinemaid = Convert.ToInt32(dr["sinema_id"]);

                            }
                            con.Close();
                            //Sinema ID Çekme

                            //Salon Id Çekme
                            con.Open();
                            cmd = new SqlCommand();
                            cmd.CommandText = "select * from Filmler where filmAdi='" + comboBox4.SelectedItem.ToString() + "' and filmYil='" + comboBox9.SelectedItem.ToString() + "' ";
                            cmd.Connection = con;
                            dr = cmd.ExecuteReader();
                            if (dr.Read())
                            {
                                salonid = Convert.ToInt32(dr["film_id"]);
                            }
                            con.Close();
                            //Salon Id Çekme

                            //İsmi Aynı Olan Filmlerden Seçileni Ekleme

                            con.Open();
                            cmd = new SqlCommand();
                            cmd.CommandText = "select * from Filmler where filmAdi='" + comboBox4.SelectedItem.ToString() + "' and filmYil='" + comboBox9.SelectedItem.ToString() + "' ";
                            cmd.Connection = con;
                            dr = cmd.ExecuteReader();
                            if (dr.Read())
                            {
                                filmid = Convert.ToInt32(dr["film_id"]);
                            }
                            con.Close();


                            //İsmi Aynı Olan Filmlerden Seçileni Ekleme

                            SalonSayisiniGetir();
                           

                            //Eklenebilecek Salon Sayısını Hesapla
                            con.Open();
                            cmd = new SqlCommand();
                            cmd.CommandText = "select COUNT(*) from Salonlar s inner join Sinema si on s.sinema_id=si.sinema_id inner join Sehirler se on se.sehir_id=si.sehir_id where se.sehir_id='"+sehirid+"' and si.sinema_id='"+sinemaid+"'";
                            cmd.Connection = con;
                            dr = cmd.ExecuteReader();
                            if (dr.Read())
                            {
                                toplamSalon = Convert.ToInt32(dr[""]);
                            }
                            con.Close();

                            //Eklenebilecek Salon Sayısını Hesapla



                            //SEçilen Sinemaya Eklenen Toplam Salon Sayısını Kontrol Etme
                            if (toplamSalon<=salonSayisi)
                            {
                                //Ekleme İşlemleri
                                con.Open();
                                string kayit = "Insert into Salonlar (salonAdi,SalonKapasite,sinema_id,film_id,sesSistemi) values (@salonad,@kapasite,@sinemaid,@filmid,@ses)";
                                cmd = new SqlCommand(kayit, con);
                                cmd.Parameters.AddWithValue("@salonad", textBox4.Text);
                                cmd.Parameters.AddWithValue("@kapasite", Convert.ToInt32(textBox5.Text));
                                cmd.Parameters.AddWithValue("@sinemaid", sinemaid);
                                cmd.Parameters.AddWithValue("@filmid", filmid);
                                cmd.Parameters.AddWithValue("@ses", comboBox10.SelectedItem.ToString());
                                cmd.ExecuteNonQuery();
                                kayit = "insert into Koltuklar (salon_id,koltukNo) values(@salonid,@koltukNo)";
                                cmd = new SqlCommand(kayit, con);
                                //cmd.Parameters.AddWithValue("@salonid", );
                                con.Close();
                                MessageBox.Show("Kayıt Eklendi..", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                kayitGetirSalon();

                                //Ekleme İşlemleri
                                label9.Text = (salonSayisi - toplamSalon).ToString();
                            }
                            else
                            {
                                MessageBox.Show("Seçilen Sinemaya Eklenebilecek Salon Maximum Sayıda!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                label9.Text = (salonSayisi - toplamSalon).ToString();
                            }
                            //SEçilen Sinemaya Eklenen Toplam Salon Sayısını Kontrol Etme


                        }
                        else
                            MessageBox.Show("Bir Salon Seçin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else
                        MessageBox.Show("Bir Sinema Seçin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("Bir Şehir Seçin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                con.Close();
                MessageBox.Show("HATA", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox3.Items.Clear();
            con.Open();
            string kayit = "select Sinema.sinemaAd from Sinema inner join Sehirler on Sehirler.sehir_id=Sinema.sehir_id where Sehirler.sehirAd='" + comboBox2.SelectedItem + "'";
            cmd = new SqlCommand(kayit, con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox3.Items.Add(dr["sinemaAd"]);
            }
            con.Close();



            //Seçilen Şehrin İd si bulunuyor
            con.Open();
            SqlDataReader dr1;
            string aktor = "select * from Sehirler where sehirAd='" + comboBox2.Text + "' ";
            cmd = new SqlCommand(aktor, con);
            dr1 = cmd.ExecuteReader();
            if (dr1.Read())
            {
                sehirid = Convert.ToInt32(dr1["sehir_id"]);
            }
            con.Close();

            //Seçilen Şehrin İd si bulunuyor


            comboBox2.BackColor = Color.White;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //SALON SİLME İŞLEMLERİ
            try
            {
                if (Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value) == id2)
                {
                    con.Open();
                    cmd = new SqlCommand();
                    cmd.CommandText = "delete from Salonlar where salon_id='" + id2 + "'";
                    cmd.Connection = con;
                    cmd.ExecuteNonQuery();
                    con.Close();
                    kayitGetirSalon();
                    MessageBox.Show("Kayıt Silindi..", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Kayıt Yapılamadı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            //SALON SİLME İŞLEMLERİ
            catch (Exception)
            {
                con.Close();
                MessageBox.Show("Kayıt Yapılamadı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox4.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            textBox5.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            comboBox4.Text = dataGridView2.CurrentRow.Cells[5].Value.ToString();
            comboBox3.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();


            //Ses Sitemini Cevabını Comboboxa Yükleme
            if (dataGridView2.CurrentRow.Cells[2].Value.ToString()=="VAR")
            {
                comboBox10.SelectedIndex=1;
            }
            else
                comboBox10.SelectedIndex = 0;
            //Ses Sitemini Cevabını Comboboxa Yükleme

            comboBox3.BackColor= Color.Red;
            comboBox2.BackColor = Color.Red;
            comboBox9.BackColor = Color.Red;

           

            id2 = Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value);//Datagridde id bulup silme güncelleme işlemleri yapmak için
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //SALON GÜNCELLEME İŞLEMLERİ
            try
            {
                FilmIdBul();
                MessageBox.Show("Güncelleme Yapmak İçin Sırasıyla Şehir,Sinema,Film ve Film Yıl Tekrar Seçiniz..","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
               
                if (id2 == 0 || id2 == -1)
                {
                    MessageBox.Show("Güncellenecek Kaydı Seçiniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    cmd = new SqlCommand();
                    con.Open();
                    cmd.CommandText = "select * from Sinema where sinemaAd='" + comboBox3.SelectedItem + "'";
                    cmd.Connection = con;
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        sinemaid = Convert.ToInt32(dr["sinema_id"]);
                    }

                    con.Close();
                    
                    con.Open();
                    cmd = new SqlCommand();
                    cmd.CommandText = "update Salonlar set salonAdi='" + textBox4.Text + "', SalonKapasite='" + textBox5.Text + "', sinema_id='" + sinemaid + "', film_id='" + filminidsi + "',sesSistemi='" + comboBox10.SelectedItem.ToString() + "' where salon_id='" + id2 + "'";
                    cmd.Connection = con;
                    cmd.ExecuteNonQuery();
                    con.Close();
                    kayitGetirSalon();
                    MessageBox.Show("Kayıt Güncellendi..", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            //SALON GÜNCELLEME İŞLEMLERİ
            catch (Exception)
            {

                con.Close();
                MessageBox.Show("HATA", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }


        //SİNEMA ID ÇEKİLİYOR SALON İŞLEMLERİNDE KULLANMAK İÇİN
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            con.Open();
            SqlDataReader dr1;
            string aktor = "select * from Sinema where sinemaAd='" + comboBox3.Text + "' ";
            cmd = new SqlCommand(aktor, con);
            dr1 = cmd.ExecuteReader();
            if (dr1.Read())
            {
                sinemaid = Convert.ToInt32(dr1["sinema_id"]);
            }
            con.Close();
            comboBox3.BackColor = Color.White;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }


        //FİLM ID ÇEKİLİYOR SALON İŞLEMLERİ İÇİN
        private void FilmIdBul()
        {
            con.Open();
            cmd = new SqlCommand();
            cmd.CommandText = "select * from Filmler where filmAdi='" + comboBox4.Text + "' and filmYil='" + comboBox9.Text + "'";
            cmd.Connection = con;
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                filminidsi = Convert.ToInt32(dr["film_id"]);

            }
            con.Close();
        }
        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //Seçilen Film İsminden Film id sini tespit etme

                con.Open();
                cmd = new SqlCommand();
                cmd.CommandText = "select * from Filmler where filmAdi='" + comboBox4.Text + "' and filmYil='" + comboBox9.Text + "'";
                cmd.Connection = con;
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    filminidsi = Convert.ToInt32(dr["film_id"]);

                }
                con.Close();




                //Seçilen Film İsminden Film id sini tespit etme


                comboBox9.Items.Clear();
                comboBox9.Text = "";
                con.Open();
                SqlDataReader dr1;
                string aktor = "select * from Filmler where FilmAdi='" + comboBox2.Text + "' ";
                cmd = new SqlCommand(aktor, con);
                dr1 = cmd.ExecuteReader();
                if (dr1.Read())
                {
                    sehirid = Convert.ToInt32(dr1["film_id"]);

                }
                con.Close();



                //Adı Aynı olan Filmleri Yıl İle Ayırt Etme,Film Yılını Çekme
                con.Open();
                SqlDataReader dr2;
                string yil = "select * from Filmler where FilmAdi='" + comboBox4.SelectedItem.ToString() + "' ";
                cmd = new SqlCommand(yil, con);
                dr2 = cmd.ExecuteReader();
                if (dr2.Read())
                {
                    filmyil = Convert.ToInt32(dr2["filmYil"]);
                    comboBox9.Items.Add(dr2["filmYil"].ToString());

                }
                con.Close();
                //Adı Aynı olan Filmleri Yıl İle Ayırt Etme,Film Yılını Çekme

            }
            catch (Exception)
            {

                con.Close();
                MessageBox.Show("HATA", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }


        //DATAGRİDVİEWDE TIKLANAN KAYIDIN VERİLERİ TEXTBOXLARA YÜKLENİYOR
        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox9.Text = dataGridView3.CurrentRow.Cells[1].Value.ToString();
            textBox10.Text = dataGridView3.CurrentRow.Cells[2].Value.ToString();
            textBox11.Text = dataGridView3.CurrentRow.Cells[3].Value.ToString();
            textBox12.Text = dataGridView3.CurrentRow.Cells[4].Value.ToString();
            comboBox5.Text= dataGridView3.CurrentRow.Cells[5].Value.ToString();
            comboBox6.Text = dataGridView3.CurrentRow.Cells[6].Value.ToString();
            comboBox7.Text = dataGridView3.CurrentRow.Cells[7].Value.ToString();
            comboBox8.Text = dataGridView3.CurrentRow.Cells[8].Value.ToString();
            id3 = Convert.ToInt32(dataGridView3.CurrentRow.Cells[0].Value);



            maskedTextBox1.BackColor = Color.Red;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {

                //EKLEME İŞLEMİ
                if (textBox9.Text == "" || textBox10.Text == "" || textBox11.Text == "" || textBox12.Text == "" || comboBox5.Text == "" || comboBox6.Text == "" || comboBox7.Text == "" || comboBox8.Text == "" || maskedTextBox1.Text == "")
                {
                    MessageBox.Show("Bütün Alanları Doldurun!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    con.Open();
                    cmd = new SqlCommand();
                    cmd.CommandText = "insert into Filmler (filmAdi,filmYil,filmYonetmen,filmSure,zaman_id,aktor_id,aktris_id,dil_id) values (@ad,@yil,@yonetmen,@sure,@zaman,@aktor,@aktris,@dil)";
                    cmd.Connection = con;
                    cmd.Parameters.AddWithValue("@ad", textBox9.Text);
                    cmd.Parameters.AddWithValue("@yil", textBox10.Text);
                    cmd.Parameters.AddWithValue("@yonetmen", textBox11.Text);
                    cmd.Parameters.AddWithValue("@sure", textBox12.Text);
                    cmd.Parameters.AddWithValue("@zaman", Convert.ToInt32(seansid));
                    cmd.Parameters.AddWithValue("@aktor", Convert.ToInt32(aktorid));
                    cmd.Parameters.AddWithValue("@aktris", Convert.ToInt32(aktrisid));
                    cmd.Parameters.AddWithValue("@dil", Convert.ToInt32(dilid));
                    cmd.ExecuteNonQuery();
                    con.Close();

                    con.Open();
                    cmd = new SqlCommand();
                    SqlDataReader dr1;
                    cmd.CommandText = "select * from Filmler where filmAdi='" + textBox9.Text + "'";
                    cmd.Connection = con;
                    dr1 = cmd.ExecuteReader();

                    if (dr1.Read())
                    {
                        comboBox4.Items.Add(dr1["filmAdi"]);
                    }
                    con.Close();

                    con.Open();
                    cmd = new SqlCommand();
                    cmd.CommandText = "SELECT top 1 * FROM Filmler order by film_id desc ";
                    cmd.Connection = con;
                    dr1 = cmd.ExecuteReader();
                    if (dr1.Read())
                    {
                        film = Convert.ToInt32(dr1["film_id"]);
                    }
                    con.Close();
                    con.Close();

                    con.Open();
                    cmd = new SqlCommand();
                    cmd.CommandText = "insert into Gosterim (film_id,gosterimTarih,zaman_id) values(@filmid,@tarih,@seans)";
                    cmd.Connection = con;
                    cmd.Parameters.AddWithValue("@filmid", film);
                    cmd.Parameters.AddWithValue("@tarih", maskedTextBox1.Text);
                    cmd.Parameters.AddWithValue("@seans", Convert.ToInt32(seansid));
                    cmd.ExecuteNonQuery();

                    //comboboxa filmleri çekme
                    con.Close();
                    kayitGetirFilm();
                    MessageBox.Show("Kayit Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                //EKLEME İŞLEMİ

            }
            catch (Exception)
            {

                con.Close();
                MessageBox.Show("HATA", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

     

        private void button11_Click(object sender, EventArgs e)
        {
            SehirIslemleri si = new SehirIslemleri();
            si.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            DilIslemleri di = new DilIslemleri();
            di.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
           
        }

        private void button14_Click(object sender, EventArgs e)
        {
            SeansIslemleri si = new SeansIslemleri();
            si.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {

            try
            {
                //Veriyi Silmek İçin film ismininin id ' sini tespit etme
                cmd = new SqlCommand();
                con.Open();
                cmd.CommandText = "select * from Filmler where filmAdi='" + textBox9.Text + "'and filmYil='" + textBox10.Text + "' and zaman_id='" + seansid + "'";
                cmd.Connection = con;
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    id3 = Convert.ToInt32(dr["film_id"]);
                }
                con.Close();
                //Veriyi Silmek İçin film ismininin id ' sini tespit etme




                //Silme İşlemi
                if (id3 == 0 || id3 == -1)
                {
                    MessageBox.Show("Silinecek Kaydı Seçiniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {


                    if (Convert.ToInt32(dataGridView3.CurrentRow.Cells[0].Value) == id3)
                    {
                        //Silme İşlemi
                        MessageBox.Show(id3.ToString());
                        con.Open();

                        cmd.CommandText = "delete from Gosterim where film_id='" + id3 + "'";
                        cmd.Connection = con;
                        cmd.ExecuteNonQuery();
                        //Silme İşlemi
                        con.Close();



                        con.Open();
                        cmd = new SqlCommand();
                        cmd.CommandText = "delete from Filmler where film_id='" + id3 + "' and filmYil='" + textBox10.Text + "'";
                        cmd.Connection = con;
                        cmd.ExecuteNonQuery();

                        con.Close();


                        con.Open();
                        //Silinen Filmin Salonlarda Gözükmemesi İçin Yapılan İşlem
                        cmd.CommandText = "select * from Filmler where filmAdi='" + textBox9.Text + "'";
                        cmd.Connection = con;
                        dr = cmd.ExecuteReader();

                        if (dr.Read())
                        {
                            comboBox4.Items.Remove(dr["filmAdi"]);
                        }
                        con.Close();
                        //Silinen Filmin Salonlarda Gözükmemesi İçin Yapılan İşlem

                        kayitGetirFilm();

                        MessageBox.Show("Kayıt Silindi..", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Kayıt Silinemedi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {

                con.Close();
                MessageBox.Show("HATA", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            //Silme İşlemi

        }

        private void button9_Click(object sender, EventArgs e)
        {
            //FİLM GÜNCELLEME İŞLEMLERİ
            try
            {
                cmd = new SqlCommand();
                con.Open();
                cmd.CommandText = "select * from Filmler where filmAdi='" + textBox9.Text + "'";
                cmd.Connection = con;
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    id3 = Convert.ToInt32(dr["film_id"]);
                }
                con.Close();
                if (id3 == 0 || id3 == -1)
                {
                    MessageBox.Show("Güncellenecek Kaydı Seçiniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    con.Close();
                    con.Open();
                    cmd = new SqlCommand();
                    cmd.CommandText = "update Filmler set filmAdi='" + textBox9.Text + "', filmYil='" + textBox10.Text + "', filmYonetmen='" + textBox11.Text + "',filmSure='" + textBox12.Text + "' ,zaman_id='" + seansid + "' ,aktor_id='" + aktorid + "' ,aktris_id='" + aktrisid + "',dil_id='" + dilid + "'  where film_id='" + id3 + "'";
                    cmd.Connection = con;
                    cmd.ExecuteNonQuery();
                    con.Close();
                    con.Open();
                    cmd.CommandText = "update Gosterim set gosterimTarih='" + maskedTextBox1.Text + "', zaman_id='" + seansid + "' where film_id='" + id3 + "'";
                    cmd.Connection = con;
                    cmd.ExecuteNonQuery();
                    con.Close();
                    kayitGetirFilm();
                    MessageBox.Show("Kayıt Güncellendi..", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

                //FİLM GÜNCELLEME İŞLEMLERİ
            }
            catch (Exception)
            {
                con.Close();
                MessageBox.Show("HATA", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

           
        }



        
        //AKTRÖR ID ÇEKİLİYOR FİLM İŞLEMLEİ İÇİN
        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            SqlDataReader dr1;
            string aktor = "select * from Aktorler where aktorAdi='" + comboBox5.Text + "' ";
            cmd = new SqlCommand(aktor, con);
            dr1 = cmd.ExecuteReader();
            if (dr1.Read())
            {
                aktorid = Convert.ToInt32(dr1["aktor_id"]);
            }
            con.Close();
        }



        //AKTRİS ID ÇEKİLİYOR FİLM İŞLEMLEİ İÇİN
        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            SqlDataReader dr2;
            string aktris = "select * from Aktrisler where aktrisAdi='" + comboBox6.Text + "' ";
            cmd = new SqlCommand(aktris, con);
            dr2 = cmd.ExecuteReader();
            if (dr2.Read())
            {
                aktrisid = Convert.ToInt32(dr2["aktiris_id"]);
            }
            con.Close();
        }


        //SEANS ID ÇEKİLİYOR FİLM İŞLEMLERİ İÇİN
        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            SqlDataReader dr4;
            string zaman = "select * from Zaman where zamanAralik='" + comboBox7.Text + "' ";
            cmd = new SqlCommand(zaman, con);
            dr4 = cmd.ExecuteReader();
            if (dr4.Read())
            {
                seansid = Convert.ToInt32(dr4["zaman_id"]);
            }
            con.Close();
        }


        //DİL ID ÇEKİLİYOR FİLM İŞLEMLERİ İÇİN
        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            SqlDataReader dr3;
            string dil = "select * from Dil where dil='" + comboBox8.Text + "' ";
            cmd = new SqlCommand(dil, con);
            dr3 = cmd.ExecuteReader();
            if (dr3.Read())
            {
                dilid = Convert.ToInt32(dr3["dil_id"]);
            }
            con.Close();
        }




        //AYNI İSME SAHİP VERİLER OLUNCA TEXTBOX FARKLI RENGE BÜRÜNÜYOR
        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            string aranan = textBox9.Text.Trim().ToUpper();
            for (int i = 0; i <= dataGridView3.Rows.Count - 1; i++)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    foreach (DataGridViewCell cell in dataGridView3.Rows[i].Cells)
                    {
                        if (cell.Value != null)
                        {
                            if (cell.Value.ToString().ToUpper() == aranan)
                            {
                                cell.Style.BackColor = Color.DarkTurquoise;

                                break;

                            }

                        }

                        cell.Style.BackColor = Color.White;
                    }

                }
            }

        }
        //*******************************************************************BUTON İŞLEMLERİ****************************************//

        //TEXTBOX COLOR U AYARLANIYOR
        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox9.BackColor = Color.White;
        }

        private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        //MÜŞTERİ FORMU AÇILIYOR
       

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }
        
        //TEXTBOX COLOR U AYARLANIYOR
        private void maskedTextBox1_Click(object sender, EventArgs e)
        {
            maskedTextBox1.BackColor = Color.White;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Bilgi bl = new Bilgi();
            bl.Show();
        }
    }
}
