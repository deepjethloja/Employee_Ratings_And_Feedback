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
    public class Admin_AddController : Controller
    {
        private Db_1Entities db = new Db_1Entities();

        // GET: Admin_Add
        public ActionResult Index()
        {
            return View(db.ManagerLoginInfoes.ToList());
        }

        // GET: Admin_Add/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ManagerLoginInfo managerLoginInfo = db.ManagerLoginInfoes.Find(id);
            if (managerLoginInfo == null)
            {
                return HttpNotFound();
            }
            return View(managerLoginInfo);
        }

        // GET: Admin_Add/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin_Add/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "UserName,Password,Name,Image_url")] ManagerLoginInfo managerLoginInfo)
        {
            if (ModelState.IsValid)
            {
                
                db.ManagerLoginInfoes.Add(managerLoginInfo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(managerLoginInfo);
        }

        // GET: Admin_Add/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ManagerLoginInfo managerLoginInfo = db.ManagerLoginInfoes.Find(id);
            if (managerLoginInfo == null)
            {
                return HttpNotFound();
            }
            return View(managerLoginInfo);
        }

        // POST: Admin_Add/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,UserName,Password,Name,Image_url")] ManagerLoginInfo managerLoginInfo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(managerLoginInfo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(managerLoginInfo);
        }

        // GET: Admin_Add/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ManagerLoginInfo managerLoginInfo = db.ManagerLoginInfoes.Find(id);
            if (managerLoginInfo == null)
            {
                return HttpNotFound();
            }
            return View(managerLoginInfo);
        }

        // POST: Admin_Add/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ManagerLoginInfo managerLoginInfo = db.ManagerLoginInfoes.Find(id);
            db.ManagerLoginInfoes.Remove(managerLoginInfo);
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
