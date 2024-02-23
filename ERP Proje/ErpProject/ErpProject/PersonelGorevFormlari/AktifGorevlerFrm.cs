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
    public partial class AktifGorevlerFrm : Form
    {
        public AktifGorevlerFrm()
        {
            InitializeComponent();
        }
        public string kullaniciAdi1;

        FabrikaDbEntities db = new FabrikaDbEntities();
        private void AktifGorevlerFrm_Load(object sender, EventArgs e)
        {
            
            var personelid = db.PersonelBilgileriTb.Where(x=> x.KullaniciAdi == kullaniciAdi1).Select(y=>y.Id).FirstOrDefault();
           
            var deger=(from x in db.GorevTb select new
            {
                x.Id,
                x.Aciklama,
                x.Tarih,
                x.GorevAlan,
                x.Durum
            }).Where(x=> x.GorevAlan == personelid && x.Durum==true).ToList();
           
            gridControl1.DataSource = deger;
        }
    }
}
