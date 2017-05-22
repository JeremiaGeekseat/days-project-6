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

namespace DaysProject6.Controllers
{
    public class MoviesController : Controller
    {
        private ModelContext db = new ModelContext();

        // GET: Movies
        public ActionResult Index()
        {
            return View(db.Movies.ToList());
        }

        // GET: Movies
        public JsonResult GetMovies()
        {
            var result = db.Movies.ToList().Select(movie => new Movie
            {
                ID = movie.ID,
                Title = movie.Title,
                WeekendRevenure = movie.WeekendRevenure,
                GrossRevenue = movie.GrossRevenue,
                Released = movie.Released,
                Recommended = movie.Recommended
            });

            return Json(result, JsonRequestBehavior.AllowGet);
        }

        // GET: Movies
        public JsonResult GetMoviesName([DataSourceRequest] DataSourceRequest request)
        {
            var result = db.Movies.ToList().ToDataSourceResult(request, movie => movie.Title);

            return Json(result, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult Create(Movie model)
        {
            if (model != null)
            {
                db.Movies.Add(model);
                db.SaveChanges();
            }
            return Json(model);
        }

        [HttpPost]
        public void DeleteConfirmed(int id)
        {
            Movie movie = db.Movies.Find(id);
            db.Movies.Remove(movie);
            db.SaveChanges();
        }

        [HttpPost]
        public JsonResult Update(Movie model)
        {
            if (model != null)
            {
                db.Entry(model).State = EntityState.Modified;
                db.SaveChanges();
            }
            return Json(model);
        }

        // GET: Movies/Details/5
        public ActionResult Details(int? movieID)
        {
            if (movieID == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Movie movie = db.Movies.Find(movieID);
            if (movie == null)
            {
                return HttpNotFound();
            }
            return View(movie);
        }

        // GET: Movies/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Movies/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create([Bind(Include = "ID,Title,WeekendRevenure,GrossRevenue,Released,Recommended")] Movie movie)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Movies.Add(movie);
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }

        //    return View(movie);
        //}

        // GET: Movies/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Movie movie = db.Movies.Find(id);
            if (movie == null)
            {
                return HttpNotFound();
            }
            return View(movie);
        }

        // POST: Movies/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Title,WeekendRevenure,GrossRevenue,Released,Recommended")] Movie movie)
        {
            if (ModelState.IsValid)
            {
                db.Entry(movie).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(movie);
        }

        // GET: Movies/Delete/5
        //public ActionResult Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Movie movie = db.Movies.Find(id);
        //    if (movie == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(movie);
        //}

        // POST: Movies/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public ActionResult DeleteConfirmed(int id)
        //{
        //    Movie movie = db.Movies.Find(id);
        //    db.Movies.Remove(movie);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}

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
