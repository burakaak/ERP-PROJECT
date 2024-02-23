using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ErpProject.Entity;

namespace ErpProject.Formlar
{
    public partial class GorevFrm : Form
    {
        public GorevFrm()
        {
            InitializeComponent();
        }
        FabrikaDbEntities db = new FabrikaDbEntities();
        private void GorevFrm_Load(object sender, EventArgs e)
        {
            var deger = (from x in db.PersonelBilgileriTb
                                select new
                                {
                                    x.Id,
                                   AdSoyad= x.Ad + "  " + x.SoyAd

                                }).ToList();



            lookUpEdit1.Properties.ValueMember = "Id";
            lookUpEdit1.Properties.DisplayMember = "AdSoyad";
            lookUpEdit1.Properties.DataSource = deger;
        }

        private void GorevIptalBtn_Click(object sender, EventArgs e)
        {

        }

        private void KaydetBtn_Click(object sender, EventArgs e)
        {
            GorevTb t = new GorevTb();
            t.Aciklama = AciklamaTxt.Text;
            t.Durum = true;
            t.GorevAlan = int.Parse(lookUpEdit1.EditValue.ToString());
            t.Tarih = DateTime.Parse(TarihTxt.Text);
            t.GorevVeren = 1;
            db.GorevTb.Add(t);
            db.SaveChanges();

            XtraMessageBox.Show("Görev kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
