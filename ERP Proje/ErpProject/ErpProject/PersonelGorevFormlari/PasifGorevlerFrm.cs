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
    public partial class PasifGorevlerFrm : Form
    {
        public PasifGorevlerFrm()
        {
            InitializeComponent();
        }
        FabrikaDbEntities db = new FabrikaDbEntities();
        public string kullaniciAdi1;
        private void PasifGorevlerFrm_Load(object sender, EventArgs e)
        {
            var personelid = db.PersonelBilgileriTb.Where(x => x.KullaniciAdi == kullaniciAdi1).Select(y => y.Id).FirstOrDefault();
            var deger = (from x in db.GorevTb
                         select new
                         {
                             x.Id,
                             x.Aciklama,
                             x.Tarih,
                             x.GorevAlan,
                             x.Durum
                         }).Where(x=>x.GorevAlan== personelid && x.Durum == false).ToList();

            gridControl1.DataSource = deger;
        }
    }
}
