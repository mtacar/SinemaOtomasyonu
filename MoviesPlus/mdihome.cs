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
    public partial class mdihome : Form
    {
        SqlConnection cs = new SqlConnection("Data Source='DESKTOP-RPQ1FVH\\SQLEXPRESS';initial catalog= bookshow;integrated Security=true");
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();

        public mdihome()
        {
            InitializeComponent();
            
        }

        private void signInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            signinpg s = new signinpg();

            if (s.ShowDialog(this) == DialogResult.OK)
            {
                progressBar1.Value = 0;
                timer1.Interval = 10;
                timer1.Enabled = true;
                logOutToolStripMenuItem.Visible = true;
                nameToolStripMenuItem.Text = log.username;
                bookedTicketsToolStripMenuItem.Visible = true;


            }
            else if (s.DialogResult == DialogResult.Yes)
            {
                
                progressBar1.Value = 0;
                timer1.Interval = 10;
                timer1.Enabled = true;
                nameToolStripMenuItem.Text = log.username;
                manageMoviesToolStripMenuItem.Visible = true;
                bookedTicketsToolStripMenuItem.Visible = true;


            }

        }
        
        private void mdihome_Load(object sender, EventArgs e)
        {
            this.FormClosed += Mdihome_FormClosed;
            
                home h = new home();
                h.MdiParent = this;
                h.Show();
                h.Dock = DockStyle.Fill;
            
            Welcome W = new Welcome();
            
            progressBar1.Visible = false;
            label1.Visible = false;
            nameToolStripMenuItem.Text = log.username;
            if (W.ShowDialog(this) == DialogResult.OK)
            {
                manageMoviesToolStripMenuItem.Visible = false;
                logOutToolStripMenuItem.Visible = false;
                cancelBookedTicketToolStripMenuItem.Visible = false;
                bookedTicketsToolStripMenuItem.Visible = false;
            }



        }

        private void Mdihome_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "home")
                {
                    IsOpen = true;
                    f.Focus();
                   
                    break;
                }
                
            }
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Movied")
                {
                    f.Close();
                    break;

                }
            }
            if (IsOpen == false)
            {
                home h = new home();
                h.MdiParent = this;
                h.Show();
                h.Dock = DockStyle.Fill;
            }
            
        }

        private void moviesToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Movied")
                {
                   
                    f.Close();
                   
                    
                    
                    break;
                }
            }
            Movied mov = new Movied("");
            mov.MdiParent = this;
            mov.Show();
            mov.Dock = DockStyle.Fill;



        }

        private void manageMoviesToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        public void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }

        private void manageMainPicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "homemanager")
                {
                    IsOpen = true;
                    f.Focus();
                   
                    break;
                }
            }

            if (IsOpen == false)
            {
                homemanager M = new homemanager();
                M.MdiParent = this;
                M.Show();
                M.Dock = DockStyle.Fill;
            }
        }

        private void addRemoveMovieToolStripMenuItem_Click(object sender, EventArgs e)
        {

            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "manage")
                {
                    IsOpen = true;
                    f.Focus();
                  
                    break;
                }
            }

            if (IsOpen == false)
            {
                addmovies a = new addmovies();
                a.MdiParent = this;
                a.Show();
                a.Dock = DockStyle.Fill;
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            progressBar1.Visible = true;
            progressBar1.Increment(1);
            if (progressBar1.Value <= 20)
            {
                label1.Visible = false;
                label1.Text = "Lütfen Bekleyin";

            }
            else
            {
                if (progressBar1.Value == 100)
                {

                    timer.Enabled = false;
                    progressBar1.Visible = false;
                    manageMoviesToolStripMenuItem.Visible = false; ;
                    signInToolStripMenuItem.Visible = true;
                    logOutToolStripMenuItem.Visible = false;
                }

            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            progressBar1.Visible = true;
            progressBar1.Increment(1);
            if (progressBar1.Value <= 20)
            {
                label1.Visible = false;
                label1.Text = "Lütfen Bekleyin";

            }
            else
            {
                if (progressBar1.Value == 100)
                {

                    timer1.Enabled = false;
                    progressBar1.Visible = false;
                    signInToolStripMenuItem.Visible = false;
                    logOutToolStripMenuItem.Visible = true;
                }

            }
        }

        private void bookNowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "BookM")
                {
                    f.Close();
                    Refresh();
                    break;
                }
            }
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Movied")
                {
                    f.Close();
                    break;

                }
            }

            if (IsOpen == false)
            {
                BookM a = new BookM("");
                a.MdiParent = this;
                a.Show();
                a.Dock = DockStyle.Fill;
            }
        }

        private void addTheatreInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "manager")
                {
                    IsOpen = true;
                    f.Focus();
                 
                    break;
                }
            }

            if (IsOpen == false)
            {
                manager ma = new manager();
                ma.MdiParent = this;
                ma.Show();
                ma.Dock = DockStyle.Fill;
            }

        }

        private void cancelBookedTicketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "canceltik")
                {
                    IsOpen = true;
                    f.Focus();
                   
                    break;
                }
            }

            if (IsOpen == false)
            {
                canceltik ma = new canceltik();
                ma.MdiParent = this;
                ma.Show();
                ma.Dock = DockStyle.Fill;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Çıkmak istediğinize emin misiniz?", "CineWatch", MessageBoxButtons.YesNo, MessageBoxIcon.Information);  
if (res == DialogResult.Yes) {
                this.Close();
            }   

            
        }

        private void nameToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            log.username = "";
            log.pwd = "";
            progressBar1.Value = 0;
            timer.Interval = 10;
            timer.Enabled = true;
            nameToolStripMenuItem.Text = "";
            bookedTicketsToolStripMenuItem.Visible = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "BookM")
                {
                    f.Close();
                    Refresh();
                    break;
                }
                if (f.Text == "booked")
                {
                    f.Close();
                    Refresh();
                    break;
                }
            }
        }

        private void bookedTicketsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "booked")
                {
                    f.Close();
                    Refresh();
                    break;
                }
                
            }
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Movied")
                {
                    f.Close();
                    Refresh();
                    break;
                }

            }
            

            if (IsOpen == false)
            {
                booked a = new booked();
                a.MdiParent = this;
                a.Show();
                a.Dock = DockStyle.Fill;
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        //private void displayMovieListToolStripMenuItem_Click(object sender, EventArgs e)
        //{

        //}

    }
}
