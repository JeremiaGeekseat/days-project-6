using ModelLayer;
using ModelLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer
{
    public class UserRepository : IRepository<User>
    {
        private ModelContext db = new ModelContext();

        public void Delete(int id)
        {
            User user = db.Users.Find(id);
            db.Users.Remove(user);
            db.SaveChanges();
        }

        public void Dispose()
        {
            db.Dispose();
        }

        public void Insert(User obj)
        {
            db.Users.Add(obj);
            db.SaveChanges();
        }

        public void Update(User obj)
        {
            db.Entry(obj).State = EntityState.Modified;
            db.SaveChanges();
        }

        public User View(int? id)
        {
            User user = db.Users.Find(id);
            return user;
        }

        public List<User> ViewAll()
        {
            return db.Users.ToList();
        }

        public User Login(User user)
        {
            User find = db.Users
                    .Where(u => u.Password == user.Password && u.Email == user.Email)
                    .SingleOrDefault();
            return find;
        }
    }
}
