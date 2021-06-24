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
    public partial class DilIslemleri : Form
    {
        public DilIslemleri()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=;Initial Catalog=SinemaOtomasyonu;Integrated Security=SSPI");
        SqlCommand cmd;
        SqlDataReader dr;
        SqlDataAdapter da;

        int id1;
        int id2;
        private void kayitGetirDil()
        {
            //Dil DatagridWiewine Ver Çekme
            cmd = new SqlCommand();
            con.Open();
            cmd.CommandText = "select * from Dil";
            cmd.Connection = con;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();


            //Dil DatagridWiewine Ver Çekme
        }
        private void DilIslemleri_Load(object sender, EventArgs e)
        {
            kayitGetirDil();

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            id1 = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text != "")
            {

                cmd = new SqlCommand();
                con.Open();
                cmd.CommandText = "insert into Dil (dil) values (@ad)";
                cmd.Connection = con;
                cmd.Parameters.AddWithValue("@ad", textBox1.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                kayitGetirDil();
                MessageBox.Show("Kayıt Eklendi..", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("İsim Girmediniz..", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value) == id1)
                {
                    cmd = new SqlCommand();
                    con.Open();
                    cmd.CommandText = "delete from Dil where dil_id='" + id1 + "'";
                    cmd.Connection = con;
                    cmd.ExecuteNonQuery();
                    con.Close();
                    kayitGetirDil();
                    MessageBox.Show("Kayıt Silindi..", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Kayıt Silinemedi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
                MessageBox.Show("Silinecek Kaydı seçiniz..", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button3_Click(object sender, EventArgs e)
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
                    cmd.CommandText = "update Dil set dil='" + textBox1.Text + "' where dil_id='" + id1 + "'";
                    cmd.Connection = con;
                    cmd.ExecuteNonQuery();
                    con.Close();
                    kayitGetirDil();
                    MessageBox.Show("Kayıt Güncellendi..", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Güncellenecek Kaydı seçiniz..", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            YoneticiIslemleri yi = new YoneticiIslemleri();
            yi.Show();
        }
    }
}
