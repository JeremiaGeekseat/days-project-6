using ModelLayer;
using ModelLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace RepositoryLayer
{
    public class TicketRepository : IRepository<Ticket>
    {
        private ModelContext db = new ModelContext();

        public void Delete(int id)
        {
            Ticket ticket = db.Tickets.Find(id);
            db.Tickets.Remove(ticket);
            db.SaveChanges();
        }

        public void Dispose()
        {
            db.Dispose();
        }

        public void Insert(Ticket obj)
        {
            db.Tickets.Add(obj);
            db.SaveChanges();
        }

        public void Update(Ticket obj)
        {
            db.Entry(obj).State = EntityState.Modified;
            db.SaveChanges();
        }

        public Ticket View(int? id)
        {
            Ticket ticket = db.Tickets.Find(id);
            return ticket;
        }

        public List<Ticket> ViewAll()
        {
            return db.Tickets.ToList();
        }
    }
}
