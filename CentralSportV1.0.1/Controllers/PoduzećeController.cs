using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CentralSportV1._0._1.Models;

namespace CentralSportV1._0._1.Controllers
{
    public class PoduzećeController : Controller
    {
        private PoduzećeContext db = new PoduzećeContext();

        // GET: poduzeće
        public ActionResult Index()
        {
            return View(db.poduzeće.ToList());
        }

        // GET: poduzeće/Details/5
        public ActionResult Details(poduzeće model)
        {
            return View(model);
        }

        public ActionResult VratiPretragu(PretražiKompanijeModel model)
        {
            string IDString = model.pojamPretraživanja;
            List<poduzeće> rezList = new List<poduzeće>();
            poduzeće poduzeće = new poduzeće();
            var rez = from c in db.poduzeće
                      where c.imePoduzeće.Contains(IDString)
                      select c;
            if (rez.Count() > 0)
            {
                rezList = rez.ToList();
            }
            if (model.pojamPretraživanja == null)
            {
                //Vrati korisniku poruku da mora nešto upisati u tražilicu da započne pretragu
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            else if (rez.Count() == 0)
            {
                //Vrati korisniku poruku da taj pojam nema u bazi
                return new HttpStatusCodeResult(HttpStatusCode.NotFound);
            }
            else
            {
                //pretraži pomoću imena pretrage
                return View(rezList);
            }
        }

        // GET: poduzeće/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: poduzeće/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idPoduzeće,imePoduzeće,lokacijaPoduzeće,opisPoduzeće,dostupniTermini,dostupniTreneri,cijenaUsluga,kontaktTelefon,kontaktEmail,lozinkaPoduzeće,djelatnostiPoduzeće")] poduzeće poduzeće)
        {
            if (ModelState.IsValid)
            {
                db.poduzeće.Add(poduzeće);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(poduzeće);
        }

        // GET: poduzeće/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            poduzeće poduzeće = db.poduzeće.Find(id);
            if (poduzeće == null)
            {
                return HttpNotFound();
            }
            return View(poduzeće);
        }

        // POST: poduzeće/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idPoduzeće,imePoduzeće,lokacijaPoduzeće,opisPoduzeće,dostupniTermini,dostupniTreneri,cijenaUsluga,kontaktTelefon,kontaktEmail,lozinkaPoduzeće,djelatnostiPoduzeće")] poduzeće poduzeće)
        {
            if (ModelState.IsValid)
            {
                db.Entry(poduzeće).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(poduzeće);
        }

        // GET: poduzeće/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            poduzeće poduzeće = db.poduzeće.Find(id);
            if (poduzeće == null)
            {
                return HttpNotFound();
            }
            return View(poduzeće);
        }

        // POST: poduzeće/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            poduzeće poduzeće = db.poduzeće.Find(id);
            db.poduzeće.Remove(poduzeće);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
