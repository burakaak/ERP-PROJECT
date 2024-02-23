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
    public partial class GorevListesiFrm : Form
    {
        public GorevListesiFrm()
        {
            InitializeComponent();
        }
        FabrikaDbEntities db = new FabrikaDbEntities();
        private void GorevListesiFrm_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = (from x in db.GorevTb select new 
            { 
                
                x.Aciklama
            
            
            
                
            }).ToList();
            lblAktifGorev.Text = db.GorevTb.Where(x => x.Durum==true).Count().ToString();
            lblBitenGorev.Text = db.GorevTb.Where (x => x.Durum==false).Count().ToString();
            lblToplamDepartman.Text = db.DepartmanTb.Count().ToString();

            chartControl1.Series["Durum"].Points.AddPoint("Aktif Görevler", int.Parse(lblAktifGorev.Text));
            chartControl1.Series["Durum"].Points.AddPoint("Pasif Görevler", int.Parse(lblBitenGorev.Text));
            



        }
    }
}
