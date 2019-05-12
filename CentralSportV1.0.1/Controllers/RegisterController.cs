using CentralSportV1._0._1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CentralSportV1._0._1.Controllers
{
    public class RegisterController : Controller
    {
        private KorisnikContext db = new KorisnikContext();

        [HttpPost]
        public ActionResult Register(RegisterViewModel model)
        {
            Random random = new Random();
            int rndId = random.Next(1, 10000);
            korisnik korisnik = new korisnik { idKorisnik = rndId, registracijskiEmailKorisnik = model.Email, lozinkaKorisnik = model.Password };
            db.korisnik.Add(korisnik);
            db.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}