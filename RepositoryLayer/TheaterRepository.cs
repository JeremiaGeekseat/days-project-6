using ModelLayer;
using ModelLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace RepositoryLayer
{
    public class TheaterRepository : IRepository<Theater>
    {
        private ModelContext db = new ModelContext();

        public void Delete(int id)
        {
            Theater theater = db.Theaters.Find(id);
            db.Theaters.Remove(theater);
            db.SaveChanges();
        }

        public void Dispose()
        {
            db.Dispose();
        }

        public void Insert(Theater obj)
        {
            db.Theaters.Add(obj);
            db.SaveChanges();
        }

        public void Update(Theater obj)
        {
            db.Entry(obj).State = EntityState.Modified;
            db.SaveChanges();
        }

        public Theater View(int? id)
        {
            Theater theater = db.Theaters.Find(id);
            return theater;
        }

        public List<Theater> ViewAll()
        {
            return db.Theaters.ToList();
        }
    }
}
