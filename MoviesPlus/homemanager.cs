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

namespace BookMyshow
{
    public partial class homemanager : Form
    {
        SqlConnection cs = new SqlConnection("Data Source='DESKTOP-RPQ1FVH\\SQLEXPRESS';initial catalog= bookshow;integrated Security=true");
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        DataSet ds1 = new DataSet();
        BindingSource BS = new BindingSource();
        public homemanager()
        {
            InitializeComponent();
            da.SelectCommand = new SqlCommand("select * from mainpic order by(id) ", cs);
            ds.Clear();
            da.Fill(ds);
            da.SelectCommand = new SqlCommand("select mname from mtable ", cs);
            ds1.Clear();
            da.Fill(ds1);
            namebxtxt.DataSource = ds1.Tables[0];
            namebxtxt.DisplayMember = "mname";

        }

        private void insertbtn_Click(object sender, EventArgs e)
        {

        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            try
            {
                da.UpdateCommand = new SqlCommand("update mainpic set Url=@url, moviename=@moviename where id= " + comboBox1.SelectedIndex.ToString(), cs);
                da.UpdateCommand.Parameters.Add("moviename", SqlDbType.VarChar).Value = namebxtxt.Text;
                da.UpdateCommand.Parameters.Add("url", SqlDbType.Text).Value = urlbxtxt.Text;
                cs.Open();
                da.UpdateCommand.ExecuteNonQuery();
                cs.Close();
                foreach (Form f in Application.OpenForms)
                {
                    if (f.Text == "home")
                    {
                        f.Close();
                        break;
                    }
                }
                    
            }
            catch
            {
                MessageBox.Show("Bir Hata Oluştu. Lütfen Tekrar Deneyin.");

            }
            
            da.SelectCommand = new SqlCommand("select * from mainpic order by(id) ", cs);
            ds.Clear();
            da.Fill(ds);
            MessageBox.Show("Güncelleme Başarılı.");
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {

        }

        private void firstbtn_Click(object sender, EventArgs e)
        {

           
        }

        private void previousbtn_Click(object sender, EventArgs e)
        {
            
        }

        private void nextbtn_Click(object sender, EventArgs e)
        {
            
 
        }

        private void lastbtn_Click(object sender, EventArgs e)
        {
            
        }
        private void Records()
        {
            
        }
        private void dgupdate()
        {
            
        }

        private void displaybtn_Click(object sender, EventArgs e)
        {
            
        }


        private void homemanager_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            namebxtxt.Text = ds.Tables[0].Rows[int.Parse(comboBox1.SelectedIndex.ToString())][1].ToString();
            urlbxtxt.Text = ds.Tables[0].Rows[int.Parse(comboBox1.SelectedIndex.ToString())][2].ToString();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = urlbxtxt.Text;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
