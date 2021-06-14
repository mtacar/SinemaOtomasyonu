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
    public partial class signinpg : Form
    {
        SqlConnection cs = new SqlConnection("Data Source='DESKTOP-RPQ1FVH\\SQLEXPRESS';initial catalog= bookshow;integrated Security=true");
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        public signinpg()
        {
            InitializeComponent();
        }

        private void signinbtnr_Click(object sender, EventArgs e)
        {
            if (usertxtr.Text != string.Empty && pwdtxtr.Text != string.Empty)
            {
                da.SelectCommand = new SqlCommand("select Username,Password,type from usersdl Where Username='" + usertxtr.Text + "' and Password='" + pwdtxtr.Text + "'", cs);
                da.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    if (ds.Tables[0].Rows[0][2].ToString() == "0")
                    {
                        this.DialogResult = DialogResult.OK;
                        log.username = usertxtr.Text;
                        log.pwd = pwdtxtr.Text;
                    }else
                    {
                        this.DialogResult = DialogResult.Yes;
                        log.username = usertxtr.Text;
                        log.pwd = pwdtxtr.Text;
                    }
                    foreach (Form f in Application.OpenForms)
                    {
                        if (f.Text == "BookM")
                        {
                            f.Close();
                            Refresh();
                            break;
                        }
                    }

                }
                else
                    MessageBox.Show("Kullanıcı Adı / Şifre yanlış.Lütfen tekrar deneyin.");
            }
            else
                MessageBox.Show("Lütfen Kullanıcı Adı / Şifrenizi girin.");
        }

        private void registerbtnr_Click(object sender, EventArgs e)
        {
            signuppg s = new signuppg();
            this.Hide();

            if (s.ShowDialog(this) == DialogResult.OK)
            {
                this.Activate();
            }
        }

        private void signinpg_Load(object sender, EventArgs e)
        {
            this.AcceptButton = signinbtnr;
        }

        private void signuplblr_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loggrbx_Enter(object sender, EventArgs e)
        {

        }
    }
}
