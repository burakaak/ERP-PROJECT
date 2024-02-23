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

namespace ErpProject.Formlar
{
    public partial class CagriAtamaFrm : Form
    {
        public CagriAtamaFrm()
        {
            InitializeComponent();
        }
        FabrikaDbEntities db = new FabrikaDbEntities();
        public int id;
        private void CagriAtamaFrm_Load(object sender, EventArgs e)
        {
            var deger = (from x in db.PersonelBilgileriTb
                         select new
                         {
                             x.Id,
                             AdSoyad = x.Ad + "  " + x.SoyAd

                         }).ToList();



            lookUpEdit1.Properties.ValueMember = "Id";
            lookUpEdit1.Properties.DisplayMember = "AdSoyad";
            lookUpEdit1.Properties.DataSource = deger;

            CagriIdTxt.Text = id.ToString();
            var gelenveri = db.CagriTb.Find(id);
            AciklamaTxt.Text = gelenveri.Aciklama;
            TarihTxt.Text = gelenveri.Tarih.ToString();
            KonuTxt.Text = gelenveri.Konu;

            
        }

        private void KaydetBtn_Click(object sender, EventArgs e)
        {
            var gelenveri = db.CagriTb.Find(id);
            gelenveri.Konu = KonuTxt.Text;
            gelenveri.Tarih= Convert.ToDateTime(TarihTxt.Text);
            gelenveri.Aciklama = AciklamaTxt.Text;
            gelenveri.CagriPersonel = int.Parse(lookUpEdit1.EditValue.ToString());
            db.SaveChanges();
        }
    }
}
