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
    public class SPONSORsController : Controller
    {
        private MyMarket db = new MyMarket();

        // GET: SPONSORs
        public ActionResult Index()
        {
            return View(db.SPONSOR.ToList());
        }

        // GET: SPONSORs/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SPONSOR sPONSOR = db.SPONSOR.Find(id);
            if (sPONSOR == null)
            {
                return HttpNotFound();
            }
            return View(sPONSOR);
        }

        // GET: SPONSORs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SPONSORs/Create
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "SPONSOR_ID,SPONSOR_NAME,PHONE_NUMBER")] SPONSOR sPONSOR)
        {
            if (ModelState.IsValid)
            {
                db.SPONSOR.Add(sPONSOR);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(sPONSOR);
        }

        // GET: SPONSORs/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SPONSOR sPONSOR = db.SPONSOR.Find(id);
            if (sPONSOR == null)
            {
                return HttpNotFound();
            }
            return View(sPONSOR);
        }

        // POST: SPONSORs/Edit/5
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "SPONSOR_ID,SPONSOR_NAME,PHONE_NUMBER")] SPONSOR sPONSOR)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sPONSOR).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sPONSOR);
        }

        // GET: SPONSORs/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SPONSOR sPONSOR = db.SPONSOR.Find(id);
            if (sPONSOR == null)
            {
                return HttpNotFound();
            }
            return View(sPONSOR);
        }

        // POST: SPONSORs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            SPONSOR sPONSOR = db.SPONSOR.Find(id);
            db.SPONSOR.Remove(sPONSOR);
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
