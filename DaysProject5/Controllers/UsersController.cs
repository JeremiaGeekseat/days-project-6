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
using RepositoryLayer;

namespace DaysProject6.Controllers
{
    public class UsersController : Controller
    {
        private ModelContext db = new ModelContext();
        private UserRepository repository = new UserRepository();

        // GET: Users
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(User user)
        {
            var login = repository.Login(user);

            var url = "";
            if (login != null)
                url = "../Home/Index";
            else
                url = "Index";

            return RedirectToAction(url);
        }

        [HttpPost]
        public ActionResult Register(User user)
        {
            repository.Update(user);

            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                repository.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
