using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Trash_collection.Models;

namespace Trash_collection.Controllers
{
    public class CalendersController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Calenders
        public ActionResult Index()
        {
            return View(db.Calender.ToList());
        }

        // GET: Calenders/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Calender Calender = db.Calender.Find(id);
            if (Calender == null)
            {
                return HttpNotFound();
            }
            return View(Calender);
        }

        // GET: Calenders/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Calenders/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Days,PickUpSchedule,PickUpDay,PickUpDates,Bill,RegularPickupActive,RegularPickupDayOfWee,RegularPickupStartDate,RegularPickupEndDate,RegularPickupPrice")] Calender calender)
        {
            Calender Calender = new Calender();
            foreach (DateTime day in Generate(calender.Days))
            {
                Calender.Days = day;
                db.Calender.Add(Calender);
                db.SaveChanges();
            }
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }

            return View(calender);
        }

        static List<DateTime> Generate(DateTime day)
        {
            List<DateTime> List = new List<DateTime>();
            List.Add(day);
            for (int i = 0; i < 729; i++)
            {
                day = day.AddDays(1);
                List.Add(day);
            }
            return List;
        }

        // GET: Calenders/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Calender calender = db.Calender.Find(id);
            if (calender == null)
            {
                return HttpNotFound();
            }
            return View(calender);
        }

        // POST: Calenders/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Days,PickUpSchedule,PickUpDay,PickUpDates,Bill,RegularPickupActive,RegularPickupDayOfWee,RegularPickupStartDate,RegularPickupEndDate,RegularPickupPrice")] Calender calender)
        {
            if (ModelState.IsValid)
            {
                db.Entry(calender).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(calender);
        }

        // GET: Calenders/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Calender calender = db.Calender.Find(id);
            if (calender == null)
            {
                return HttpNotFound();
            }
            return View(calender);
        }

        // POST: Calenders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Calender calender = db.Calender.Find(id);
            db.Calender.Remove(calender);
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
