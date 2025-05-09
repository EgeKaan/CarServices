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
    public partial class CustomerRegisterForm : Form
    {
        public CustomerRegisterForm( int serviceid)
        {
            InitializeComponent();
            gelenServiceID = serviceid;
        }

        ServiceEntities vt = new ServiceEntities();
        int secilenMusteriID;
        int gelenServiceID;
        CarRegisterForm carRegisterForm;
        MainForm mainForm;
        private void CustomerRegisterForm_Load(object sender, EventArgs e)
        {
            MusteriListele();
        }

        

        private void dgMusteri_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                TextBoxClear();
                DataGridViewRow str = dgMusteri.Rows[e.RowIndex];
                if (str.Cells[0].Value != null) secilenMusteriID = Convert.ToInt32(str.Cells[0].Value);
                if (str.Cells[1].Value != null) txtAdSoyad.Text = str.Cells[1].Value.ToString();
                if (str.Cells[2].Value != null) txtTelNo.Text = str.Cells[2].Value.ToString();
                if (str.Cells[3].Value != null) txtEmail.Text = str.Cells[3].Value.ToString();
                if (str.Cells[4].Value != null) txtTcNo.Text = str.Cells[4].Value.ToString();
                if (str.Cells[5].Value != null) txtAdres.Text = str.Cells[5].Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen kayıtlar üzerinde seçim yapınız.","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }


        private void btnTemizle_Click(object sender, EventArgs e)
        {
            TextBoxClear();
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

        
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtAdSoyad.Text) || string.IsNullOrEmpty(txtTelNo.Text))
                    MessageBox.Show("Verileri Doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    Musteri m1 = new Musteri();
                    m1.AdSoyad = txtAdSoyad.Text;
                    m1.Email = txtEmail.Text;
                    m1.TC = txtTcNo.Text;
                    m1.Tel = txtTelNo.Text;
                    m1.ServiceID = gelenServiceID;
                    m1.Adres = txtAdres.Text;

                    vt.Musteris.Add(m1);
                    int sonuc = vt.SaveChanges();
                    if (sonuc > 0)
                    {
                        MessageBox.Show("Kayıt Başarılı!", "Tebrikler", MessageBoxButtons.OK);
                        MusteriListele();
                        TextBoxClear();
                    }
                    else MessageBox.Show("Kayıt Başarısız!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                
            }


            if (carRegisterForm == null)
            {
                carRegisterForm = new CarRegisterForm( "YeniKayıt", gelenServiceID);
                carRegisterForm.MdiParent = MdiParent;
                this.Close();
                carRegisterForm.Show();
            }
            else carRegisterForm.Activate();

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (secilenMusteriID !=0)
                {
                    Musteri m1 = vt.Musteris.FirstOrDefault(p => p.MusteriID == secilenMusteriID);
                    m1.AdSoyad = txtAdSoyad.Text;
                    m1.Email = txtEmail.Text;
                    m1.TC = txtTcNo.Text;
                    m1.Tel = txtTelNo.Text;
                    m1.ServiceID = gelenServiceID;
                    m1.Adres = txtAdres.Text;

                    int sonuc = vt.SaveChanges();
                    if (sonuc > 0)
                    {
                        MessageBox.Show("Güncelleme Başarılı", "Tebrikler", MessageBoxButtons.OK);
                        MusteriListele();
                        TextBoxClear();
                    }
                    else MessageBox.Show("Güncelleme Başarısız", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else MessageBox.Show("Kayıt Seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception)
            {

            }

        }

        void TextBoxClear()
        {
            txtAdSoyad.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtTcNo.Text = string.Empty;
            txtTelNo.Text = string.Empty;
            txtAdres.Text = string.Empty;
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
