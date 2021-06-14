using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Printing;
using System.Drawing;
using System.Windows.Forms;
using System.Net;
using System.IO;


namespace BookMyshow
{
    class printtik
    {
        public Image Img;
        public String id;
        String title, date, time, price, theater, seat;
        public void print(Image img,String tid,String title,String date,String time,String price,String theater,String seat)
        {
            this.Img = img;
            this.id = tid;
            this.title = title;
            this.date = date;
            this.time = time;
            this.price = price;
            this.theater = theater;
            this.seat = seat;
            PrintDialog pd = new PrintDialog();
            PrintDocument pdoc = new PrintDocument();
            pd.Document = pdoc;
            pdoc.PrintPage += new PrintPageEventHandler(pdoc_PrintPage);
            
            pd.ShowDialog();
            pdoc.Print();

        }
        void pdoc_PrintPage(object sender, PrintPageEventArgs e)
        {

        //public String id;
        //String title, date, time, price, theater, seat;

        Graphics graphics = e.Graphics;
            //WebClient wc = new WebClient();
            //byte[] bytes = wc.DownloadData("https://i.annihil.us/u/prod/marvel/i/mg/4/c0/569e62f835d97/portrait_incredible.jpg");
            //MemoryStream ms = new MemoryStream(bytes);
            //System.Drawing.Image Img = System.Drawing.Image.FromStream(ms);
            Pen blackPen = new Pen(Color.Black, 1);
            graphics.DrawRectangle(blackPen,10, 110,250,300);
            try
            {
                graphics.DrawImage(Img, 15, 115, 240, 290);

            }
            catch
            {
                graphics.DrawString("n/a", new Font("Times new Roman", 50, FontStyle.Bold), new SolidBrush(Color.Black), 250, 95);
            }
            graphics.DrawRectangle(blackPen, 261, 110, 470+110, 300);
            graphics.DrawString("CineWatch", new Font("Times new Roman", 50, FontStyle.Bold), new SolidBrush(Color.Black), 250,20 );
            graphics.DrawString(title, new Font("Times new Roman", 16,FontStyle.Bold), new SolidBrush(Color.Black), 300, 205);
            graphics.DrawString("Tarih : "+ date + "    Saat: " + time, new Font("Courier New", 14), new SolidBrush(Color.Black), 300, 227);
            graphics.DrawString(theater, new Font("Courier New", 14), new SolidBrush(Color.Black), 300, 247 );
            graphics.DrawString("Koltuk: "+ seat, new Font("Courier New", 14), new SolidBrush(Color.Red), 300, 267 );
            graphics.DrawString("Bilet Id : MPTS"+id, new Font("Courier New", 14), new SolidBrush(Color.Black), 300, 287 );
            graphics.DrawString("Toplam Tutar : "+ price + "/-  ", new Font("Courier New", 14), new SolidBrush(Color.Black), 300, 307);

        }


    }
    }
