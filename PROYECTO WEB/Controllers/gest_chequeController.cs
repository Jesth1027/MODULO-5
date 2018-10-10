﻿using System;
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
    public class gest_chequeController : Controller
    {
        private webEntities2 db = new webEntities2();

        // GET: gest_cheque
        public ActionResult Index()
        {
            var gest_cheque = db.gest_cheque.Include(g => g.asign_cheque_cp).Include(g => g.gest_cuenta);
            return View(gest_cheque.ToList());
        }

        // GET: gest_cheque/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            gest_cheque gest_cheque = db.gest_cheque.Find(id);
            if (gest_cheque == null)
            {
                return HttpNotFound();
            }
            return View(gest_cheque);
        }

        // GET: gest_cheque/Create
        public ActionResult Create()
        {
            ViewBag.banco = new SelectList(db.asign_cheque_cp, "No_cuenta", "banco");
            ViewBag.cuenta = new SelectList(db.gest_cuenta, "No_cuenta", "No_cuenta");
            return View();
        }

        // POST: gest_cheque/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "serie,ingreso,banco,cuenta,estado,moneda")] gest_cheque gest_cheque)
        {
            if (ModelState.IsValid)
            {
                db.gest_cheque.Add(gest_cheque);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.serie = new SelectList(db.asign_cheque_cp, "serie", "pago_a_orden", gest_cheque.serie);
            ViewBag.cuenta = new SelectList(db.gest_cuenta, "No_cuenta", "banco", gest_cheque.cuenta);
            return View(gest_cheque);
        }

        // GET: gest_cheque/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            gest_cheque gest_cheque = db.gest_cheque.Find(id);
            if (gest_cheque == null)
            {
                return HttpNotFound();
            }
            ViewBag.serie = new SelectList(db.asign_cheque_cp, "serie", "pago_a_orden", gest_cheque.serie);
            ViewBag.cuenta = new SelectList(db.gest_cuenta, "No_cuenta", "banco", gest_cheque.cuenta);
            return View(gest_cheque);
        }

        // POST: gest_cheque/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "serie,ingreso,banco,cuenta,estado,moneda")] gest_cheque gest_cheque)
        {
            if (ModelState.IsValid)
            {
                db.Entry(gest_cheque).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.serie = new SelectList(db.asign_cheque_cp, "serie", "pago_a_orden", gest_cheque.serie);
            ViewBag.cuenta = new SelectList(db.gest_cuenta, "No_cuenta", "banco", gest_cheque.cuenta);
            return View(gest_cheque);
        }

        // GET: gest_cheque/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            gest_cheque gest_cheque = db.gest_cheque.Find(id);
            if (gest_cheque == null)
            {
                return HttpNotFound();
            }
            return View(gest_cheque);
        }

        // POST: gest_cheque/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            gest_cheque gest_cheque = db.gest_cheque.Find(id);
            db.gest_cheque.Remove(gest_cheque);
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
