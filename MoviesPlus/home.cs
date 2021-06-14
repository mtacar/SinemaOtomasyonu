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
    public partial class home : Form
    {
        SqlConnection cs = new SqlConnection("Data Source='DESKTOP-5NBVFP6\\SQLEXPRESS';initial catalog= bookshow;integrated Security=true");
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        SqlDataAdapter da1 = new SqlDataAdapter();
        DataSet ds1 = new DataSet();
        public home()
        {
            InitializeComponent();

            
        }
        public void loadmain()
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void home_Load(object sender, EventArgs e)
        {
            
            da.SelectCommand = new SqlCommand("select url,moviename from mainpic", cs);
            ds.Clear();
            da.Fill(ds);
            try
            {
                slideshowpic1.ImageLocation = ds.Tables[0].Rows[0][0].ToString();
                slidepic2.ImageLocation = ds.Tables[0].Rows[1][0].ToString();
                slidepic3.ImageLocation = ds.Tables[0].Rows[2][0].ToString(); 
            slidepic4.ImageLocation = ds.Tables[0].Rows[3][0].ToString();
        }
        catch
        {
                
        }
            slidetimer.Interval = 3000;
            slidetimer.Start();
            slideshowpic1.Visible = true;
            slidepic2.Visible = false;
            slidepic3.Visible = false;
            slidepic4.Visible = false;
            da1.SelectCommand = new SqlCommand("select mname,posterurl from mtable where mrelease <= '"+ DateTime.Today.ToString("yyy-MM-dd") +"' order by(mrelease) desc", cs);
            da1.Fill(ds1);
            if (ds1.Tables[0].Rows.Count > 4)
            {
                mtitle1.Text = ds1.Tables[0].Rows[0][0].ToString();
                subpic1.ImageLocation = ds1.Tables[0].Rows[0][1].ToString();
                mtitle2.Text = ds1.Tables[0].Rows[1][0].ToString();
                subpic2.ImageLocation = ds1.Tables[0].Rows[1][1].ToString();
                mtitle3.Text = ds1.Tables[0].Rows[2][0].ToString();
                subpic3.ImageLocation = ds1.Tables[0].Rows[2][1].ToString();
                mtitle4.Text = ds1.Tables[0].Rows[ds.Tables[0].Rows.Count - 1][0].ToString();
                subpic4.ImageLocation = ds1.Tables[0].Rows[ds.Tables[0].Rows.Count - 1][1].ToString();
                
            }
            else if (ds1.Tables[0].Rows.Count == 3)
            {
                mtitle1.Text = ds1.Tables[0].Rows[0][0].ToString();
                subpic1.ImageLocation = ds1.Tables[0].Rows[0][1].ToString();
                mtitle2.Text = ds1.Tables[0].Rows[1][0].ToString();
                subpic2.ImageLocation = ds1.Tables[0].Rows[1][1].ToString();
                mtitle3.Text = ds1.Tables[0].Rows[2][0].ToString();
                subpic3.ImageLocation = ds1.Tables[0].Rows[2][1].ToString();

            }
            else if (ds1.Tables[0].Rows.Count == 2)
            {
                mtitle1.Text = ds1.Tables[0].Rows[0][0].ToString();
                subpic1.ImageLocation = ds1.Tables[0].Rows[0][1].ToString();
                mtitle2.Text = ds1.Tables[0].Rows[1][0].ToString();
                subpic2.ImageLocation = ds1.Tables[0].Rows[1][1].ToString();
       




            }
            else if (ds1.Tables[0].Rows.Count == 1)
            {
                mtitle1.Text = ds1.Tables[0].Rows[0][0].ToString();
                subpic1.ImageLocation = ds1.Tables[0].Rows[0][1].ToString();

            }
            else
            {
                mtitle1.Text = "Kullanım Dışı";
                mtitle1.Text = "Kullanım Dışı";
                mtitle1.Text = "Kullanım Dışı";
                mtitle1.Text = "Kullanım Dışı";
            }


        }

        private void slidetimer_Tick(object sender, EventArgs e)
        {
            if (slideshowpic1.Visible == true)
            {
                slideshowpic1.Visible = false;
                slidepic2.Visible = true;
            }
            else if (slidepic2.Visible == true)
            {
                slidepic2.Visible = false;
                slidepic3.Visible = true;
            }
            else if (slidepic3.Visible == true)
            {
                slidepic3.Visible = false;
                slidepic4.Visible = true;
            }
            else
            {
                slidepic4.Visible = false;
                slideshowpic1.Visible = true;
            }
            
        }

        private void swallbtn_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Movied")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }

            if (IsOpen == false)
            {
                Movied md = new Movied("");
                md.MdiParent = this.ParentForm;
                md.Show();
                md.Dock = DockStyle.Fill;
            }
        }

        private void subpic1_Click(object sender, EventArgs e)
        {
            Movied mod = new Movied(mtitle1.Text);
            mod.MdiParent = this.ParentForm;
            mod.Dock = DockStyle.Fill;
            mod.Show();
        }

       

        private void subpic2_Click(object sender, EventArgs e)
        {
            Movied mod = new Movied(mtitle2.Text);
            mod.MdiParent = this.ParentForm;
            mod.Dock = DockStyle.Fill;
            mod.Show();
        }

        private void subpic3_Click(object sender, EventArgs e)
        {
            Movied mod = new Movied(mtitle3.Text);
            mod.MdiParent = this.ParentForm;
            mod.Dock = DockStyle.Fill;
            mod.Show();
        }

        private void subpic4_Click(object sender, EventArgs e)
        {
            Movied mod = new Movied(mtitle4.Text);
            mod.MdiParent = this.ParentForm;
            mod.Dock = DockStyle.Fill;
            mod.Show();
        }

        private void slidepic3_Click(object sender, EventArgs e)
        {
            Movied mod = new Movied(ds.Tables[0].Rows[2][1].ToString());
            mod.MdiParent = this.ParentForm;
            mod.Dock = DockStyle.Fill;
            mod.Show();
        }
        private void slidepic4_Click(object sender, EventArgs e)
        {
            Movied mod = new Movied(ds.Tables[0].Rows[3][1].ToString());
            mod.MdiParent = this.ParentForm;
            mod.Dock = DockStyle.Fill;
            mod.Show();
        }

        private void slidepic2_Click(object sender, EventArgs e)
        {
            Movied mod = new Movied(ds.Tables[0].Rows[1][1].ToString());
            mod.MdiParent = this.ParentForm;
            mod.Dock = DockStyle.Fill;
            mod.Show();
        }

        private void slideshowpic1_Click(object sender, EventArgs e)
        {
            Movied mod = new Movied(ds.Tables[0].Rows[0][1].ToString());
            mod.MdiParent = this.ParentForm;
            mod.Dock = DockStyle.Fill;
            mod.Show();
        }
    }
}
