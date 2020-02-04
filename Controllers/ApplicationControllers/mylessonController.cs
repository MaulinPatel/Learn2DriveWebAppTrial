using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Car_Rental.Models;

namespace Car_Rental.Controllers.ApplicationControllers
{
    public class mylessonController : Controller
    {
        private Model1 db = new Model1();

        // GET: mylesson
        public ActionResult Index()
        {
            return View(db.my_lesson.ToList());
        }

        // GET: mylesson/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            my_lesson my_lesson = db.my_lesson.Find(id);
            if (my_lesson == null)
            {
                return HttpNotFound();
            }
            return View(my_lesson);
        }

        // GET: mylesson/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: mylesson/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "user_id,user_name,inst_id,lesson_days,lesson_time")] my_lesson my_lesson)
        {
            if (ModelState.IsValid)
            {
                db.my_lesson.Add(my_lesson);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(my_lesson);
        }

        // GET: mylesson/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            my_lesson my_lesson = db.my_lesson.Find(id);
            if (my_lesson == null)
            {
                return HttpNotFound();
            }
            return View(my_lesson);
        }

        // POST: mylesson/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "user_id,user_name,inst_id,lesson_days,lesson_time")] my_lesson my_lesson)
        {
            if (ModelState.IsValid)
            {
                db.Entry(my_lesson).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(my_lesson);
        }

        // GET: mylesson/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            my_lesson my_lesson = db.my_lesson.Find(id);
            if (my_lesson == null)
            {
                return HttpNotFound();
            }
            return View(my_lesson);
        }

        // POST: mylesson/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            my_lesson my_lesson = db.my_lesson.Find(id);
            db.my_lesson.Remove(my_lesson);
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
