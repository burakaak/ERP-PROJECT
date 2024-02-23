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
    public partial class Departmanlar : Form
    {
        public Departmanlar()
        {
            InitializeComponent();
        }
        FabrikaDbEntities db = new FabrikaDbEntities();
        void listele() 
        {
            
            var degerler = (from x in db.DepartmanTb
                            select new 
                            {
                               
                                x.DepartmanId,
                                x.DepartmanAdi,
                                x.Sorumlu,
                                x.PersonelSayisi

                            }).ToList();
            gridControl1.DataSource = degerler;
                    
        
        
        }
        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void EkleBtn_Click(object sender, EventArgs e)
        {
            DepartmanTb t = new DepartmanTb();
            t.DepartmanId = int.Parse(DepartmanIdTxt.Text);
            t.DepartmanAdi = DepartmanAdiTxt.Text;
            t.PersonelSayisi = int.Parse(PersonelSayisiTxt.Text);
            t.Sorumlu = SorumluTxt.Text;
            db.DepartmanTb.Add(t);
            db.SaveChanges();
            XtraMessageBox.Show("Ekleme işlemi başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();


        }

        private void SilBtn_Click(object sender, EventArgs e)
        {
            int x = int.Parse(DepartmanIdTxt.Text);
            int y = int.Parse(PersonelSayisiTxt.Text);

            var deger = db.DepartmanTb
                .FirstOrDefault(d => d.DepartmanId == x && d.PersonelSayisi == y);

            if (deger != null)
            {
                db.DepartmanTb.Remove(deger);
                db.SaveChanges();
                XtraMessageBox.Show("Silme işlemi başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
            }
            else
            {
                XtraMessageBox.Show("Belirtilen kriterlere uygun kayıt bulunamadı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }

        private void gridControl1_FocusedViewChanged(object sender, DevExpress.XtraGrid.ViewFocusEventArgs e)
        {
          

        }

        private void gridControl1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            
           DepartmanIdTxt.Text = gridView1.GetFocusedRowCellValue("DepartmanId").ToString();
           DepartmanAdiTxt.Text = gridView1.GetFocusedRowCellValue("DepartmanAdi").ToString();
           PersonelSayisiTxt.Text = gridView1.GetFocusedRowCellValue("PersonelSayisi").ToString();
           SorumluTxt.Text = gridView1.GetFocusedRowCellValue("Sorumlu").ToString();

        }

        private void GüncelleBtn_Click(object sender, EventArgs e)
        {
            
            if (int.TryParse(DepartmanIdTxt.Text, out int x) && int.TryParse(PersonelSayisiTxt.Text, out int y))
            {
                
                var deger = db.DepartmanTb.FirstOrDefault(d => d.DepartmanId == x && d.PersonelSayisi == y);

                if (deger != null)
                {
                    deger.DepartmanAdi = DepartmanAdiTxt.Text;
                    deger.Sorumlu = SorumluTxt.Text;

                    try
                    {
                       
                        db.SaveChanges();
                        XtraMessageBox.Show("Güncelleme işlemi başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        
                        listele();
                    }
                    catch (Exception ex)
                    {
                        
                        XtraMessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    
                    XtraMessageBox.Show("Belirtilen DepartmanId ve PersonelSayisi'ne sahip bir kayıt bulunamadı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                
                XtraMessageBox.Show("Geçersiz giriş değerleri", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void Departmanlar_Load(object sender, EventArgs e)
        {

        }
    }
}
