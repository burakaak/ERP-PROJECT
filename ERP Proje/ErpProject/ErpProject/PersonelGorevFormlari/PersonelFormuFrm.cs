using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ErpProject.PersonelGorevFormlari
{
    public partial class PersonelFormuFrm : Form
    {
        public PersonelFormuFrm()
        {
            InitializeComponent();
        }
        public string kullaniciAdi;
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            PersonelGorevFormlari.AktifGorevlerFrm frm = new PersonelGorevFormlari.AktifGorevlerFrm();
            frm.MdiParent = this;
            frm.kullaniciAdi1 = kullaniciAdi;
            frm.Show();
            

        }

        private void PasifGorevlerBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PersonelGorevFormlari.PasifGorevlerFrm frm = new PersonelGorevFormlari.PasifGorevlerFrm();
            frm.MdiParent = this;
            frm.kullaniciAdi1 = kullaniciAdi;
            frm.Show();

        }

        private void CagrıListesiBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PersonelGorevFormlari.CagriListesiFrm frm = new PersonelGorevFormlari.CagriListesiFrm();
            frm.MdiParent = this;
            frm.kullaniciAdi1 = kullaniciAdi;
            frm.Show();
        }

        private void PersonelFormuFrm_Load(object sender, EventArgs e)
        {
            this.Text = kullaniciAdi.ToString();
        }
    }
}
