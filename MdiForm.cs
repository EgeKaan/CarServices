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
    public partial class MdiForm : Form
    {   
        public MdiForm( int serviceid)
        {
            InitializeComponent();
            gelenServiceID = serviceid;

        }

        int gelenServiceID;
        private void MdiForm_Load(object sender, EventArgs e)
        {
            MainForm mainform = new MainForm(gelenServiceID);
            mainform.MdiParent = this;
            mainform.Show();
        }
        CustomerRegisterForm customerRegister;
        CarRegisterForm carRegister;

        private void müşteriKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {    
            customerRegister = new CustomerRegisterForm(gelenServiceID);
            customerRegister.MdiParent = this;
            customerRegister.Show();          
        }

        private void araçKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            carRegister = new CarRegisterForm(("AracKayıt"), gelenServiceID);
            carRegister.MdiParent = this;
            carRegister.Show();
        }

        private void MdiForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void mToolStripMenuItem_Click(object sender, EventArgs e)
        {
            customerRegister = new CustomerRegisterForm(gelenServiceID);
            customerRegister.MdiParent = this;
            customerRegister.Show();
        }

        private void araçGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            carRegister = new CarRegisterForm(("AracGuncelle"), gelenServiceID);
            carRegister.MdiParent = this;
            carRegister.Show();
        }
    }
}
