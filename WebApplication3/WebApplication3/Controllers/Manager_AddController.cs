using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication3;

namespace WebApplication3.Controllers
{
    public class Manager_AddController : Controller
    {
        private Db_1Entities db = new Db_1Entities();

        // GET: Manager_Add
        public ActionResult Index()
        {
            return View(db.DeveloperLoginInfoes.ToList());
        }

        // GET: Manager_Add/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DeveloperLoginInfo developerLoginInfo = db.DeveloperLoginInfoes.Find(id);
            if (developerLoginInfo == null)
            {
                return HttpNotFound();
            }
            return View(developerLoginInfo);
        }

        // GET: Manager_Add/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Manager_Add/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Username,Password")] DeveloperLoginInfo developerLoginInfo)
        {
            if (ModelState.IsValid)
            {
                db.DeveloperLoginInfoes.Add(developerLoginInfo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(developerLoginInfo);
        }

        // GET: Manager_Add/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DeveloperLoginInfo developerLoginInfo = db.DeveloperLoginInfoes.Find(id);
            if (developerLoginInfo == null)
            {
                return HttpNotFound();
            }
            return View(developerLoginInfo);
        }

        // POST: Manager_Add/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Username,Password")] DeveloperLoginInfo developerLoginInfo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(developerLoginInfo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(developerLoginInfo);
        }

        // GET: Manager_Add/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DeveloperLoginInfo developerLoginInfo = db.DeveloperLoginInfoes.Find(id);
            if (developerLoginInfo == null)
            {
                return HttpNotFound();
            }
            return View(developerLoginInfo);
        }

        // POST: Manager_Add/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DeveloperLoginInfo developerLoginInfo = db.DeveloperLoginInfoes.Find(id);
            db.DeveloperLoginInfoes.Remove(developerLoginInfo);
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
