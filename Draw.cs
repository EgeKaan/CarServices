using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Metadata.Edm;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using System.Runtime.Remoting.Messaging;


namespace CarServices
{
    public partial class Draw : Form
    {
        public Draw()
        {
            InitializeComponent();
        }
        ServiceEntities vt = new ServiceEntities();
        string adSoyad, plaka, bakımNo, marka, model, km, telefon, girisTarihi, teslimTarihi; 
        string toplamTutar;
        int aracID,musteriID,counter;
        DateTime cıkıs,giris;
        private void Draw_Load(object sender, EventArgs e)
        {
            cbDoldur();   
            dataGridView1.DataSource = vt.Bakım.Where(p => p.BakımID == 1).ToList();

            dataGridView2.DataSource = vt.Islems.Where(p => p.BakımID == 1).ToList();

            try
            {
                var listBakım = vt.Bakım.Where(p => p.BakımID == 1);
                foreach (var item in listBakım)
                {
                    aracID = item.AracID.Value;
                    bakımNo = item.BakımID.ToString();
                    toplamTutar = item.ToplamTutar.Value.ToString();
                    cıkıs = item.CıkısTarihi.Value; teslimTarihi = cıkıs.ToShortDateString();
                    giris = item.GirisTarihi.Value; girisTarihi = giris.ToShortDateString();
                }

                var listArac = vt.Aracs.Where(p => p.AracID == aracID);
                foreach (var item in listArac)
                {
                    musteriID = item.MusteriID.Value;
                    plaka = item.Plaka;
                    marka = item.Marka;
                    model = item.Model;
                    km = item.Km;
                }

                var listMusteri = vt.Musteris.Where(p => p.MusteriID == musteriID);
                foreach (var item in listMusteri)
                {
                    adSoyad = item.AdSoyad;
                    telefon = item.Tel;
                }

                
            }
            catch (Exception)
            {

            }
        }


        private void btnSayfaAyarları_Click(object sender, EventArgs e)
        {
            pageSetupDialog1.ShowDialog();
        }

