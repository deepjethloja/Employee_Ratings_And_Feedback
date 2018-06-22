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
    public class Subtasks_AddController : Controller
    {
        private Db_1Entities db = new Db_1Entities();

        // GET: Subtasks_Add
        public ActionResult Index()
        {
            return View(db.Subtasks.ToList());
        }

        // GET: Subtasks_Add/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Subtask subtask = db.Subtasks.Find(id);
            if (subtask == null)
            {
                return HttpNotFound();
            }
            return View(subtask);
        }

        // GET: Subtasks_Add/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Subtasks_Add/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "SubtaskId,DeveloperId,ManagerId,Description,ProgressPercent,Deadline,CompletionStatus")] Subtask subtask)
        {
            if (ModelState.IsValid)
            {
                db.Subtasks.Add(subtask);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(subtask);
        }

        // GET: Subtasks_Add/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Subtask subtask = db.Subtasks.Find(id);
            if (subtask == null)
            {
                return HttpNotFound();
            }
            return View(subtask);
        }

        // POST: Subtasks_Add/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "SubtaskId,DeveloperId,ManagerId,Description,ProgressPercent,Deadline,CompletionStatus")] Subtask subtask)
        {
            if (ModelState.IsValid)
            {
                db.Entry(subtask).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(subtask);
        }

        // GET: Subtasks_Add/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Subtask subtask = db.Subtasks.Find(id);
            if (subtask == null)
            {
                return HttpNotFound();
            }
            return View(subtask);
        }

        // POST: Subtasks_Add/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Subtask subtask = db.Subtasks.Find(id);
            db.Subtasks.Remove(subtask);
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
