using DevExpress.XtraEditors;
using ErpProject.Entity;
using System;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace ErpProject.Formlar
{
    public partial class PersonellerFrm : Form
    {
        public PersonellerFrm()
        {
            InitializeComponent();
        }
        FabrikaDbEntities db = new FabrikaDbEntities();

        void personeller()
        {

            var degerler = (from x in db.PersonelBilgileriTb
                            select new
                            {
                                x.Id,
                                x.Ad,
                                x.SoyAd,
                                x.Tc,
                                x.Pozisyon,
                                x.Adres,
                                x.Departman,
                                x.DogumTarihi,
                                x.Telefon,
                                x.Yonetici,
                                x.Ucret,
                                x.KullaniciAdi,
                                x.Sifre,
                                x.Durum
                            }).ToList();

            gridControlP.DataSource = degerler.Where(x=>x.Durum==true).ToList();





        }
        private void PersonellerFrm_Load(object sender, EventArgs e)
        {
            personeller();
            var departmanlar = (from x in db.DepartmanTb
                                select new
                                {
                                    x.DepartmanId,
                                    x.DepartmanAdi

                                }).ToList();



            lookUpEdit1.Properties.ValueMember = "DepartmanAdi"; 
            lookUpEdit1.Properties.DisplayMember = "DepartmanId";
            lookUpEdit1.Properties.DataSource = departmanlar;
        }

        private void ListeleBtn_Click(object sender, EventArgs e)
        {
            personeller();
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelControl7_Click(object sender, EventArgs e)
        {

        }

        private void lookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void EkleBtn_Click(object sender, EventArgs e)
        {
            PersonelBilgileriTb t = new PersonelBilgileriTb();
            t.Id=int.Parse(IdTxt.Text);
            t.Ad = AdTxt.Text;
            t.SoyAd = SoyadTxt.Text;
            t.Tc = TcTxt.Text;
            t.Pozisyon = PozisyonTxt.Text;
            t.Adres = AdresTxt.Text;
            t.DogumTarihi = DateTime.TryParse(DogumTarihiTxt.Text, out var dogumTarihi) ? dogumTarihi : DateTime.MinValue;
            t.Telefon = TelefonTxt.Text;
            t.Yonetici = YoneticiTxt.Text;
            t.Ucret = int.Parse(UcretTxt.Text);
            t.KullaniciAdi = KullaniciAdiTxt.Text;
            t.Sifre = SifreTxt.Text;
            t.Departman = lookUpEdit1.EditValue.ToString();
            db.PersonelBilgileriTb.Add(t);
            db.SaveChanges();


            XtraMessageBox.Show("Ekleme işlemi başarılı","Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            personeller();

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            IdTxt.Text=gridView1.GetFocusedRowCellValue("Id").ToString();
            AdTxt.Text= gridView1.GetFocusedRowCellValue("Ad").ToString();
            SoyadTxt.Text = gridView1.GetFocusedRowCellValue("SoyAd").ToString();
            TcTxt.Text = gridView1.GetFocusedRowCellValue("Tc").ToString();
            PozisyonTxt.Text = gridView1.GetFocusedRowCellValue("Pozisyon").ToString();
            AdresTxt.Text = gridView1.GetFocusedRowCellValue("Adres").ToString();
            DogumTarihiTxt.Text = gridView1.GetFocusedRowCellValue("DogumTarihi").ToString();
            TelefonTxt.Text = gridView1.GetFocusedRowCellValue("Telefon").ToString();
            YoneticiTxt.Text = gridView1.GetFocusedRowCellValue("Yonetici").ToString();
            UcretTxt.Text = gridView1.GetFocusedRowCellValue("Ucret").ToString();
            KullaniciAdiTxt.Text = gridView1.GetFocusedRowCellValue("KullaniciAdi").ToString();
            SifreTxt.Text = gridView1.GetFocusedRowCellValue("Sifre").ToString();
            lookUpEdit1.EditValue = gridView1.GetFocusedRowCellValue("Departman").ToString();



        }

        private void GüncelleBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int personelId = int.Parse(IdTxt.Text);

                var deger = db.PersonelBilgileriTb.Find(personelId);

                if (deger != null)
                {
                    deger.Ad = AdTxt.Text;
                    deger.SoyAd = SoyadTxt.Text;
                    deger.Tc = TcTxt.Text;
                    deger.Pozisyon = PozisyonTxt.Text;
                    deger.Adres = AdresTxt.Text;
                    deger.Departman = lookUpEdit1.EditValue?.ToString(); 
                    deger.DogumTarihi = DateTime.TryParse(DogumTarihiTxt.Text, out var dogumTarihi) ? dogumTarihi : DateTime.MinValue;
                    deger.Telefon = TelefonTxt.Text;
                    deger.Yonetici = YoneticiTxt.Text;

                    if (int.TryParse(UcretTxt.Text, out var ucret))
                    {
                        deger.Ucret = ucret;
                    }
                    else
                    {
                        XtraMessageBox.Show("Ücret alanına geçerli bir sayı giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; 
                    }

                    deger.KullaniciAdi = KullaniciAdiTxt.Text;
                    deger.Sifre = SifreTxt.Text;

                    db.SaveChanges(); 

                    XtraMessageBox.Show("Güncelleme işlemi başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    personeller();
                }
                else
                {
                    XtraMessageBox.Show("Belirtilen ID'ye sahip personel bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException)
            {
                XtraMessageBox.Show("Geçerli bir sayısal değer giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




        }

        private void labelControl13_Click(object sender, EventArgs e)
        {

        }

        private void SilBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var x = int.Parse(IdTxt.Text);
                var deger = db.PersonelBilgileriTb.Find(x);

                if (deger != null)
                {
                    deger.Durum = false;
                    int affectedRows = db.SaveChanges();

                    if (affectedRows > 0)
                    {
                        XtraMessageBox.Show("Silme işlemi başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        personeller();
                    }
                    else
                    {
                        XtraMessageBox.Show("Silme işlemi başarısız. Değişiklik yapılmadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    XtraMessageBox.Show("Belirtilen ID'ye sahip kayıt bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
    
}
