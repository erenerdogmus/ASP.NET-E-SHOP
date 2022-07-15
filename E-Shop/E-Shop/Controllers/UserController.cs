using DataAccessLayer.Context;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace E_Shop.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        DataContext db =new DataContext();
        public ActionResult Update()
        {
            var username = (String)Session["Mail"];
            var değerler = db.Users.FirstOrDefault(x => x.Email == username);
            return View(değerler);
        }
        [HttpPost]
        public ActionResult Update(User data)
        {
            var username = (String)Session["Mail"];
            var user = db.Users.Where(x => x.Email == username).FirstOrDefault();
            user.Name = data.Name;
            user.SurName = data.SurName;
            user.Email = data.Email;
            user.Password = data.Password;
            user.RePassword = data.RePassword;
            user.UserName = data.UserName;
            db.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}