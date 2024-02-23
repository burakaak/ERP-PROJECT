using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using FirmaCagriMvc.Models.Entity;

namespace FirmaCagriMvc.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        FabrikaDbEntities db = new FabrikaDbEntities();
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(MusteriTb p) 
        {
            var bilgiler = db.MusteriTb.FirstOrDefault(x => x.Mail == p.Mail && x.Sifre == p.Sifre);

            if (bilgiler != null)
            {
                FormsAuthentication.SetAuthCookie(bilgiler.Mail, false);
                Session["Mail"] = bilgiler.Mail.ToString();
                return RedirectToAction("AktifCagrilar", "Default");
            }
            else
            {
                return RedirectToAction("Index");
            }


        }
    }
}