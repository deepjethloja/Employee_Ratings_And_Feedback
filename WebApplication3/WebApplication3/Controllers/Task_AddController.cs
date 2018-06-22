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
    public class Task_AddController : Controller
    {
        private Db_1Entities db = new Db_1Entities();

        // GET: Task_Add
        public ActionResult Index()
        {
            return View(db.GetTaskInfoes.ToList());
        }

        // GET: Task_Add/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GetTaskInfo getTaskInfo = db.GetTaskInfoes.Find(id);
            if (getTaskInfo == null)
            {
                return HttpNotFound();
            }
            return View(getTaskInfo);
        }

        // GET: Task_Add/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Task_Add/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TaskId,ManagerId,Description,ProgressPercent,Deadline,CompletionStatus")] GetTaskInfo getTaskInfo)
        {
            if (ModelState.IsValid)
            {
                db.GetTaskInfoes.Add(getTaskInfo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(getTaskInfo);
        }

        // GET: Task_Add/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GetTaskInfo getTaskInfo = db.GetTaskInfoes.Find(id);
            if (getTaskInfo == null)
            {
                return HttpNotFound();
            }
            return View(getTaskInfo);
        }

        // POST: Task_Add/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TaskId,ManagerId,Description,ProgressPercent,Deadline,CompletionStatus")] GetTaskInfo getTaskInfo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(getTaskInfo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(getTaskInfo);
        }

        // GET: Task_Add/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GetTaskInfo getTaskInfo = db.GetTaskInfoes.Find(id);
            if (getTaskInfo == null)
            {
                return HttpNotFound();
            }
            return View(getTaskInfo);
        }

        // POST: Task_Add/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            GetTaskInfo getTaskInfo = db.GetTaskInfoes.Find(id);
            db.GetTaskInfoes.Remove(getTaskInfo);
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
