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
    public partial class addmovies : Form
    {

        SqlConnection cs = new SqlConnection("Data Source='DESKTOP-RPQ1FVH\\SQLEXPRESS';initial catalog= bookshow;integrated Security=true");
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        DataSet ds1 = new DataSet();
        BindingSource BS = new BindingSource();

        public addmovies()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void manage_Load(object sender, EventArgs e)
        {
            da.SelectCommand = new SqlCommand("select mname from mtable ", cs);
            ds1.Clear();
            da.Fill(ds1);
            mlistbx.DataSource = ds1.Tables[0];
            mlistbx.DisplayMember = "mname";
            TimePicker.Format = DateTimePickerFormat.Custom;
            TimePicker.CustomFormat = "hh:mm";
        }

        private void movieidlbl_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void addmoivebtn_Click(object sender, EventArgs e)
        {
            String durationtxt = TimePicker.Value.ToString("hh.mm");
            String releasetxt = datePicker.Value.ToString("yyyy-MM-dd");
            if (movietxt.Text != String.Empty && movienametxt.Text != String.Empty && moviegenertxt.Text != String.Empty && durationtxt != String.Empty && youtubeurltxt.Text != String.Empty && synopisitxt.Text != String.Empty && posterurltxt.Text != String.Empty && languagetxt.Text != String.Empty && casttxt.Text != String.Empty && releasetxt != String.Empty && ratingtxt.Text != String.Empty) {
                da.SelectCommand = new SqlCommand("select * from mtable where movieid=@movieid", cs);
                da.SelectCommand.Parameters.Add("@movieid", SqlDbType.VarChar).Value = movietxt.Text;
                ds.Clear();
                da.Fill(ds);
                if (ds.Tables[0].Rows.Count == 0)
                {
                    try
                    {
                        da.InsertCommand = new SqlCommand("insert into mtable values (@movieid,@mname,@mgener,@mduration,@mlang,@mcast,@mrelease,@mrating,@youtubeurl,@posterurl,@msynopsis)", cs);
                        da.InsertCommand.Parameters.Add("movieid", SqlDbType.VarChar).Value = movietxt.Text;
                        da.InsertCommand.Parameters.Add("mname", SqlDbType.VarChar).Value = movienametxt.Text;
                        da.InsertCommand.Parameters.Add("mgener", SqlDbType.VarChar).Value = moviegenertxt.Text;
                        da.InsertCommand.Parameters.Add("mduration", SqlDbType.VarChar).Value = durationtxt+" Hrs";
                        da.InsertCommand.Parameters.Add("mlang", SqlDbType.VarChar).Value = languagetxt.Text;
                        da.InsertCommand.Parameters.Add("mcast", SqlDbType.VarChar).Value = casttxt.Text;
                        da.InsertCommand.Parameters.Add("mrelease", SqlDbType.VarChar).Value = releasetxt;
                        da.InsertCommand.Parameters.Add("mrating", SqlDbType.VarChar).Value = ratingtxt.Text;
                        da.InsertCommand.Parameters.Add("youtubeurl", SqlDbType.Text).Value = youtubeurltxt.Text;
                        da.InsertCommand.Parameters.Add("posterurl", SqlDbType.Text).Value = posterurltxt.Text;
                        da.InsertCommand.Parameters.Add("msynopsis", SqlDbType.Text).Value = synopisitxt.Text;
                        cs.Open();
                        da.InsertCommand.ExecuteNonQuery();
                        cs.Close();
                        MessageBox.Show("Entry Successfull for Movie Titled "+movienametxt.Text+".");
                        ds.Clear();
                        foreach (Control c in groupBox3.Controls)
                        {
                            if (c is TextBox)
                            {
                                c.Text = "";
                            }
                        }
                        da.SelectCommand = new SqlCommand("select mname from mtable ", cs);
                        ds1.Clear();
                        da.Fill(ds1);
                        mlistbx.DataSource = ds1.Tables[0];
                        mlistbx.DisplayMember = "mname";
                        foreach (Form f in Application.OpenForms)
                        {
                            if (f.Text == "home")
                            {
                                f.Close();
                                break;
                            }
                            if (f.Text == "BookM")
                            {
                                f.Close();
                                break;
                            }

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
                else
                    MessageBox.Show("Movieid Already Exist in Database");
            }else
                MessageBox.Show("Please Fill All Fields and Try Again.");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //MessageBox.Show(mlistbx.SelectedItem.value);
            //MessageBox.Show(mlistbx.SelectedIndex.ToString());
            DialogResult dr = MessageBox.Show("Are You Sure To Delete Movie Titled "+ ds1.Tables[0].Rows[mlistbx.SelectedIndex][0].ToString()+"?", "Warning", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    da.DeleteCommand = new SqlCommand("Delete from mtable where mname='"+ ds1.Tables[0].Rows[mlistbx.SelectedIndex][0].ToString() + "'", cs);
                    cs.Open();
                    da.DeleteCommand.ExecuteNonQuery();
                    cs.Close();
                    da.SelectCommand = new SqlCommand("select mname from mtable ", cs);
                    ds1.Clear();
                    da.Fill(ds1);
                    mlistbx.DataSource = ds1.Tables[0];
                    mlistbx.DisplayMember = "mname";

                }
                catch
                {
                    MessageBox.Show("Error Occured, Please Try Again");
                }

            }
            else
            {
                MessageBox.Show("Deletion Cancelled");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void displaybtn_Click(object sender, EventArgs e)
        {
           

        }

        private void movieGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void datePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            picturebox.Enabled = false;
            picturebox.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            videobox.Enabled = false;
            videobox.Visible = false;
            axShockwaveFlash1.Movie = null;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(posterurltxt.Text!= String.Empty)
            {
                pictureBox1.ImageLocation = posterurltxt.Text;
                picturebox.Enabled = true;
                picturebox.Visible = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (youtubeurltxt.Text!=String.Empty)
            {
                int i = youtubeurltxt.Text.IndexOf("=");
                String url= "https://www.youtube.com/v/" + youtubeurltxt.Text.Substring(i+1, youtubeurltxt.Text.Length-1-i);
                youtubeurltxt.Text = url;
                axShockwaveFlash1.Movie = youtubeurltxt.Text;
                videobox.Enabled = true;
                videobox.Visible = true;
                axShockwaveFlash1.Visible = true;
            }
            
        }
    }
}
