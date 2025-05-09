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
    public partial class CarRegisterForm : Form
    {
        string gelenVeri;
        public CarRegisterForm(string kontrol,int serviceid)
        {
            InitializeComponent();
            gelenVeri = kontrol;
            gelenServiceID = serviceid;
        }
        ServiceEntities vt = new ServiceEntities();
        int gelenServiceID;
        MainForm mainForm;
        private void CarRegisterForm_Load(object sender, EventArgs e)
        {
            if (gelenVeri == "YeniKayıt")
            {
                musteriID = vt.Musteris.Max(p => p.MusteriID);
                YeniKayıtID(musteriID);
                groupBox1.Visible = false;
                dgMusteri.Visible = false;
            }
            else if (gelenVeri == "AracKayıt")
            {
                rbAdSoyad.Checked = true;
                groupBox1.Visible = true;
                dgMusteri.Visible = true;
                MusteriListele();
            }
            else if (gelenVeri == "AracGuncelle")
            {
                rbAdSoyad.Checked = true;
                groupBox1.Visible = true;
                dgMusteri.Visible = true;
                MusteriListele();
            }
        }

        int musteriID = 0;
        int secilenAracID = 0;

        
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Clear();
            lblMusteriAdSoyad.Text = string.Empty;
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

        private void btnGuncelle_Click(object sender, EventArgs e)
        {

            try
            {
                if (secilenAracID != 0)
                {
                    Arac arac1 = vt.Aracs.FirstOrDefault(p => p.AracID == secilenAracID);
                    arac1.Plaka = txtPlaka.Text;
                    arac1.Marka = txtMarka.Text;
                    arac1.Yakıt = txtYakıt.Text;
                    arac1.Km = txtKm.Text;
                    arac1.Model = txtModel.Text;
                    arac1.ModelYılı = txtModelYılı.Text;
                    arac1.MotorNo = txtMotorNo.Text;
                    arac1.RuhsatNo = txtRuhsatNo.Text;
                    arac1.SaseNo = txtSaseNo.Text;
                    arac1.MusteriID = musteriID;
                    arac1.ServiceID = gelenServiceID;

                    int sonuc = vt.SaveChanges();
                    if (sonuc > 0)
                    {
                        MessageBox.Show("Kayıt Başarılı", "Tebrikler", MessageBoxButtons.OK);
                        dgAraclar.DataSource = vt.Aracs.Where(p => p.MusteriID == musteriID).ToList();
                        Clear();
                        lblMusteriAdSoyad.Enabled = false;
                        lblMusteriAdSoyad.Text = string.Empty;
                    }
                    else MessageBox.Show("Kayıt Başarısız", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else MessageBox.Show("Kayıt Seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {

            }

        }
        
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            //int aracID = vt.Aracs.Max(p => p.AracID);
            //int musteriID = 0;

            //var araclar = vt.Aracs.Where(p => p.AracID == aracID);
            //foreach (var item in araclar)
            //{
            //    musteriID = 0;
            //    musteriID = Convert.ToInt32(item.MusteriID.Value);
            //}

            try
            {
                if (string.IsNullOrEmpty(txtPlaka.Text) || string.IsNullOrEmpty(txtRuhsatNo.Text))
                {
                    MessageBox.Show("Verileri Doldurunuz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                    
                else
                {
                    Arac arac1 = new Arac();
                    arac1.Plaka = txtPlaka.Text;
                    arac1.Marka = txtMarka.Text;
                    arac1.Yakıt = txtYakıt.Text;
                    arac1.Km = txtKm.Text;
                    arac1.Model = txtModel.Text;
                    arac1.ModelYılı = txtModelYılı.Text;
                    arac1.MotorNo = txtMotorNo.Text;
                    arac1.RuhsatNo = txtRuhsatNo.Text;
                    arac1.SaseNo = txtSaseNo.Text;
                    arac1.MusteriID = musteriID;
                    arac1.ServiceID = gelenServiceID;

                    vt.Aracs.Add(arac1);

                    int sonuc = vt.SaveChanges();
                    if (sonuc > 0)
                    {
                        MessageBox.Show("Kayıt Başarılı!", "Tebrikler", MessageBoxButtons.OK);
                        dgAraclar.DataSource = vt.Aracs.Where(p => p.MusteriID == musteriID).ToList();
                        AraclariListele();
                        Clear();
                        lblMusteriAdSoyad.Enabled = false;
                        lblMusteriAdSoyad.Text = string.Empty;
                    }
                    else MessageBox.Show("Kayıt Başarısız!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            catch (Exception)
            {

            }
            
        }  

        private void dgAraclar_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Clear();
                DataGridViewRow str = dgAraclar.Rows[e.RowIndex];
                if (str.Cells[0].Value != null) secilenAracID = Convert.ToInt32(str.Cells[0].Value);
                if (str.Cells[1].Value != null) txtPlaka.Text = str.Cells[1].Value.ToString();
                if (str.Cells[2].Value != null) txtSaseNo.Text = str.Cells[2].Value.ToString();
                if (str.Cells[3].Value != null) txtMarka.Text = str.Cells[3].Value.ToString();
                if (str.Cells[4].Value != null) txtModel.Text = str.Cells[4].Value.ToString();
                if (str.Cells[5].Value != null) txtModelYılı.Text = str.Cells[5].Value.ToString();
                if (str.Cells[6].Value != null) txtKm.Text = str.Cells[6].Value.ToString();
                if (str.Cells[7].Value != null) txtRuhsatNo.Text = str.Cells[7].Value.ToString();
                if (str.Cells[8].Value != null) txtMotorNo.Text = str.Cells[8].Value.ToString();
                if (str.Cells[9].Value != null) txtYakıt.Text = str.Cells[9].Value.ToString();
                if (str.Cells[11].Value != null) YeniKayıtID(Convert.ToInt32(str.Cells[11].Value)); 

            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen kayıtlar üzerinde seçim yapınız.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMusteriSorgu_Click(object sender, EventArgs e)
        {
            if (rbAdSoyad.Checked)
                dgMusteri.DataSource = vt.Musteris.Where(p => p.AdSoyad.Contains(txtMusteriArama.Text)).ToList();
            else if (rbTel.Checked)
                dgMusteri.DataSource = vt.Musteris.Where(p => p.Tel == txtMusteriArama.Text).ToList();
            else if (rbTC.Checked)
                dgMusteri.DataSource = vt.Musteris.Where(p => p.TC == txtMusteriArama.Text).ToList();

            if (dgMusteri.RowCount == 0)
            {
                MessageBox.Show("Aradığınız Müşteri Bulunamadı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMusteriArama.Text = string.Empty;
                MusteriListele();
            }
        }

        

        private void dgMusteri_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow str = dgMusteri.Rows[e.RowIndex];
                musteriID = Convert.ToInt32(str.Cells[0].Value);
                dgAraclar.DataSource = vt.Aracs.Where(p => p.MusteriID == musteriID).ToList();
                AraclariListele();
                lblMusteriAdSoyad.Text = str.Cells[1].Value.ToString();
                lblMusteriAdSoyad.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen kayıtlar üzerinde seçim yapınız.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        void YeniKayıtID(int gelenMusteriID)
        {
            musteriID = gelenMusteriID;
            var musteri = vt.Musteris.Where(p => p.MusteriID == gelenMusteriID);
            foreach (var item in musteri)
            {
                lblMusteriAdSoyad.Text = item.AdSoyad.ToString();
            }

            lblMusteriAdSoyad.Enabled = true;
        }

        void AraclariListele()
        {
            dgAraclar.Columns["ServiceID"].Visible = false;
            dgAraclar.Columns["MusteriID"].Visible = false;
            dgAraclar.Columns["Musteri"].Visible = false;
            dgAraclar.Columns["Service"].Visible = false;
            dgAraclar.Columns["Bakım"].Visible = false;
            dgAraclar.Columns["AracID"].Visible = false;
        }

        void Clear()
        {
            txtKm.Text = string.Empty;
            txtMarka.Text = string.Empty;
            txtModel.Text = string.Empty;
            txtModelYılı.Text = string.Empty;
            txtMotorNo.Text = string.Empty;
            txtPlaka.Text = string.Empty;
            txtRuhsatNo.Text = string.Empty;
            txtSaseNo.Text = string.Empty;
            txtYakıt.Text = string.Empty;

        }

        void MusteriListele()
        {
            dgMusteri.DataSource = vt.Musteris.ToList();
            dgMusteri.Columns["ServiceID"].Visible = false;
            dgMusteri.Columns["Aracs"].Visible = false;
            dgMusteri.Columns["Service"].Visible = false;
            dgMusteri.Columns["MusteriID"].Visible = false;

        }
    }
}
