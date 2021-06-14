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
using System.IO;
using System.Net; 

namespace BookMyshow
{
    public partial class booked : Form
    {
        SqlConnection cs = new SqlConnection("Data Source='DESKTOP-RPQ1FVH\\SQLEXPRESS';initial catalog= bookshow;integrated Security=true");
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        SqlDataAdapter da1 = new SqlDataAdapter();
        DataSet ds1 = new DataSet();
        public System.Drawing.Image img;
        public static int i=0;
        public booked()
        {
            InitializeComponent();
        }

        private void booked_Load(object sender, EventArgs e)
        {
            if (log.username != String.Empty)
            {
                try
                {
                    da.SelectCommand = new SqlCommand("select * from booked where uid= '"+log.username+"' order by (id) DESC", cs);
                    ds.Clear();
                    da.Fill(ds);
                    comboBox1.DataSource = ds.Tables[0];
                    comboBox1.DisplayMember = "id";
                    this.backgroundWorker1.DoWork += BackgroundWorker1_DoWork;

                }
                catch
                {


                }
            }else
            {
                groupBox2.Visible = false;
            }

        }

        private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void printbtn_Click(object sender, EventArgs e)
        {
            printtik p = new printtik();
            p.print(pictureBox1.Image, tlbl.Text, titlelbl.Text, datelbl.Text, timelbl.Text, pricelbl.Text, thelbl.Text, seatlbl.Text);


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            pictureBox1.ImageLocation = ds.Tables[0].Rows[comboBox1.SelectedIndex][3].ToString();
                //WebClient wc = new WebClient();
               // byte[] bytes = wc.DownloadData(ds.Tables[0].Rows[comboBox1.SelectedIndex][3].ToString());
               // MemoryStream ms = new MemoryStream(bytes);
               // this.img = System.Drawing.Image.FromStream(ms);
               // pictureBox1.Image = img;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            
           

            tlbl.Text = ds.Tables[0].Rows[comboBox1.SelectedIndex][0].ToString();
            titlelbl.Text = ds.Tables[0].Rows[comboBox1.SelectedIndex][2].ToString() ;

           

            datelbl.Text = ds.Tables[0].Rows[comboBox1.SelectedIndex][4].ToString() ;
            timelbl.Text = ds.Tables[0].Rows[comboBox1.SelectedIndex][5].ToString() ;
            pricelbl.Text = ds.Tables[0].Rows[comboBox1.SelectedIndex][6].ToString() ;
            thelbl.Text = ds.Tables[0].Rows[comboBox1.SelectedIndex][7].ToString() ;
            seatlbl.Text = ds.Tables[0].Rows[comboBox1.SelectedIndex][8].ToString() ;

            
            

        }

        private void label11_Click(object sender, EventArgs e)
        {
           
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            WebClient wc = new WebClient();
            byte[] bytes = wc.DownloadData(ds.Tables[0].Rows[comboBox1.SelectedIndex][3].ToString());
            MemoryStream ms = new MemoryStream(bytes);
            this.img = System.Drawing.Image.FromStream(ms);
            pictureBox1.Image = img;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            i = 1;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