        private void btnBaskıOnizleme_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void btnYazdir_Click(object sender, EventArgs e)
        {
            DialogResult pdr = printDialog1.ShowDialog();
            if (pdr == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            
            Font myFont = new Font("Calibri", 14);
            SolidBrush sbrush = new SolidBrush(Color.Black);
            Pen myPen = new Pen(Color.Black);

            //e.Graphics.DrawImage(Properties.Resources.logo35, 115, 400);
            e.Graphics.DrawImage(Properties.Resources.logo200, 130, 400);
            //e.Graphics.DrawImage(Properties.Resources.logo30, 443, 35);
            //e.Graphics.DrawImage(Properties.Resources.logo30, 205, 450);
            //e.Graphics.DrawImage(Properties.Resources.logo30, 35, 850);
            // 342-240
            //e.Graphics.DrawLine(myPen, 10, 1, 10, 1160);
            //e.Graphics.DrawLine(myPen, 1, 10, 825, 10);

            //e.Graphics.DrawLine(myPen, 412, 1, 412, 1160);
            //e.Graphics.DrawLine(myPen, 1, 580, 825, 580);
            //e.Graphics.DrawLine(myPen, 1, 386, 825, 386);
            //e.Graphics.DrawLine(myPen, 1, 772, 825, 772);



            //x,y,x,y

            //e.Graphics.DrawLine(myPen, 100, 100, 400, 100);
            //e.Graphics.DrawLine(myPen, 100, 100, 100, 200);
            //e.Graphics.DrawLine(myPen, 100, 200, 400, 200);
            //e.Graphics.DrawLine(myPen, 400, 100, 400, 200);


            //RectangleF srcRect = new RectangleF(100.0F, 100.0F, 400.0F, 400.0F);
            //GraphicsUnit units = GraphicsUnit.Pixel;
            //float x = 100.0F;
            //float y = 100.0F;
            //// Draw image to screen.
            //e.Graphics.DrawImage(Properties.Resources.logo, x, y, srcRect, units);

            // Servis Bilgileri 
            e.Graphics.DrawImage(Properties.Resources.logo3, 280, 80);

            e.Graphics.DrawString("+90 (553) 728 25 27", myFont, sbrush, 329, 160);
            e.Graphics.DrawString("Bahçekapı Mah.Şaşmaz San.", myFont, sbrush, 310, 190);
            e.Graphics.DrawString("No: 5/3 (Başayar Plaza)", myFont, sbrush, 320, 215);
            e.Graphics.DrawString("Etimesgut/Ankara", myFont, sbrush, 330, 240);

            string tarih = "Tarih: " + DateTime.Now.ToShortDateString();
            e.Graphics.DrawLine(myPen, 70, 300, 750, 300);
            Font stringFont = new Font("Calibri", 12);
            e.Graphics.DrawString(tarih, stringFont, sbrush, 630, 275);

            // Taslak Form
            e.Graphics.DrawString("Ad Soyad", stringFont, sbrush, 90, 310); e.Graphics.DrawString(":", stringFont, sbrush, 155, 310);
            e.Graphics.DrawString("Marka   ", stringFont, sbrush, 90, 335); e.Graphics.DrawString(":", stringFont, sbrush, 155, 335);
            e.Graphics.DrawString("Telefon ", stringFont, sbrush, 90, 360); e.Graphics.DrawString(":", stringFont, sbrush, 155, 360);

            e.Graphics.DrawString("Plaka   ", stringFont, sbrush, 330, 310); e.Graphics.DrawString(":", stringFont, sbrush, 377, 310);
            e.Graphics.DrawString("Model   ", stringFont, sbrush, 330, 335); e.Graphics.DrawString(":", stringFont, sbrush, 377, 335);
            e.Graphics.DrawString("Giriş   ", stringFont, sbrush, 330, 360); e.Graphics.DrawString(":", stringFont, sbrush, 377, 360);

            e.Graphics.DrawString("Bakım No", stringFont, sbrush, 540, 310); e.Graphics.DrawString(":", stringFont, sbrush, 607, 310);
            e.Graphics.DrawString("Km      ", stringFont, sbrush, 540, 335); e.Graphics.DrawString(":", stringFont, sbrush, 607, 335);
            e.Graphics.DrawString("Teslim  ", stringFont, sbrush, 540, 360); e.Graphics.DrawString(":", stringFont, sbrush, 607, 360);

            // Araç Bilgileri
            e.Graphics.DrawString(adSoyad, stringFont, sbrush, 165, 310);
            e.Graphics.DrawString(marka, stringFont, sbrush, 165, 335);
            e.Graphics.DrawString(telefon, stringFont, sbrush, 165, 360);

            e.Graphics.DrawString(plaka, stringFont, sbrush, 387, 310);
            e.Graphics.DrawString(model, stringFont, sbrush, 387, 335);
            e.Graphics.DrawString(girisTarihi, stringFont, sbrush, 387, 360);

            e.Graphics.DrawString(bakımNo, stringFont, sbrush, 617, 310);
            e.Graphics.DrawString(km, stringFont, sbrush, 617, 335);
            e.Graphics.DrawString(teslimTarihi, stringFont, sbrush, 617, 360);


            e.Graphics.DrawLine(myPen, 70, 387, 750, 387);



            // Taslak İşlemler

            //int x1, y1, x2; 
            //x1 = 90; y1 = 480; x2 = 750; 
            int yAlt, yYazı;
            yAlt = 430; yYazı = 407;
            counter = 1;

            e.Graphics.DrawLine(myPen, 70, 400, 750, 400);

            e.Graphics.DrawString("", stringFont, sbrush, 91, 407);
            e.Graphics.DrawString("Ürün", stringFont, sbrush, 342, 407);
            e.Graphics.DrawString("Fiyat (₺)", stringFont, sbrush, 645, 407);

            // alt
            e.Graphics.DrawLine(myPen, 70, 430, 750, 430);
            
                
            // İşlemler
            var listIslem = vt.Islems.Where(p => p.BakımID == 1);
            foreach (var item in listIslem)
            {
                yYazı += 30; yAlt += 30;

                e.Graphics.DrawString(counter.ToString(),    stringFont, sbrush, 91,  yYazı);
                e.Graphics.DrawString(item.Islem1,           stringFont, sbrush, 150, yYazı);
                e.Graphics.DrawString(item.Tutar.ToString(), stringFont, sbrush, 645, yYazı);

                e.Graphics.DrawLine(myPen, 70, yAlt, 750, yAlt);
                counter++;
            }


            // dış    
            e.Graphics.DrawLine(myPen, 70, 400, 70, yAlt);
            e.Graphics.DrawLine(myPen, 750, 400, 750, yAlt);
            // iç
            e.Graphics.DrawLine(myPen, 130, 400, 130, yAlt);
            e.Graphics.DrawLine(myPen, 600, 400, 600, yAlt);


            yYazı += 50;
            // Toplam Tutar
            e.Graphics.DrawString("Toplam Tutar :", stringFont, sbrush, 530, yYazı);
            e.Graphics.DrawString(toplamTutar + " ₺", stringFont, sbrush, 640, yYazı);


            Font myFont2 = new Font("Calibri", 14, FontStyle.Bold);

            e.Graphics.DrawString("HUSTA MEKANİK SERVİS", myFont2, sbrush, 110, 1080);

            e.Graphics.DrawString("+90 (553) 728 25 27", myFont, sbrush, 130, 1110);

            e.Graphics.DrawString("Bahçekapı Mah.Şaşmaz San.", myFont, sbrush, 505, 1070);
            e.Graphics.DrawString("No: 5/3 (Başayar Plaza)", myFont, sbrush, 520, 1095);
            e.Graphics.DrawString("Etimesgut/Ankara", myFont, sbrush, 530, 1120);







        }

        void cbDoldur()
        {
            cbAylar.Items.Clear(); cbAylar.Items.Add("Eylül");
            cbAylar.Items.Add("Ekim"); cbAylar.Items.Add("Kasım"); cbAylar.Items.Add("Aralık");
            cbAylar.Items.Add("Ocak"); cbAylar.Items.Add("Şubat"); cbAylar.Items.Add("Mart");
            cbAylar.Items.Add("Nisan"); cbAylar.Items.Add("Mayıs"); cbAylar.Items.Add("Haziran");
            cbAylar.Items.Add("Temmuz"); cbAylar.Items.Add("Ağustos");
        }
    }
}
