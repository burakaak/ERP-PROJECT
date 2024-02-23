using FirmaCagriMvc.Models.Entity;
using System;
using System.Linq;
using System.Web.Mvc;
using System.Web.Security;

namespace FirmaCagriMvc.Controllers
{
    [Authorize]
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }
        FabrikaDbEntities db = new FabrikaDbEntities();

        public ActionResult AktifCagrilar()
        {
            var mail = (string)Session["Mail"];
            var id = db.MusteriTb.Where(x => x.Mail == mail).Select(x => x.Id).FirstOrDefault();
            var cagrilar = db.CagriTb.Where(x => x.Durum == true && x.Musteri == id).ToList();

            return View(cagrilar);


        }
        public ActionResult PasifCagrilar()
        {
            var mail = (string)Session["Mail"];
            var id = db.MusteriTb.Where(x => x.Mail == mail).Select(x => x.Id).FirstOrDefault();
            var cagrilar = db.CagriTb.Where(x => x.Durum == false && x.Musteri == id).ToList();

            return View(cagrilar);




        }
        [HttpGet]
        public ActionResult YeniCagri()
        {
            return View();

        }
        [HttpPost]
        public ActionResult YeniCagri(CagriTb p)
        {
            var mail = (string)Session["Mail"];
            var id = db.MusteriTb.Where(x => x.Mail == mail).Select(y => y.Id).FirstOrDefault();

            p.Durum = true;
            p.Tarih = DateTime.Parse(DateTime.Now.ToShortDateString());
            p.Musteri = id;
            db.CagriTb.Add(p);
            db.SaveChanges();
            return RedirectToAction("AktifCagrilar");
        }

        public ActionResult CagriDetay(int id)
        {
            var cagri = db.CagriDetayTb.Where(x => x.Cagri == id).ToList();
            return View(cagri);

        }
        public ActionResult CagriGetir(int id)
        {
            var cagri = db.CagriTb.Find(id);
            return View("CagriGetir", cagri);


        }
        public ActionResult CagriDuzenle(CagriTb p)
        {
            var cagri = db.CagriTb.Find(p.Id);
            cagri.Konu = p.Konu;
            cagri.Aciklama = p.Aciklama;
            db.SaveChanges();
            return RedirectToAction("AktifCagrilar");


        }

        [HttpGet]
        public ActionResult ProfilDuzenle()
        {
            var mail = (string)Session["Mail"];
            var id = db.MusteriTb.Where(x => x.Mail == mail).Select(y => y.Id).FirstOrDefault();
            var profil = db.MusteriTb.Where(x => x.Id == id).FirstOrDefault();
            return View(profil);
        }
        public ActionResult Anasayfa()
        {
            var mail = (string)Session["Mail"];
            var id = db.MusteriTb.Where(x => x.Mail == mail).Select(y => y.Id).FirstOrDefault();
            var toplamcagri = db.CagriTb.Where(x => x.Musteri == id).Count();
            var aktifcagri = db.CagriTb.Where(x => x.Musteri == id && x.Durum == true).Count();
            var pasifcagri = db.CagriTb.Where(x => x.Musteri == id && x.Durum == false).Count();
            var yetkili = db.MusteriTb.Where(x => x.Id == id).Select(y => y.Yetkili).FirstOrDefault();
            var sektor = db.MusteriTb.Where(x => x.Id == id).Select(y => y.Sektor).FirstOrDefault();
            var firmaadi=db.MusteriTb.Where(x=>x.Id == id).Select(y => y.FirmaAdi).FirstOrDefault();
            var firmagorsel=db.MusteriTb.Where(x=> x.Id == id).Select(y => y.Gorsel).FirstOrDefault();
            ViewBag.c1 = toplamcagri;
            ViewBag.c2 = aktifcagri;
            ViewBag.c3 = pasifcagri;
            ViewBag.c4 = yetkili;
            ViewBag.c5 = sektor;
            ViewBag.c6 = firmaadi;
            ViewBag.c7 = firmagorsel;
            return View();


        }
        public PartialViewResult Partial1()
        {
            var mail = (string)Session["Mail"];
            var id = db.MusteriTb.Where(x => x.Mail == mail).Select(y => y.Id).FirstOrDefault();
            var mesajlar = db.MesajlarTb.Where(x => x.Alici == id && x.Durum == true).ToList();
            var mesajsayisi = db.MesajlarTb.Where(x => x.Alici == id && x.Durum == true).Count();
            ViewBag.m1 = mesajsayisi;
            return PartialView(mesajlar);
        }

       public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            Session.Abandon();
            return RedirectToAction("Index","Login");
        }

        public PartialViewResult Partial2()
        {

            return PartialView();

        }
    }
}