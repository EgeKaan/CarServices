using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarServices
{
    public partial class MaintenanceForm : Form
    {
        public MaintenanceForm(int aracid, int serviceID)
        {
            InitializeComponent();
            gelenAracID = aracid;
            gelenServiceID = serviceID;
        }
        int gelenAracID, aracBakımID, gelenServiceID;
        ServiceEntities vt = new ServiceEntities();
        MainForm mainForm;
        private void MaintenanceForm_Load(object sender, EventArgs e)
        {
            Clear(); 
            dgListele();            
        }


        private void btnIptal_Click(object sender, EventArgs e)
        {

            if (mainForm == null)
            {
                mainForm = new MainForm(gelenServiceID);
                mainForm.MdiParent = MdiParent;
                this.Close();
                mainForm.Show();
            }
            else mainForm.Activate();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Clear();
            dgListele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {   if(aracBakımID != 0)
                {
                    Bakım bakım1 = vt.Bakım.FirstOrDefault(p => p.BakımID == aracBakımID);
                    bakım1.ToplamTutar = Convert.ToInt32(txtToplamTutar.Text);
                    bakım1.AracID = gelenAracID;
                    bakım1.GirisTarihi = dtGiris.Value;
                    bakım1.CıkısTarihi = dtCıkıs.Value;
                    bakım1.OdemeTuru = txtOdemeTuru.Text;

                    int sonuc = vt.SaveChanges();
                    if (sonuc > 0)
                    {
                        MessageBox.Show("Güncelleme Başarılı!", "Tebrikler", MessageBoxButtons.OK);
                        Clear();
                        dgListele();
                        
                    }
                    else MessageBox.Show("Güncelleme Başarısız!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            else MessageBox.Show("Lütfen Kayıt Seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnYeniKayıt_Click(object sender, EventArgs e)
        {
            try
            {
                Bakım bakım1 = new Bakım();
                if (txtToplamTutar.Text !="") bakım1.ToplamTutar = Convert.ToInt32(txtToplamTutar.Text);
                bakım1.AracID = gelenAracID;
                bakım1.GirisTarihi = dtGiris.Value;
                bakım1.CıkısTarihi = dtCıkıs.Value;
                bakım1.OdemeTuru = txtOdemeTuru.Text;

                vt.Bakım.Add(bakım1);
                int sonuc = vt.SaveChanges();
                if (sonuc > 0)
                {
                    MessageBox.Show("Kayıt Başarılı", "Tebrikler", MessageBoxButtons.OK);
                    Clear();
                    dgListele();
                    
                }
            }
            catch (Exception)
            {
                    
            }
            

        }

        private void dgBakım_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        //void BakımListele()
        //{
        //    //dgBakım.DataSource = vt.Bakım.Where(p => p.AracID == gelenAracID).ToList();
        //    //dgBakım.Columns["AracID"].Visible = false;
        //    //dgBakım.Columns["Arac"].Visible = false;
        //    //dgBakım.Columns["Islems"].Visible = false;


        //    dgBakım.ColumnCount = 5;
        //    dgBakım.Columns[0].Name = "Bakım No";
        //    dgBakım.Columns[1].Name = "Girş Tarihi";
        //    dgBakım.Columns[2].Name = "Çıkış Tarihi";
        //    dgBakım.Columns[3].Name = "Toplam Tutar";
        //    dgBakım.Columns[4].Name = "Ödeme Türü";
        //    dgBakım.Columns[1].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;

        //    int counter = 1;

        //    var list = vt.Bakım.Where(p => p.BakımID == gelenAracID);
        //    foreach (var item in list)
        //    {
        //        string[] satir = new string[]
        //                  { counter.ToString(),item.GirisTarihi.ToString(),item.CıkısTarihi.ToString(),item.ToplamTutar.ToString()};
        //        dgBakım.Rows.Add(satir);

        //        counter++;
        //    }

        //}

        void Clear()
        {
            lblBakımID.Text = string.Empty;
            txtToplamTutar.Text = string.Empty;
            dtGiris.Value = DateTime.Now;
            dtCıkıs.Value = DateTime.Now;
            txtOdemeTuru.Text = string.Empty;
            dgBakım.Rows.Clear();
            dgBakım.Refresh();
        }

        ProcessForm processForm;
        private void btnDoldur_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(lblBakımID.Text))
                {
                    MessageBox.Show("Lütfen kayıtlar üzerinde seçim yapınız.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (processForm == null)
                    {
                        processForm = new ProcessForm(gelenAracID, aracBakımID, gelenServiceID);
                        processForm.MdiParent = MdiParent;
                        this.Close();
                        processForm.Show();
                    }
                    else processForm.Activate();
                }
            }
            catch (Exception)
            {

            }
        }

        private void dgBakım_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                lblBakımID.Text = string.Empty;
                txtToplamTutar.Text = string.Empty;
                dtGiris.Value = DateTime.Now;
                dtCıkıs.Value = DateTime.Now;
                txtOdemeTuru.Text = string.Empty;

                DataGridViewRow str = dgBakım.Rows[e.RowIndex];
                if (str.Cells[0].Value != null) lblBakımID.Text =str.Cells[0].Value.ToString();
                if (str.Cells[1].Value != null) 
                { 
                    string iGiris = str.Cells[1].Value.ToString();
                    DateTime oGiris = Convert.ToDateTime(iGiris);
                    dtGiris.Value = oGiris; 
                }
                if (str.Cells[2].Value != null)
                {
                    string iCıkıs = str.Cells[2].Value.ToString();
                    DateTime oCıkıs = Convert.ToDateTime(iCıkıs);
                    dtCıkıs.Value = oCıkıs;
                }
                if (str.Cells[3].Value != null) txtToplamTutar.Text = str.Cells[3].Value.ToString();
                if (str.Cells[4].Value != null) txtOdemeTuru.Text = str.Cells[4].Value.ToString();
                aracBakımID = Convert.ToInt32(str.Cells[5].Value);
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen kayıtlar üzerinde seçim yapınız.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        void dgListele()
        {
            dgBakım.ColumnCount = 6;
            dgBakım.Columns[0].Name = "Bakım No";
            dgBakım.Columns[1].Name = "Girş Tarihi";
            dgBakım.Columns[2].Name = "Çıkış Tarihi";
            dgBakım.Columns[3].Name = "Toplam Tutar";
            dgBakım.Columns[4].Name = "Ödeme Türü";
            dgBakım.Columns[5].Name = "BakımID";
            dgBakım.Columns[5].Visible = false; 

            int counter = 1;

            var list = vt.Bakım.Where(p => p.AracID == gelenAracID);
            foreach (var item in list)
            {
                string[] satir = new string[]
                          { counter.ToString(),item.GirisTarihi.ToString(),item.CıkısTarihi.ToString(),item.ToplamTutar.ToString(),item.OdemeTuru,item.BakımID.ToString()};
                dgBakım.Rows.Add(satir);

                counter++;
            }

        }
    }
}
