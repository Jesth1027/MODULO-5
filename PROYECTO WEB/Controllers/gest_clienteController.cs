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
    public class gest_clienteController : Controller
    {
        private webEntities1 db = new webEntities1();

        // GET: gest_cliente
        public ActionResult Index()
        {
            return View(db.gest_cliente.ToList());
        }

        // GET: gest_cliente/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            gest_cliente gest_cliente = db.gest_cliente.Find(id);
            if (gest_cliente == null)
            {
                return HttpNotFound();
            }
            return View(gest_cliente);
        }

        // GET: gest_cliente/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: gest_cliente/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "nit,nombre,telefono,direccion,codigo,fecha")] gest_cliente gest_cliente)
        {
            if (ModelState.IsValid)
            {
                db.gest_cliente.Add(gest_cliente);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(gest_cliente);
        }

        // GET: gest_cliente/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            gest_cliente gest_cliente = db.gest_cliente.Find(id);
            if (gest_cliente == null)
            {
                return HttpNotFound();
            }
            return View(gest_cliente);
        }

        // POST: gest_cliente/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "nit,nombre,telefono,direccion,codigo,fecha")] gest_cliente gest_cliente)
        {
            if (ModelState.IsValid)
            {
                db.Entry(gest_cliente).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(gest_cliente);
        }

        // GET: gest_cliente/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            gest_cliente gest_cliente = db.gest_cliente.Find(id);
            if (gest_cliente == null)
            {
                return HttpNotFound();
            }
            return View(gest_cliente);
        }

        // POST: gest_cliente/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            gest_cliente gest_cliente = db.gest_cliente.Find(id);
            db.gest_cliente.Remove(gest_cliente);
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
