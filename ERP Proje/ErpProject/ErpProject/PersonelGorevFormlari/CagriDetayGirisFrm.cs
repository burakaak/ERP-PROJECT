using DevExpress.XtraEditors;
using ErpProject.Entity;
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
    public partial class CagriDetayGirisFrm : Form
    {
        public CagriDetayGirisFrm()
        {
            InitializeComponent();
        }
        FabrikaDbEntities db = new FabrikaDbEntities();
        public int id;
        private void KaydetBtn_Click(object sender, EventArgs e)
        {
            CagriDetayTb t = new CagriDetayTb();
            t.Cagri = int.Parse(CagriIdTxt.Text); 
            t.Saat = SaatTxt.Text;  
            t.Tarih = DateTime.Parse(TarihTxt.Text);
            t.Aciklama = AciklamaTxt.Text;
            db.CagriDetayTb.Add(t);
            db.SaveChanges();
            XtraMessageBox.Show("Çağrı detayı kaydedildi");
        }

        private void CagriDetayGirisFrm_Load(object sender, EventArgs e)
        {
            CagriIdTxt.Enabled = false;
            CagriIdTxt.Text = id.ToString();
            string saat, tarih;

            tarih = DateTime.Now.ToShortDateString();
            saat = DateTime.Now.ToShortTimeString();

            TarihTxt.Text = tarih;
            SaatTxt.Text = saat;
        }   
    }
}
