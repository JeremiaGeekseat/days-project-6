using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ModelLayer;
using ModelLayer.Models;
using Kendo.Mvc.UI;
using Kendo.Mvc.Extensions;
using DaysProject6.Models;

namespace DaysProject6.Controllers
{
    public class TicketsController : Controller
    {
        private ModelContext db = new ModelContext();

        // GET: Tickets
        public ActionResult Index()
        {
            return View(db.Tickets.ToList());
        }

        // GET: Theaters
        public JsonResult GetTickets()
        {
            var result = db.Tickets.ToList().Select(ticket => new TicketView
            {
                ID = ticket.ID,
                Name = ticket.Name,
                Email = ticket.Email,
                Payment = ticket.Payment,
                Movie = ticket.Movie.Title,
                Theater = ticket.Theater.Name
            });

            return Json(result, JsonRequestBehavior.AllowGet);
        }

        //public JsonResult GetTickets([DataSourceRequest] DataSourceRequest request)
        //{
        //    var result = db.Tickets.ToList().ToDataSourceResult(request, ticket => new TicketView
        //    {
        //        ID = ticket.ID,
        //        Name = ticket.Name,
        //        Email = ticket.Email,
        //        Payment = ticket.Payment,
        //        Movie = ticket.Movie.Title,
        //        Theater = ticket.Theater.Name
        //    });

        //    return Json(result, JsonRequestBehavior.AllowGet);
        //}

        // GET: Tickets/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ticket ticket = db.Tickets.Find(id);
            if (ticket == null)
            {
                return HttpNotFound();
            }
            return View(ticket);
        }

        // GET: Tickets/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Tickets/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name,Email,Payment")] Ticket ticket)
        {
            if (ModelState.IsValid)
            {
                db.Tickets.Add(ticket);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(ticket);
        }

        // GET: Tickets/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ticket ticket = db.Tickets.Find(id);
            if (ticket == null)
            {
                return HttpNotFound();
            }
            return View(ticket);
        }

        // POST: Tickets/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name,Email,Payment")] Ticket ticket)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ticket).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ticket);
        }

        // GET: Tickets/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ticket ticket = db.Tickets.Find(id);
            if (ticket == null)
            {
                return HttpNotFound();
            }
            return View(ticket);
        }

        // POST: Tickets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Ticket ticket = db.Tickets.Find(id);
            db.Tickets.Remove(ticket);
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
