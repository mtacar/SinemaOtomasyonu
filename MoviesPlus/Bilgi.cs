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
    public partial class Bilgi : Form
    {
        public Bilgi()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-14CBEL7;Initial Catalog=SinemaOtomasyonu;Integrated Security=SSPI;");
        SqlCommand cmd;
        SqlDataReader dr;
        SqlDataAdapter da;


        //View Kullanımı
        //Tüm Şehirlerdeki Sinemaları Getirir
        private void button3_Click(object sender, EventArgs e)
        {
            
            cmd = new SqlCommand();
            con.Open();
            cmd.CommandText = "select * from vwSehirSinemaSalon";
            cmd.Connection = con;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        //Stored Procedure Burada
        //Seçili Şehirdeki Sinemaları Gösterir
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                MessageBox.Show("Lütfen Şehri Seçiniz..", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                con.Open();
                SqlDataAdapter sql = new SqlDataAdapter("spSehirdekiSinemaBilgileri", con);
                sql.SelectCommand.CommandType = CommandType.StoredProcedure;
                sql.SelectCommand.Parameters.AddWithValue("@sehirAd", comboBox1.SelectedItem.ToString());
                DataSet ds = new DataSet();
                sql.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];



                con.Close();
            }
        }

        private void Bilgi_Load(object sender, EventArgs e)
        {//Şehirleri Yükle
          
            cmd = new SqlCommand();
            con.Open();
            cmd.CommandText = "select * from Sehirler";
            cmd.Connection = con;
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {

                comboBox1.Items.Add(dr["sehirAd"]);
            }
            con.Close();
            //Şehirleri Yükle




            DataGridViewColumn column;

            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                column = dataGridView1.Columns[i];

                column.Width = 55;
            }
        }


        //Fonksiyon Kullanımı 
        //Seçilen Şehre Göre Satılan Bilet Sayısını Gösterir
        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                MessageBox.Show("Lütfen Şehri Seçiniz..", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                con.Open();
                SqlCommand sql2 = new SqlCommand("select dbo.fnSehirBiletSatisi(@sehirAd) as donen", con);
                sql2.CommandType = CommandType.Text;
                sql2.Parameters.AddWithValue("@sehirAd", comboBox1.SelectedItem.ToString());
                SqlDataReader dr = sql2.ExecuteReader();
                if (dr.Read())
                    MessageBox.Show(dr["donen"].ToString());
                con.Close();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
