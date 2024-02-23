using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ErpProject
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void DepartmanListesiBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Departmanlar frm = new Formlar.Departmanlar();
            frm.MdiParent = this;
            frm.Show();

        }

        private void PersonelListeBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.PersonellerFrm frm = new Formlar.PersonellerFrm();
            frm.MdiParent = this;
            frm.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void PersonelİstatistikBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.PersonelİstatistikFrm frm = new Formlar.PersonelİstatistikFrm();
            frm.MdiParent = this;
            frm.Show();
        }
        Formlar.GorevListesiFrm frmGorevListe;
        private void BtnGorevListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmGorevListe == null || frmGorevListe.IsDisposed)
            {
                frmGorevListe = new Formlar.GorevListesiFrm();
                frmGorevListe.MdiParent = this;
                frmGorevListe.Show();
            }

        }

        private void GorevEkleBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.GorevFrm frm = new Formlar.GorevFrm();

            frm.Show();
        }

        private void GorevDetayBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.GorevDetayFrm frm = new Formlar.GorevDetayFrm();

            frm.Show();
        }
        Formlar.AnaSayfaFrm frmAnaSayfa;
        private void btnAnaSayfa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmAnaSayfa == null || frmAnaSayfa.IsDisposed)
            {
                frmAnaSayfa = new Formlar.AnaSayfaFrm();
                frmAnaSayfa.MdiParent = this;
                frmAnaSayfa.Show();
            }
        }
        Formlar.AktifCagrilarFrm frm;
        private void AktifCagriBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm == null || frm.IsDisposed)
            {
                frm = new Formlar.AktifCagrilarFrm();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem17_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem16_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PersonelGorevFormlari.PasifGorevlerFrm frm = new PersonelGorevFormlari.PasifGorevlerFrm();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem15_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PersonelGorevFormlari.AktifGorevlerFrm frm = new PersonelGorevFormlari.AktifGorevlerFrm();
            frm.MdiParent = this;
            frm.Show();
        }

        private void PasifBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }
}
