using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using CarInsurance1.Models;

namespace CarInsurance1.Controllers
{
    public class InsureeController : Controller
    {
        private InsuranceEntities1 db = new InsuranceEntities1();

        public ActionResult AdminView()
        {
            List<Insuree> insurees = db.Insurees.ToList();

            return View(insurees);
        }


        // GET: Insuree
        public ActionResult Index()
        {
            return View(db.Insurees.ToList());
        }

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
                // Start with a base of $50 per month
                insuree.Quote = 50;

                // Calculate age of the user
                int age = DateTime.Now.Year - insuree.DateOfBirth.Year;

                // Add $100 to the monthly total if user is under 18
                if (age < 18)
                {
                    insuree.Quote += 100;
                }
                // Add $50 to the monthly total if user is between 19 and 25
                else if (age >= 19 && age <= 25)
                {
                    insuree.Quote += 50;
                }
                // Add $25 to the monthly total if user is over 25
                else if (age > 25)
                {
                    insuree.Quote += 25;
                }

                // Add $25 to the monthly total if car year is before 2000
                if (insuree.CarYear < 2000)
                {
                    insuree.Quote += 25;
                }
                // Add $25 to the monthly total if car year is after 2015
                else if (insuree.CarYear > 2015)
                {
                    insuree.Quote += 25;
                }

                // Add $25 to the price if car make is Porsche
                if (insuree.CarMake == "Porsche")
                {
                    insuree.Quote += 25;

                    // Add an additional $25 if car make is Porsche and model is 911 Carrera
                    if (insuree.CarModel == "911 Carrera")
                    {
                        insuree.Quote += 25;
                    }
                }

                // Add $10 to the monthly total for every speeding ticket the user has
                insuree.Quote += 10 * insuree.SpeedingTickets;

                // Add 25% to the total if the user has ever had a DUI
                if (insuree.DUI)
                {
                    insuree.Quote *= 1.25m;
                }

                // Add 50% to the total if it's full coverage
                if (insuree.CoverageType)
                {
                    insuree.Quote *= 1.5m;
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

    }
}
