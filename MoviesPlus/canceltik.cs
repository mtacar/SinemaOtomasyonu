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
    public partial class canceltik : Form
    {
        SqlConnection cs = new SqlConnection("Data Source='DESKTOP-RPQ1FVH\\SQLEXPRESS';initial catalog= bookshow;integrated Security=true");
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        DataSet ds1 = new DataSet();
        DataSet ds2 = new DataSet();
        DataSet ds3 = new DataSet();
        public canceltik()
        {
            InitializeComponent();
        }

        private void canceltik_Load(object sender, EventArgs e)
        {
            da.SelectCommand = new SqlCommand("select wallet,id from usersdl where login_st=1", cs);
            ds.Clear();
            da.Fill(ds);
            walletamt.Text = ds.Tables[0].Rows[0][0].ToString();
            da.SelectCommand = new SqlCommand("select * from usersdl where ", cs);
            ds.Clear();
            da.Fill(ds2);

        }

        private void resetbtn_Click(object sender, EventArgs e)
        {
           canceltik ma = new canceltik();
            ma.MdiParent = this.ParentForm;
            ma.Dock = DockStyle.Fill;
            this.Hide();
            ma.Show();
        }
    }
}
