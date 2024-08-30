using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;

namespace CarInsurance.Controllers
{
    public class InsureeController : Controller
    {
        private InsuranceEntities db = new InsuranceEntities();

        // GET: Insuree
        public ActionResult Index()
        {
            //
            return View(db.Insurees.ToList());
        }
        // Creating insurance quote
        
        // GET: Insuree/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // GET: Insuree/Create
        public ActionResult Create()
        {

            return View();
        }

        // POST: Insuree/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                // Base start
                decimal quoteTotal = 50;
                var today = DateTime.Today;
                // Calculating age
                var age = today.Year - insuree.DateOfBirth.Year;
                if (age <= 18)
                {
                    // Adding 100 if user is 18 or under
                    quoteTotal += 100;
                }

                if (age >= 19 && age <= 25)
                {
                    // If users age is between 19-25 add 50
                    quoteTotal += +50;
                }
                if (age > 25)
                {
                    // If user is 26 or older, add 25
                    quoteTotal += +25;
                }
                if (insuree.CarYear < 2000)
                {
                    // If vehicle is older than 2000, add 25
                    quoteTotal += +25;
                }
                if (insuree.CarYear > 2015)
                {
                    // if vehicle age is after 2015, add 255
                    quoteTotal += +25;
                }
                if (insuree.CarMake == "porsche")
                {
                    // If vehicle is a porsche, add 25
                    quoteTotal += +25;
                }
                if (insuree.CarMake == "porsche" && insuree.CarModel == "911 carrera")
                {
                    // If car model is porsche and model is 911 carrera, add 50
                    quoteTotal += +50;
                }
                if (insuree.SpeedingTickets < 0)
                {
                    // Add 10 for each speeding ticket
                    decimal tickets = insuree.SpeedingTickets * 10;
                    
                    quoteTotal += +tickets;
                }
                if (insuree.DUI == true)
                {
                    // If user has a DUI, add 25%
                    quoteTotal *= 1.25m;                    
                }
                if (insuree.CoverageType == true)
                {
                    quoteTotal *= 1.50m;
                }
                db.Insurees.Add(insuree);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(insuree);
        }

        // GET: Insuree/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                db.Entry(insuree).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(insuree);
        }

        // GET: Insuree/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Insuree insuree = db.Insurees.Find(id);
            db.Insurees.Remove(insuree);
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
        public ActionResult Admin()
        {
            //
            return View(db.Insurees.ToList());
        }
    }
}
