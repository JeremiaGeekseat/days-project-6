using ModelLayer;
using ModelLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace RepositoryLayer
{
    public class MovieRepository : IRepository<Movie>
    {
        private ModelContext db = new ModelContext();

        public void Delete(int id)
        {
            Movie movie = db.Movies.Find(id);
            db.Movies.Remove(movie);
            db.SaveChanges();
        }

        public void Dispose()
        {
            db.Dispose();
        }

        public void Insert(Movie obj)
        {
            db.Movies.Add(obj);
            db.SaveChanges();
        }

        public void Update(Movie obj)
        {
            db.Entry(obj).State = EntityState.Modified;
            db.SaveChanges();
        }

        public Movie View(int? id)
        {
            Movie movie = db.Movies.Find(id);
            return movie;
        }

        public List<Movie> ViewAll()
        {
            return db.Movies.ToList();
        }
    }
}
