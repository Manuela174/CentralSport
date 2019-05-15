using CentralSportV1._0._1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Helpers;


namespace CentralSportV1._0._1.Controllers
{
    public class RegisterController : Controller
    {
        private KorisnikContext db = new KorisnikContext();

        [HttpPost]
        public ActionResult Register(RegisterViewModel model)
        {
            string hashedPassword = "";
            string salt = "";
            Random random = new Random();
            int rndId = random.Next(1, 10000);
            salt = Crypto.GenerateSalt();
            hashedPassword = Crypto.HashPassword(salt + model.Password);
            korisnik korisnik = new korisnik { idKorisnik = rndId, registracijskiEmailKorisnik = model.Email, lozinkaKorisnik = hashedPassword };
            db.korisnik.Add(korisnik);
            db.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}