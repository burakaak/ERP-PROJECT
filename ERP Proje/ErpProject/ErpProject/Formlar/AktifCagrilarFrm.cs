using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid;
using ErpProject.Entity;
using ErpProject.PersonelGorevFormlari;

namespace ErpProject.Formlar
{
    public partial class AktifCagrilarFrm : Form
    {
        public AktifCagrilarFrm()
        {
            InitializeComponent();
        }

        private void AktifCagrilarFrm_Load(object sender, EventArgs e)
        {
            FabrikaDbEntities db = new FabrikaDbEntities();

            var degerler = (from x in db.CagriTb select new
                            {
                                x.Id,
                                x.MusteriTb.FirmaAdi,
                                x.MusteriTb.Telefon,
                                x.Konu,
                                x.Aciklama,
                                x.PersonelBilgileriTb.Ad,
                                x.Durum
                                
                            }).Where(y=> y.Durum==true).ToList();
            gridControl1.DataSource = degerler;

            
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            CagriAtamaFrm fr = new CagriAtamaFrm();
            fr.id = int.Parse(gridView1.GetFocusedRowCellValue("Id").ToString());
            fr.Show();
        }
    }
}
