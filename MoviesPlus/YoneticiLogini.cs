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
    public partial class YoneticiLogini : Form
    {
        public YoneticiLogini()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-14CBEL7;Initial Catalog=SinemaOtomasyonu; Integrated Security=SSPI;");
        SqlDataAdapter da;
        SqlDataReader dr;
        DataTable dt;
        SqlCommand cmd;
        private void button1_Click(object sender, EventArgs e)
        {
            //LOGIN İŞLEMLERİ
            try
            {
                string kAdi = textBox1.Text;
                int sifre = Convert.ToInt32(textBox2.Text);
                cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "SELECT * FROM Yonetici where yoneticiAdi='" + textBox1.Text + "' AND yoneticiSifre='" + textBox2.Text + "'";
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    YoneticiIslemleri y = new YoneticiIslemleri();
                    y.Show();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı ya da şifre yanlış");
                }

                con.Close();
            }

            //LOGIN İŞLEMLERİ
            catch (Exception ex)
            {
                MessageBox.Show("Kullanıcı adı ya da şifre yanlış");
                return;
            }
        }

        //ŞİFRE TEXTBOXU * KARAKTERİ OLSUN
        private void YoneticiLogini_Load(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
        }
    }
}
