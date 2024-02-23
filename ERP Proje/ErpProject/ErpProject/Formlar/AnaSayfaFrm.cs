using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ErpProject.Entity;
    

namespace ErpProject.Formlar
{
    public partial class AnaSayfaFrm : Form
    {
        public AnaSayfaFrm()
        {
            InitializeComponent();
        }
        FabrikaDbEntities db = new FabrikaDbEntities();
        private void AnaSayfaFrm_Load(object sender, EventArgs e)
        {
            #region Görevler
            gridControl1.DataSource = (from x in db.GorevTb select new 
            {
              
              
               x.Aciklama,
               x.Durum



            }).ToList();
            #endregion

            #region Bugün Yapılacak Görevler
            DateTime bugun = DateTime.Parse(DateTime.Now.ToShortDateString());
            
            gridControl2.DataSource=(from x in db.GorevDetayTb select new
            {
                x.Aciklama,
               GorevAciklama= x.GorevTb.Aciklama,
               x.Tarih
            }).Where(x=>x.Tarih==bugun).ToList();
            #endregion

            #region Aktif Çağrı Listesi

            gridControl3.DataSource=(from x in db.CagriTb select new 
            { 
                x.MusteriTb.FirmaAdi,
                x.Konu,
                x.Tarih,
                x.Durum
            
            
            }).Where(x=>x.Durum==true).ToList();
            gridView3.Columns["Durum"].Visible = false;






            #endregion

            #region Fihrist 

            gridControl4.DataSource = (from x in db.MusteriTb
                                       select new
                                       {
                                           x.FirmaAdi,
                                           x.Telefon,





                                       }).ToList();




            #endregion

            #region Grafil

            int AktifCagri = db.CagriTb.Count(x => x.Durum == true);
            int PasifCagri = db.CagriTb.Count(x => x.Durum == false);

            chartControl1.Series["Series 1"].Points.AddPoint("Aktif Çağrı", AktifCagri);
            chartControl1.Series["Series 1"].Points.AddPoint("Pasif Çağrı", PasifCagri);



            #endregion


        }
    }
}
