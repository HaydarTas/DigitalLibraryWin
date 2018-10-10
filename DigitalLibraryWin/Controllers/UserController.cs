using DigitalLibraryWin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DigitalLibraryWin.Controllers
{
    public class UserController : Controller
    {
        // POST: User
        //[HttpPost]
        public ActionResult CreateUser()
        {
            User User = new User() { username = "Haydar", password = "*****" };
            return View(User);
               
        }

        public ActionResult UserEdit()
        {
            var User = new User() {};

            return View(User);

        }

        public ActionResult UserDelete()
        {
            var User = new User() {};
            
            return View(User);

        }


    }
}