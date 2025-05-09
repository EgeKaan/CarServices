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
    public partial class MainForm : Form
    {
        public MainForm(int serviceid)
        {
            InitializeComponent();
            gelenServiceID = serviceid;
        }
        ServiceEntities vt = new ServiceEntities();
        int gelenServiceID;
        private void MainForm_Load(object sender, EventArgs e)
        {
            AraclariListele();
            MusteriListele();
            rbAdSoyad.Checked = true;
            rbPlaka.Checked = true;

        }


        private void btnAracSorgu_Click(object sender, EventArgs e)
        {
            if (rbPlaka.Checked)
                dgAraclar.DataSource = vt.Aracs.Where(p => p.Plaka == txtAracSorgu.Text).ToList();
            else if (rbRuhsat.Checked)
                dgAraclar.DataSource = vt.Aracs.Where(p => p.RuhsatNo == txtAracSorgu.Text).ToList();
            else if (rbSase.Checked)
                dgAraclar.DataSource = vt.Aracs.Where(p => p.SaseNo == txtAracSorgu.Text).ToList();
            else if (rbMotor.Checked)
                dgAraclar.DataSource = vt.Aracs.Where(p => p.MotorNo == txtAracSorgu.Text).ToList();

            if (dgAraclar.RowCount == 0)
            {
                MessageBox.Show("Aradığınız Araç Bulunamadı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAracSorgu.Text = string.Empty;
                AraclariListele();
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
                txtMusteriArama.Text  = string.Empty;
                MusteriListele();
            }

        }

        private void btnKayıt_Click(object sender, EventArgs e)
        {
            CustomerRegisterForm customerRegister = new CustomerRegisterForm(gelenServiceID);
            customerRegister.Show();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            AraclariListele();
            MusteriListele();
        }

        private void dgMusteri_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow str = dgMusteri.Rows[e.RowIndex];
                int id = Convert.ToInt32(str.Cells[0].Value);
                dgAraclar.DataSource = vt.Aracs.Where(p => p.MusteriID == id).ToList();
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen kayıtlar üzerinde seçim yapınız.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
        }

        MaintenanceForm maintenanceForm;
        private void dgAraclar_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow str = dgAraclar.Rows[e.RowIndex];
                int aracid = Convert.ToInt32(str.Cells[0].Value);

                if (maintenanceForm == null)
                {
                    maintenanceForm = new MaintenanceForm(aracid, gelenServiceID);
                    maintenanceForm.MdiParent = MdiParent;
                    this.Close();
                    maintenanceForm.Show();
                }
                else maintenanceForm.Activate();
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen kayıtlar üzerinde seçim yapınız.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }


        void AraclariListele()
        {
            dgAraclar.DataSource = vt.Aracs.ToList();
            dgAraclar.Columns["ServiceID"].Visible = false;
            dgAraclar.Columns["MusteriID"].Visible = false;
            dgAraclar.Columns["Musteri"].Visible = false;
            dgAraclar.Columns["Service"].Visible = false;
            dgAraclar.Columns["Bakım"].Visible = false;
            dgAraclar.Columns["AracID"].Visible = false;
        }

        void MusteriListele()
        {
            dgMusteri.DataSource = vt.Musteris.ToList();
            dgMusteri.Columns["ServiceID"].Visible = false;
            dgMusteri.Columns["Aracs"].Visible = false;
            dgMusteri.Columns["Service"].Visible = false;
            dgMusteri.Columns["MusteriID"].Visible = false; 
            dgMusteri.Columns[1].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;

        }
    }
}
