using DevExpress.XtraEditors;
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

namespace ErpProject.Login
{
    public partial class LoginFrm : Form
    {
        public LoginFrm()
        {
            InitializeComponent();
        }
        FabrikaDbEntities db = new FabrikaDbEntities();
        private void button1_Click(object sender, EventArgs e)
        {
           var adminvalue= db.AdminTb.Where(x=>x.Kullanici== KullaniciTxt.Text && x.Sifre == SifreTxt.Text).FirstOrDefault();

            if(adminvalue != null)
            {

                XtraMessageBox.Show("Hoşgeldiniz");
               Form1 fr = new Form1();
                fr.Show();
                this.Hide();

            }
            else
            {
                XtraMessageBox.Show("Hatalı Giriş");

            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
           var personel = db.PersonelBilgileriTb.Where(x => x.KullaniciAdi == KullaniciTxt.Text && x.Sifre ==SifreTxt.Text).FirstOrDefault();

            if(personel != null)
            {
                XtraMessageBox.Show("Hoşgeldiniz");
                PersonelGorevFormlari.PersonelFormuFrm fr = new PersonelGorevFormlari.PersonelFormuFrm();
                fr.kullaniciAdi = KullaniciTxt.Text;
                fr.Show();
                this.Hide();

            }
            else
            {
                XtraMessageBox.Show("Hatalı Giriş");

            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginFrm_Load(object sender, EventArgs e)
        {

        }

        private void hyperlinkLabelControl3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
