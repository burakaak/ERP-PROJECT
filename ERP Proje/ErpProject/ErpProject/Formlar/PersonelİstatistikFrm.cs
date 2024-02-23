using ErpProject.Entity;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
namespace ErpProject.Formlar
{
    public partial class PersonelİstatistikFrm : Form
    {
        public PersonelİstatistikFrm()
        {
            InitializeComponent();
        }
        FabrikaDbEntities db = new FabrikaDbEntities();
        private void PersonelİstatistikFrm_Load(object sender, EventArgs e)
        {
            lblToplamDepartman.Text = db.DepartmanTb.Count().ToString();
            lblToplamMusteri.Text = db.MusteriTb.Count().ToString();
            lblToplamPersonel.Text = db.PersonelBilgileriTb.Count().ToString();
            lblAktifIs.Text = db.GorevTb.Count(x => x.Durum == true).ToString();
            lblPasifIs.Text = db.GorevTb.Count(x => x.Durum == false).ToString();
            lblSonGorev.Text = db.GorevTb.OrderByDescending(x => x.Id).Select(x => x.Aciklama).FirstOrDefault();
            lblSehir.Text = db.MusteriTb.Select(x => x.il).Distinct().Count().ToString();
            lblSektor.Text = db.MusteriTb.Select(x => x.Sektor).Distinct().Count().ToString();
            DateTime bugun = DateTime.Today;
            lblAcilanGorevler.Text = db.GorevTb.Count(x => x.Tarih == bugun).ToString();
            var deger = db.GorevTb.GroupBy(x => x.GorevAlan).OrderByDescending(z => z.Count()).Select(y => y.Key).FirstOrDefault();
            lblAyinElemani.Text = db.PersonelBilgileriTb.Where(x => x.Id == deger).Select(y => y.Ad + "  " + y.SoyAd).FirstOrDefault().ToString();
            lblSonGorevTarih.Text=db.GorevTb.OrderByDescending(x=>x.Id).Select(x=>x.Tarih).FirstOrDefault().ToString();



        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelControl13_Click(object sender, EventArgs e)
        {

        }

        private void labelControl18_Click(object sender, EventArgs e)
        {

        }

        private void lblAyinElemani_Click(object sender, EventArgs e)
        {

        }
    }
}
