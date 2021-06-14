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
using System.Net;

namespace BookMyshow
{
    public partial class Movied : Form
    {
        SqlConnection cs = new SqlConnection("Data Source='DESKTOP-5NBVFP6\\SQLEXPRESS';initial catalog= bookshow;integrated Security=true");
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        DataSet ds2 = new DataSet();
        BindingSource BS = new BindingSource();
        public Movied(string name)
        {
            InitializeComponent();
            if (name != "")
            {
                da.SelectCommand = new SqlCommand("select mname from mtable order by(mrelease) desc", cs);
                ds.Clear();
                da.Fill(ds);
                mlistbx.DataSource = ds.Tables[0];
                mlistbx.DisplayMember = "mname";

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    if (ds.Tables[0].Rows[i][0].ToString() == name)
                    {
                        mlistbx.SelectedIndex = i;

                    }
                }
                this.showdetail_Click(null,null);
            }
            else
            {
                da.SelectCommand = new SqlCommand("select mname from mtable order by(mrelease) desc", cs);
                ds.Clear();
                da.Fill(ds);
                mlistbx.DataSource = ds.Tables[0];
                mlistbx.DisplayMember = "mname";
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void Movied_Load(object sender, EventArgs e)
        {
            this.AcceptButton = bookbtn;
            

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void showdetail_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Movie = null;
            da.SelectCommand = new SqlCommand("select * from mtable where mname='" + ds.Tables[0].Rows[mlistbx.SelectedIndex][0].ToString() + "' ", cs);
            ds.Clear();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {   
                Midtxt.Text = ds.Tables[0].Rows[0][1].ToString();
                mnametxt.Text = ds.Tables[0].Rows[0][0].ToString();
                mgenertxt.Text = ds.Tables[0].Rows[0][2].ToString();
                durationtxt.Text = ds.Tables[0].Rows[0][3].ToString();
                languagetxt.Text = ds.Tables[0].Rows[0][4].ToString();
                casttxt.Text = ds.Tables[0].Rows[0][5].ToString();
                releasetxt.Text = ds.Tables[0].Rows[0][6].ToString().Substring(0,9);
                ratingtxt.Text = ds.Tables[0].Rows[0][7].ToString();
                synopsistxt.Text = ds.Tables[0].Rows[0][10].ToString();
                axShockwaveFlash1.Movie = ds.Tables[0].Rows[0][8].ToString();
                //groupBox1.BackgroundImage=  ds.Tables[0].Rows[0][9].ToString();                        
                groupBox1.Visible = true;
                da.SelectCommand = new SqlCommand("select mname from mtable order by(mrelease) desc ", cs);
                ds.Clear();
                da.Fill(ds);
                mlistbx.DataSource = ds.Tables[0];
                mlistbx.DisplayMember = "mname";
                mlistbx.Text = mnametxt.Text;
            }
            else
            {
                MessageBox.Show("Geçersiz");
            }


            

        }

        private void mname_Click(object sender, EventArgs e)
        {

        }

        private void duration_Click(object sender, EventArgs e)
        {

        }

        private void Mdi_Click(object sender, EventArgs e)
        {

        }

        private void mgener_Click(object sender, EventArgs e)
        {

        }

        private void Language_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void addmoivebtn_Click(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;
            da.SelectCommand = new SqlCommand("select * from mtable1 where mname='" + mnametxt.Text + "' and date >= '"+ today.ToString("yyyy-MM-dd")+"'", cs);
            ds2.Clear();
            da.Fill(ds2);
            if (ds2.Tables[0].Rows.Count > 0)
            {
                BookM BM = new BookM(mnametxt.Text);
                BM.MdiParent = this.ParentForm;
                BM.Dock = DockStyle.Fill;
                BM.Show();
            }
            else
            {
                MessageBox.Show("Film "+ mnametxt.Text +" mevcut değil. Lütfen daha sonra tekrar deneyin.");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
