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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtKullaniciAd.Text) || string.IsNullOrEmpty(txtKullaniciAd.Text))
                MessageBox.Show("Lütfen alanları doldur");

            else
            {
                ServiceEntities vt = new ServiceEntities();
                string KullaniciAd = txtKullaniciAd.Text.Trim();
                string Sifre = txtSifre.Text.Trim();
                Login login = vt.Logins.FirstOrDefault(p => p.Nickname == KullaniciAd && p.Password == Sifre);
                if (login == null)
                    MessageBox.Show("Böyle bir kullanıcı yok");
                else
                {
                    MdiForm f = new MdiForm(login.Service.ServiceID);
                    //MdiForm f = new MdiForm();
                    f.Show();
                    this.Hide();

                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            MdiForm f = new MdiForm(1);
            //MdiForm f = new MdiForm();
            f.Show();
            this.Hide();
        }
    }
}
