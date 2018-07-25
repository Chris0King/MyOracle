using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MySuperMarket.Models;

namespace MySuperMarket.Controllers
{
    public class SHELvesController : Controller
    {
        private MyMarket db = new MyMarket();

        // GET: SHELves
        public ActionResult Index()
        {
            return View(db.SHELF.ToList());
        }

        // GET: SHELves/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SHELF sHELF = db.SHELF.Find(id);
            if (sHELF == null)
            {
                return HttpNotFound();
            }
            return View(sHELF);
        }

        // GET: SHELves/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SHELves/Create
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "SHELF_ID,SHELF_AREA")] SHELF sHELF)
        {
            if (ModelState.IsValid)
            {
                db.SHELF.Add(sHELF);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(sHELF);
        }

        // GET: SHELves/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SHELF sHELF = db.SHELF.Find(id);
            if (sHELF == null)
            {
                return HttpNotFound();
            }
            return View(sHELF);
        }

        // POST: SHELves/Edit/5
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "SHELF_ID,SHELF_AREA")] SHELF sHELF)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sHELF).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sHELF);
        }

        // GET: SHELves/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SHELF sHELF = db.SHELF.Find(id);
            if (sHELF == null)
            {
                return HttpNotFound();
            }
            return View(sHELF);
        }

        // POST: SHELves/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            SHELF sHELF = db.SHELF.Find(id);
            db.SHELF.Remove(sHELF);
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
