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
using System.Drawing.Printing;



namespace BookMyshow
{
    public partial class BookM : Form
    {
        SqlConnection cs = new SqlConnection("Data Source='DESKTOP-RPQ1FVH\\SQLEXPRESS';initial catalog= bookshow;integrated Security=true");
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        DataSet ds1 = new DataSet();
        DataSet ds2 = new DataSet();
        DataSet ds3 = new DataSet();
        DataSet ds4 = new DataSet();
        DataSet ds5 = new DataSet();
        DataSet ds6 = new DataSet();
        DataSet ds7 = new DataSet();
        DataSet ds8 = new DataSet();
        DataSet ds9 = new DataSet();

        DataSet ds10 = new DataSet();




        public BookM(string moname)
        {
            InitializeComponent();
            timer1.Start();
            DateTime today = DateTime.Today;
            da.SelectCommand = new SqlCommand("select DISTINCT mname from mtable1 where date >= '" + today.ToString("yyyy-MM-dd") + "' ", cs);
            ds.Clear();
            da.Fill(ds);
            comboBox3.DataSource = ds.Tables[0];
            comboBox3.DisplayMember = "mname";
            listBox1.Items.Clear();

            if (moname != "")
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    if (ds.Tables[0].Rows[i][0].ToString() == moname)
                    {
                        comboBox3.SelectedIndex = i;

                    }
                }

            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BookM_Load(object sender, EventArgs e)
        {
          
                try
                {
                    da.SelectCommand = new SqlCommand("select wallet from usersdl where Username='" + log.username + "' ", cs);
                    ds7.Clear();
                    da.Fill(ds7);
                    walletamt.Text = ds7.Tables[0].Rows[0][0].ToString();
                }
                   catch { }
            
        }

