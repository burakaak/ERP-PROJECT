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
    public partial class CagriListesiFrm : Form
    {
        public CagriListesiFrm()
        {
            InitializeComponent();
        }
        FabrikaDbEntities db = new FabrikaDbEntities();
        public string kullaniciAdi1;
        private void CagriListesiFrm_Load(object sender, EventArgs e)
        {
            var personelid = db.PersonelBilgileriTb.Where(x => x.KullaniciAdi == kullaniciAdi1).Select(y => y.Id).FirstOrDefault();
            gridControl1.DataSource=(from x in db.CagriTb select new
            {
                x.Id,
                x.MusteriTb.FirmaAdi,
                x.MusteriTb.Telefon,
                x.MusteriTb.Mail,
                x.Aciklama,
                x.CagriPersonel,
                x.Durum
            }).Where(y=> y.Durum == true && y.CagriPersonel == personelid).ToList();

            gridView1.Columns["Durum"].Visible = false;
            gridView1.Columns["CagriPersonel"].Visible = false;
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            CagriDetayGirisFrm fr = new CagriDetayGirisFrm();
            fr.id= int.Parse(gridView1.GetFocusedRowCellValue("Id").ToString());
            fr.Show();
        }
    }
}
