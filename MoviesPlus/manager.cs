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
    public partial class manager : Form
    {
        SqlConnection cs = new SqlConnection("Data Source='DESKTOP-RPQ1FVH\\SQLEXPRESS';initial catalog= bookshow;integrated Security=true");
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        DataSet ds1 = new DataSet();
        DataSet ds2 = new DataSet();
        
        public manager()
        {

            InitializeComponent();
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "hh:mm tt";
        }

        private void manager_Load(object sender, EventArgs e)
        {
            da.SelectCommand = new SqlCommand("select (max(ts_id)+1) from mtable2 ", cs);
            da.Fill(ds2);
            tsidlbl.Text = ds2.Tables[0].Rows[0][0].ToString();
            da.SelectCommand = new SqlCommand("select distinct mname from mtable ", cs);
            ds.Clear();
            da.Fill(ds);
            moviebox.DataSource = ds.Tables[0];
            moviebox.DisplayMember = "mname";
            moviebox.SelectedIndex = -1;
            da.SelectCommand = new SqlCommand("select distinct tname from mtable1 ", cs);
            ds1.Clear();
            da.Fill(ds1);
            tnamebox.DataSource = ds1.Tables[0];
            tnamebox.DisplayMember = "tname";
            tnamebox.SelectedIndex = -1;

        }

        private void tnamebox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tnamebox.SelectedIndex != -1)
            {
                tnametxt.Enabled = false;
                

            }
            else
            {
                tnametxt.Enabled = true;

            }
            
        }

        private void addbtn_Click(object sender, EventArgs e)
            
        {
            String timetxt = dateTimePicker2.Value.ToString("hh:mm tt");
            String textBox1 = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            MessageBox.Show(timetxt);
            if (moviebox.SelectedIndex!=-1 && textBox1!="" && (tnamebox.SelectedIndex!=-1 || tnametxt.Text!= "") && timetxt!="" && sptxt.Text!="" && pptxt.Text!="" && rptxt.Text!="")
            {
                if (tnamebox.SelectedIndex != - 1)
                {
                    da.InsertCommand = new SqlCommand("Insert into mtable1 values('" + ds.Tables[0].Rows[moviebox.SelectedIndex][0].ToString() + "','" + textBox1 + "','" + ds1.Tables[0].Rows[tnamebox.SelectedIndex][0].ToString() +"','" + timetxt + "','" + sptxt.Text +"','" + pptxt.Text +"','" +rptxt.Text +"','" + tsidlbl.Text +"')", cs);
                    cs.Open();
                    da.InsertCommand.ExecuteNonQuery();
                    cs.Close();
                    
                }
                else
                {
                    da.InsertCommand = new SqlCommand("Insert into mtable1 values('" + ds.Tables[0].Rows[moviebox.SelectedIndex][0].ToString() + "','" + textBox1 + "','" + tnametxt.Text + "','" + timetxt + "','" + sptxt.Text + "','" + pptxt.Text + "','" + rptxt.Text + "','" + tsidlbl.Text + "')", cs);
                    cs.Open();
                    da.InsertCommand.ExecuteNonQuery();
                    cs.Close();
                    
                }

                da.InsertCommand = new SqlCommand("Insert into mtable2 (ts_id) values('" + tsidlbl.Text + "')", cs);
                cs.Open();
                da.InsertCommand.ExecuteNonQuery();
                cs.Close();
                tsidlbl.Text = (int.Parse(tsidlbl.Text) + 1).ToString();
                MessageBox.Show("Giriş Başarılı.");
                resetbtn_Click(this,e);
            }
            else
            {
                MessageBox.Show("Lütfen Tüm Alanları Doğru Doldurun.");
            }
        }

        private void tnametxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void resetbtn_Click(object sender, EventArgs e)
        {
            manager ma = new manager();
            ma.MdiParent = this.ParentForm;
            ma.Dock = DockStyle.Fill;
            this.Hide();
            ma.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