        private void radioButton4_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label15.Text = DateTime.Now.ToString("M/d/yyyy");
            time.Text = DateTime.Now.ToString("h:m:s");

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;
            string names;
            names = ds.Tables[0].Rows[comboBox3.SelectedIndex][0].ToString();
            da.SelectCommand = new SqlCommand("select DISTINCT date from mtable1 where mname='" + names + "' and date >= '"+ today.ToString("yyyy-MM-dd") + "' ", cs);
            ds1.Clear();
            da.Fill(ds1);
            comboBox2.DataSource = ds1.Tables[0];
            comboBox2.DisplayMember = "date";
            comboBox2.SelectedIndex = -1;
            comboBox4.SelectedIndex = -1;
            comboBox1.SelectedIndex = -1;
            listBox1.Items.Clear();
            foreach (Control c in this.groupBox2.Controls)
            {
                if (c is Button)
                {
                    c.BackColor = Color.White;
                    c.Enabled = false;

                }
            }
            pecpricelbl.Text = "";
            prepriselbl.Text = "";
            stpricelbl.Text = "";


            }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string names;
                names = ds.Tables[0].Rows[comboBox3.SelectedIndex][0].ToString();
                string dates;
                dates = ds1.Tables[0].Rows[comboBox2.SelectedIndex][0].ToString();
                da.SelectCommand = new SqlCommand("select DISTINCT tname from mtable1 where date='" + dates + "'and mname='" + names + "' ", cs);
                ds2.Clear();
                da.Fill(ds2);
                comboBox1.DataSource = ds2.Tables[0];
                comboBox1.DisplayMember = "tname";
                label11.Text = "";
                comboBox1.SelectedIndex = -1;
                comboBox4.SelectedIndex = -1;
                pecpricelbl.Text = "";
                listBox1.Items.Clear();
                prepriselbl.Text = "";
                stpricelbl.Text = "";


            }
            catch
            {
                label11.Text = "Lütfen Bekleyin";
            }
            foreach (Control c in this.groupBox2.Controls)
            {
                if (c is Button)
                {
                    c.BackColor = Color.White;
                    c.Enabled = false;

                }
            }

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string names;
                names = ds.Tables[0].Rows[comboBox3.SelectedIndex][0].ToString();
                string dates;
                dates = ds1.Tables[0].Rows[comboBox2.SelectedIndex][0].ToString();
                string tname;
                tname = ds2.Tables[0].Rows[comboBox1.SelectedIndex][0].ToString();

                da.SelectCommand = new SqlCommand("select time,ts_id from mtable1 where date='" + dates + "'and mname='" + names + "'and tname='" + tname + "' order by time", cs);
                ds3.Clear();
                da.Fill(ds3);

                comboBox4.DataSource = ds3.Tables[0];
                comboBox4.DisplayMember = "time";
                label11.Text = "";
                comboBox4.SelectedIndex = -1;
                pecpricelbl.Text = "";
                prepriselbl.Text = "";
                stpricelbl.Text = "";
                listBox1.Items.Clear();
                foreach (Control c in this.groupBox2.Controls)
                {
                    if (c is Button)
                    {
                        c.BackColor = Color.White;
                        c.Enabled = false;

                    }
                }
            }
            catch
            {
                label11.Text = "Lütfen Bekleyin";
            }
        }
        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string ts_id;
            try
            {
                ts_id = ds3.Tables[0].Rows[comboBox4.SelectedIndex][1].ToString();
                da.SelectCommand = new SqlCommand("select s_price,p_price,r_price from mtable1 where ts_id='" + ts_id + "'", cs);
                ds5.Clear();
                da.Fill(ds5);
                pecpricelbl.Text = ds5.Tables[0].Rows[0][0].ToString();
                prepriselbl.Text = ds5.Tables[0].Rows[0][1].ToString();
                stpricelbl.Text = ds5.Tables[0].Rows[0][2].ToString();
            }
            catch
            {
            }
            try
            {
                ts_id = ds3.Tables[0].Rows[comboBox4.SelectedIndex][1].ToString();
                da.SelectCommand = new SqlCommand("select * from mtable2 where ts_id='" + ts_id + "'", cs);
                ds4.Clear();
                da.Fill(ds4);
                for (int i = 1; i < 7; i++)
                {

                    foreach (Control c in this.groupBox2.Controls)
                    {



                        if (c.Text == "A" + i)
                        {


                            if (ds4.Tables[0].Rows[0][i].ToString() != "0")
                            {
                                c.Enabled = false;
                                c.BackColor = Color.Red;
                            }
                            else
                            {
                                c.Enabled = true;
                                c.BackColor = Color.White;


                            }

                        }


                    }

                }

                for (int i = 7; i < 15; i++)
                {

                    foreach (Control c in this.groupBox2.Controls)
                    {



                        if (c.Text == "B" + (i - 6))
                        {


                            if (ds4.Tables[0].Rows[0][i].ToString() != "0")
                            {
                                c.Enabled = false;
                                c.BackColor = Color.Red;
                            }
                            else
                            {
                                c.Enabled = true;
                                c.BackColor = Color.White;


                            }

                        }


                    }

                }
                for (int i = 15; i < 24; i++)
                {

                    foreach (Control c in this.groupBox2.Controls)
                    {



                        if (c.Text == "C" + (i - 14))
                        {


                            if (ds4.Tables[0].Rows[0][i].ToString() != "0")
                            {
                                c.Enabled = false;
                                c.BackColor = Color.Red;
                            }
                            else
                            {
                                c.Enabled = true;
                                c.BackColor = Color.White;


                            }

                        }


                    }

                }

                label11.Text = "";
            }
            catch
            {
                label11.Text = "Lütfen Bekleyin";
            }

        }



        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void B1_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Contains("B1"))
            {
                B1.BackColor = Color.White;
                listBox1.Items.Remove("B1");
                label2.Text = (int.Parse(label2.Text) - int.Parse(prepriselbl.Text)).ToString();
            }
            else
            {
                B1.BackColor = Color.LightGreen;
                listBox1.Items.Add("B1");
                label2.Text = (int.Parse(label2.Text) + int.Parse(prepriselbl.Text)).ToString();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void A1_Click_1(object sender, EventArgs e)
        {
            if (listBox1.Items.Contains("A1"))
            {
                A1.BackColor = Color.White;
                listBox1.Items.Remove("A1");
                label2.Text = (int.Parse(label2.Text) - int.Parse(stpricelbl.Text)).ToString();
            }
            else
            {
                A1.BackColor = Color.LightGreen;
                listBox1.Items.Add("A1");
                label2.Text = (int.Parse(label2.Text) + int.Parse(stpricelbl.Text)).ToString();
            }

        }

        private void A2_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Contains("A2"))
            {
                A2.BackColor = Color.White;
                listBox1.Items.Remove("A2");
                label2.Text = (int.Parse(label2.Text) - int.Parse(stpricelbl.Text)).ToString();
            }
            else
            {
                A2.BackColor = Color.LightGreen;
                listBox1.Items.Add("A2");
                label2.Text = (int.Parse(label2.Text) + int.Parse(stpricelbl.Text)).ToString();
            }
        }

        private void A5_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Contains("A5"))
            {
                A5.BackColor = Color.White;
                listBox1.Items.Remove("A5");
                label2.Text = (int.Parse(label2.Text) - int.Parse(stpricelbl.Text)).ToString();
            }
            else
            {
                A5.BackColor = Color.LightGreen;
                listBox1.Items.Add("A5");
                label2.Text = (int.Parse(label2.Text) + int.Parse(stpricelbl.Text)).ToString();
            }
        }

        private void A4_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Contains("A4"))
            {
                A4.BackColor = Color.White;
                listBox1.Items.Remove("A4");
                label2.Text = (int.Parse(label2.Text) - int.Parse(stpricelbl.Text)).ToString();
            }
            else
            {
                A4.BackColor = Color.LightGreen;
                listBox1.Items.Add("A4");
                label2.Text = (int.Parse(label2.Text) + int.Parse(stpricelbl.Text)).ToString();
            }
        }

        private void A3_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Contains("A3"))
            {
                A3.BackColor = Color.White;
                listBox1.Items.Remove("A3");
                label2.Text = (int.Parse(label2.Text) - int.Parse(stpricelbl.Text)).ToString();
            }
            else
            {
                A3.BackColor = Color.LightGreen;
                listBox1.Items.Add("A3");
                label2.Text = (int.Parse(label2.Text) + int.Parse(stpricelbl.Text)).ToString();
            }
        }

        private void A6_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Contains("A6"))
            {
                A6.BackColor = Color.White;
                listBox1.Items.Remove("A6");
                label2.Text = (int.Parse(label2.Text) - int.Parse(stpricelbl.Text)).ToString();
            }
            else
            {
                A6.BackColor = Color.LightGreen;
                listBox1.Items.Add("A6");
                label2.Text = (int.Parse(label2.Text) + int.Parse(stpricelbl.Text)).ToString();
            }
        }

        private void C8_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Contains("C8"))
            {
                C8.BackColor = Color.White;
                listBox1.Items.Remove("C8");
                label2.Text = (int.Parse(label2.Text) - int.Parse(pecpricelbl.Text)).ToString();
            }
            else
            {
                C8.BackColor = Color.LightGreen;
                listBox1.Items.Add("C8");
                label2.Text = (int.Parse(label2.Text) + int.Parse(pecpricelbl.Text)).ToString();
            }
        }

        private void B7_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Contains("B7"))
            {
                B7.BackColor = Color.White;
                listBox1.Items.Remove("B7");
                label2.Text = (int.Parse(label2.Text) - int.Parse(prepriselbl.Text)).ToString();
            }
            else
            {
                B7.BackColor = Color.LightGreen;
                listBox1.Items.Add("B7");
                label2.Text = (int.Parse(label2.Text) + int.Parse(prepriselbl.Text)).ToString();
            }
        }

        private void B6_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Contains("B6"))
            {
                B6.BackColor = Color.White;
                listBox1.Items.Remove("B6");
                label2.Text = (int.Parse(label2.Text) - int.Parse(prepriselbl.Text)).ToString();
            }
            else
            {
                B6.BackColor = Color.LightGreen;
                listBox1.Items.Add("B6");
                label2.Text = (int.Parse(label2.Text) + int.Parse(prepriselbl.Text)).ToString();
            }
        }

        private void B5_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Contains("B5"))
            {
                B5.BackColor = Color.White;
                listBox1.Items.Remove("B5");
                label2.Text = (int.Parse(label2.Text) - int.Parse(prepriselbl.Text)).ToString();
            }
            else
            {
                B5.BackColor = Color.LightGreen;
                listBox1.Items.Add("B5");
                label2.Text = (int.Parse(label2.Text) + int.Parse(prepriselbl.Text)).ToString();
            }
        }

        private void B4_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Contains("B4"))
            {
                B4.BackColor = Color.White;
                listBox1.Items.Remove("B4");
                label2.Text = (int.Parse(label2.Text) - int.Parse(prepriselbl.Text)).ToString();
            }
            else
            {
                B4.BackColor = Color.LightGreen;
                listBox1.Items.Add("B4");
                label2.Text = (int.Parse(label2.Text) + int.Parse(prepriselbl.Text)).ToString();
            }
        }

        private void B3_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Contains("B3"))
            {
                B3.BackColor = Color.White;
                listBox1.Items.Remove("B3");
                label2.Text = (int.Parse(label2.Text) - int.Parse(prepriselbl.Text)).ToString();
            }
            else
            {
                B3.BackColor = Color.LightGreen;
                listBox1.Items.Add("B3");
                label2.Text = (int.Parse(label2.Text) + int.Parse(prepriselbl.Text)).ToString();
            }
        }

        private void B2_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Contains("B2"))
            {
                B2.BackColor = Color.White;
                listBox1.Items.Remove("B2");
                label2.Text = (int.Parse(label2.Text) - int.Parse(prepriselbl.Text)).ToString();
            }
            else
            {
                B2.BackColor = Color.LightGreen;
                listBox1.Items.Add("B2");
                label2.Text = (int.Parse(label2.Text) + int.Parse(prepriselbl.Text)).ToString();
            }
        }

        private void C3_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Contains("C3"))
            {
                C3.BackColor = Color.White;
                listBox1.Items.Remove("C3");
                label2.Text = (int.Parse(label2.Text) - int.Parse(pecpricelbl.Text)).ToString();
            }
            else
            {
                C3.BackColor = Color.LightGreen;
                listBox1.Items.Add("C3");
                label2.Text = (int.Parse(label2.Text) + int.Parse(pecpricelbl.Text)).ToString();
            }
        }

        private void C1_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Contains("C1"))
            {
                C1.BackColor = Color.White;
                listBox1.Items.Remove("C1");
                label2.Text = (int.Parse(label2.Text) - int.Parse(pecpricelbl.Text)).ToString();
            }
            else
            {
                C1.BackColor = Color.LightGreen;
                listBox1.Items.Add("C1");
                label2.Text = (int.Parse(label2.Text) + int.Parse(pecpricelbl.Text)).ToString();
            }
        }

        private void C2_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Contains("C2"))
            {
                C2.BackColor = Color.White;
                listBox1.Items.Remove("C2");
                label2.Text = (int.Parse(label2.Text) - int.Parse(pecpricelbl.Text)).ToString();
            }
            else
            {
                C2.BackColor = Color.LightGreen;
                listBox1.Items.Add("C2");
                label2.Text = (int.Parse(label2.Text) + int.Parse(pecpricelbl.Text)).ToString();
            }
        }

        private void C4_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Contains("C4"))
            {
                C4.BackColor = Color.White;
                listBox1.Items.Remove("C4");
                label2.Text = (int.Parse(label2.Text) - int.Parse(pecpricelbl.Text)).ToString();
            }
            else
            {
                C4.BackColor = Color.LightGreen;
                listBox1.Items.Add("C4");
                label2.Text = (int.Parse(label2.Text) + int.Parse(pecpricelbl.Text)).ToString();
            }
        }

        private void C5_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Contains("C5"))
            {
                C5.BackColor = Color.White;
                listBox1.Items.Remove("C5");
                label2.Text = (int.Parse(label2.Text) - int.Parse(pecpricelbl.Text)).ToString();
            }
            else
            {
                C5.BackColor = Color.LightGreen;
                listBox1.Items.Add("C5");
                label2.Text = (int.Parse(label2.Text) + int.Parse(pecpricelbl.Text)).ToString();
            }
        }

        private void C6_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Contains("C6"))
            {
                C6.BackColor = Color.White;
                listBox1.Items.Remove("C6");
                label2.Text = (int.Parse(label2.Text) - int.Parse(pecpricelbl.Text)).ToString();
            }
            else
            {
                C6.BackColor = Color.LightGreen;
                listBox1.Items.Add("C6");
                label2.Text = (int.Parse(label2.Text) + int.Parse(pecpricelbl.Text)).ToString();
            }
        }

        private void C7_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Contains("C7"))
            {
                C7.BackColor = Color.White;
                listBox1.Items.Remove("C7");
                label2.Text = (int.Parse(label2.Text) - int.Parse(pecpricelbl.Text)).ToString();
            }
            else
            {
                C7.BackColor = Color.LightGreen;
                listBox1.Items.Add("C7");
                label2.Text = (int.Parse(label2.Text) + int.Parse(pecpricelbl.Text)).ToString();
            }
        }

        private void B8_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Contains("B8"))
            {
                B8.BackColor = Color.White;
                listBox1.Items.Remove("B8");
                label2.Text = (int.Parse(label2.Text) - int.Parse(prepriselbl.Text)).ToString();
            }
            else
            {
                B8.BackColor = Color.LightGreen;
                listBox1.Items.Add("B8");
                label2.Text = (int.Parse(label2.Text) + int.Parse(prepriselbl.Text)).ToString();
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            //printtik pr = new printtik();
            //pr.print();
            string confmt = "";
            String totalamt=label2.Text;
            mdihome mh = new mdihome();
            if (log.username != "" && log.pwd != "" && log.username != null && log.username != String.Empty && log.pwd != null && log.pwd != String.Empty)
            {
                int cout=0;
                foreach (Control s in this.groupBox2.Controls)
                {

                    if (s.BackColor == Color.LightGreen)
                    {
                        if (cout==0)
                        {
                            confmt = (confmt + s.Text).ToString();
                            cout++;
                        }
                        confmt = (confmt+", " + s.Text).ToString();


                    }
                }
                if (confmt != "")
                {
                    DialogResult dir = MessageBox.Show("Seçilen Koltuklar:" + confmt + ". Onaylamak için Evet'e Tıklayın.", "Uyarı", MessageBoxButtons.YesNo);
                if (dir == DialogResult.Yes)
                {
                    if ((int.Parse(walletamt.Text) < int.Parse(label2.Text)))
                    {
                        Payment p = new Payment((int.Parse(label2.Text) - int.Parse(walletamt.Text)).ToString() + "/-");
                        if (p.ShowDialog(this) == DialogResult.OK)
                        {
                            try
                            {
                                da.UpdateCommand = new SqlCommand("update usersdl set wallet=0 where Username='" + log.username + "';", cs);
                                cs.Open();
                                da.UpdateCommand.ExecuteNonQuery();
                                cs.Close();
                                walletamt.Text = "0";



                            }
                            catch { }


                            foreach (Control s in this.groupBox2.Controls)
                            {

                                if (s.BackColor == Color.LightGreen)
                                {
                                    for (int k = 1; k < 25; k++)
                                    {
                                        if (k < 7 && s.Text == ("A" + k))
                                        {
                                            string ts_id = ds3.Tables[0].Rows[comboBox4.SelectedIndex][1].ToString();
                                            da.UpdateCommand = new SqlCommand("update mtable2 set " + s.Text + " = 1  where ts_id='" + ts_id + "'", cs);
                                            cs.Open();
                                            da.UpdateCommand.ExecuteNonQuery();
                                            cs.Close();
                                            listBox1.Items.Remove(s.Text);
                                            label2.Text = "0";

                                        }
                                        else if (k < 15 && s.Text == "B" + (k - 6))
                                        {
                                            string ts_id = ds3.Tables[0].Rows[comboBox4.SelectedIndex][1].ToString();
                                            da.UpdateCommand = new SqlCommand("update mtable2 set " + s.Text + "=1  where ts_id='" + ts_id + "'", cs);
                                            cs.Open();
                                            da.UpdateCommand.ExecuteNonQuery();
                                            cs.Close();
                                            listBox1.Items.Remove(s.Text);
                                            label2.Text = "0";
                                        }
                                        else if (k < 25 && s.Text == "C" + (k - 14))
                                        {




                                            string ts_id = ds3.Tables[0].Rows[comboBox4.SelectedIndex][1].ToString();
                                            da.UpdateCommand = new SqlCommand("update mtable2 set " + s.Text + "=1  where ts_id='" + ts_id + "'", cs);
                                            cs.Open();
                                            da.UpdateCommand.ExecuteNonQuery();
                                            cs.Close();
                                            listBox1.Items.Remove(s.Text);
                                            label2.Text = "0";

                                        }
                                        else
                                        {
                                            continue;
                                        }

                                    }

                                }


                            }
                            MessageBox.Show("Bizi Tercih Ettiğiniz İçin Teşekkürler , İyi Seyirler.");





                                da.SelectCommand = new SqlCommand("SELECT posterurl FROM mtable WHERE mname='"+ ds.Tables[0].Rows[comboBox3.SelectedIndex][0].ToString() + "'", cs);
                                ds9.Clear();
                                da.Fill(ds9);
                                string purl = ds9.Tables[0].Rows[0][0].ToString();
                                da.SelectCommand = new SqlCommand("SELECT max(id) FROM booked", cs);
                                ds10.Clear();
                                da.Fill(ds10);

                                int maxid = int.Parse(ds10.Tables[0].Rows[0][0].ToString()) + 1;
                                da.InsertCommand = new SqlCommand("insert into booked values (" + maxid + ",'" + log.username + "','" + ds.Tables[0].Rows[comboBox3.SelectedIndex][0].ToString() + "','" + purl + "','" + (ds1.Tables[0].Rows[comboBox2.SelectedIndex][0].ToString()).Substring(0,9)+ "','"+ds3.Tables[0].Rows[comboBox4.SelectedIndex][0].ToString()+"'," + totalamt + ",'"+ds2.Tables[0].Rows[comboBox1.SelectedIndex][0].ToString()+"','" + confmt+"')", cs);
                                cs.Open();
                                da.InsertCommand.ExecuteNonQuery();
                                cs.Close();


                                int i = comboBox4.SelectedIndex;
                            comboBox4.SelectedIndex = i - 1;
                            comboBox4.SelectedIndex = i;
                            label2.Text = "0";



                        }
                        else
                            MessageBox.Show("Ödeme Başarısız, Lütfen Tekrar Deneyin.");
                    }
                    else
                    {
                        try
                        {

                            da.UpdateCommand = new SqlCommand("update usersdl set wallet='" + (int.Parse(walletamt.Text) - int.Parse(label2.Text)).ToString() + "'where Username='" + log.username + "';", cs);
                            cs.Open();
                            da.UpdateCommand.ExecuteNonQuery();
                            cs.Close();
                            walletamt.Text = (int.Parse(walletamt.Text) - int.Parse(label2.Text)).ToString();
                        }
                        catch { }

                        foreach (Control s in this.groupBox2.Controls)
                        {

                            if (s.BackColor == Color.LightGreen)
                            {
                                confmt = (confmt + s.Text + ", ").ToString();
                            }
                        }
                        foreach (Control s in this.groupBox2.Controls)
                        {

                            if (s.BackColor == Color.LightGreen)
                            {
                                for (int k = 1; k < 25; k++)
                                {
                                    if (k < 7 && s.Text == ("A" + k))
                                    {
                                        string ts_id = ds3.Tables[0].Rows[comboBox4.SelectedIndex][1].ToString();
                                        da.UpdateCommand = new SqlCommand("update mtable2 set " + s.Text + " = 1  where ts_id='" + ts_id + "'", cs);
                                        cs.Open();
                                        da.UpdateCommand.ExecuteNonQuery();
                                        cs.Close();
                                        listBox1.Items.Remove(s.Text);
                                        label2.Text = "0";

                                    }
                                    else if (k < 15 && s.Text == "B" + (k - 6))
                                    {
                                        string ts_id = ds3.Tables[0].Rows[comboBox4.SelectedIndex][1].ToString();
                                        da.UpdateCommand = new SqlCommand("update mtable2 set " + s.Text + "=1  where ts_id='" + ts_id + "'", cs);
                                        cs.Open();
                                        da.UpdateCommand.ExecuteNonQuery();
                                        cs.Close();
                                        listBox1.Items.Remove(s.Text);
                                        label2.Text = "0";
                                    }
                                    else if (k < 25 && s.Text == "C" + (k - 14))
                                    {




                                        string ts_id = ds3.Tables[0].Rows[comboBox4.SelectedIndex][1].ToString();
                                        da.UpdateCommand = new SqlCommand("update mtable2 set " + s.Text + "=1  where ts_id='" + ts_id + "'", cs);
                                        cs.Open();
                                        da.UpdateCommand.ExecuteNonQuery();
                                        cs.Close();
                                        listBox1.Items.Remove(s.Text);
                                        label2.Text = "0";

                                    }
                                    else
                                    {
                                        continue;
                                    }

                                }

                            }


                        }
                        MessageBox.Show("Bizi Tercih Ettiğiniz İçin Teşekkürler , İyi Seyirler.");
                        int i = comboBox4.SelectedIndex;
                        comboBox4.SelectedIndex = i - 1;
                        comboBox4.SelectedIndex = i;
                        label2.Text = "0";





                    }

                }
            }
            }
            else
                MessageBox.Show("Lütfen İlk Önce Giriş Yapın, Hesabınız Yoksa Kaydolun.");

                
                
                
          
            

            
        }

        private void addwall_Click(object sender, EventArgs e)
        {
            Payment p = new Payment(wallettxt.Text+"/-");
            if (log.username != "" && log.pwd != "" && log.username != null && log.username != String.Empty && log.pwd != null && log.pwd != String.Empty)
            {
                if (wallettxt.Text != "")
                {
                    if (p.ShowDialog(this) == DialogResult.OK)
                    {
                        try
                        {
                                da.UpdateCommand = new SqlCommand("update usersdl set wallet=" + (int.Parse(walletamt.Text) + int.Parse(wallettxt.Text)).ToString() + " where Username='"+log.username+"';", cs);
                                cs.Open();
                                da.UpdateCommand.ExecuteNonQuery();
                                cs.Close();
                                walletamt.Text = (int.Parse(walletamt.Text) + int.Parse(wallettxt.Text)).ToString();
                                MessageBox.Show("Ödeme Başarılı. Yeni Cüzdan Bakiyeniz: " + walletamt.Text);
                           


                            // st = ds6.Tables[0].Rows[0][0].ToString();
                            // da.UpdateCommand = new SqlCommand("update usersdl set wallet='" + (int.Parse(walletamt.Text) + int.Parse(wallettxt.Text)).ToString() + "'where login_st=1 ", cs);
                            // cs.Open();

                            // da.UpdateCommand.ExecuteNonQuery();
                            // cs.Close();
                            // walletamt.Text = (int.Parse(walletamt.Text) + int.Parse(wallettxt.Text)).ToString();
                            // MessageBox.Show("Payment Successfull, You New Wallet Balance Is : " + walletamt.Text);

                        }
                        catch { }
                        //da.UpdateCommand = new SqlCommand("update usersdl set wallet='" + ( int.Parse(walletamt.Text) + int.Parse(wallettxt.Text )).ToString() + "'where login_st=1 ", cs);
                        //    cs.Open();

                        //    da.UpdateCommand.ExecuteNonQuery();
                        //    cs.Close();
                        //walletamt.Text = (int.Parse(walletamt.Text) + int.Parse(wallettxt.Text)).ToString();
                    }
                    else
                        MessageBox.Show("Ödeme Başarısız, Lütfen Tekrar Deneyin.");
                }
                else
                {
                    MessageBox.Show("Lütfen Cüzdana Eklenecek Tutarı Girin:");
                }


            }
            else
                MessageBox.Show("Lütfen İlk Önce Giriş Yapın, Hesabınız Yoksa Kaydolun.");


        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
