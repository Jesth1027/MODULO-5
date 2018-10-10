using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PROYECTO_WEB.Models;

namespace PROYECTO_WEB.Controllers
{
    public class gest_cuentaController : Controller
    {
        private webEntities2 db = new webEntities2();

        // GET: gest_cuenta
        public ActionResult Index()
        {
            return View(db.gest_cuenta.ToList());
        }

        // GET: gest_cuenta/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            gest_cuenta gest_cuenta = db.gest_cuenta.Find(id);
            if (gest_cuenta == null)
            {
                return HttpNotFound();
            }
            return View(gest_cuenta);
        }

        // GET: gest_cuenta/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: gest_cuenta/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "correlativo,No_cuenta,banco,tipo,fecha")] gest_cuenta gest_cuenta)
        {
            if (ModelState.IsValid)
            {
                db.gest_cuenta.Add(gest_cuenta);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(gest_cuenta);
        }

        // GET: gest_cuenta/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            gest_cuenta gest_cuenta = db.gest_cuenta.Find(id);
            if (gest_cuenta == null)
            {
                return HttpNotFound();
            }
            return View(gest_cuenta);
        }

        // POST: gest_cuenta/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "correlativo,No_cuenta,banco,tipo,fecha")] gest_cuenta gest_cuenta)
        {
            if (ModelState.IsValid)
            {
                db.Entry(gest_cuenta).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(gest_cuenta);
        }

        // GET: gest_cuenta/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            gest_cuenta gest_cuenta = db.gest_cuenta.Find(id);
            if (gest_cuenta == null)
            {
                return HttpNotFound();
            }
            return View(gest_cuenta);
        }

        // POST: gest_cuenta/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            gest_cuenta gest_cuenta = db.gest_cuenta.Find(id);
            db.gest_cuenta.Remove(gest_cuenta);
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
