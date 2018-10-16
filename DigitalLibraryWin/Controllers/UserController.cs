using DigitalLibraryWin.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DigitalLibraryWin.Controllers
{
    public class UserController : Controller
    {
        // Get 
        public ActionResult Create()
        {
            var User = new User();
          
            User.Group = new List<UserGroup>();

            User.Group.Add(new UserGroup() { Name = "Fodbold", isInVolved = false });
            User.Group.Add(new UserGroup() { Name = "Basketball", isInVolved = false });
            User.Group.Add(new UserGroup() { Name = "Styrketræning", isInVolved = false });
            User.Group.Add(new UserGroup() { Name = "Playstation", isInVolved = false });
            return View(User);
               
        }

        [HttpPost]
        public ActionResult Create(User model)
        {
            Debug.WriteLine("Name: " + model.Username);
            foreach (var grp in model.Group)
            {
                Debug.WriteLine(grp.Name + " : " + grp.isInVolved.ToString());
            }
            return RedirectToAction("../Home/Index");
        }

        public ActionResult Edit()
        {
            var User = new User() {};

            return View(User);

        }

        public ActionResult Delete()
        {
            var User = new User() {};
            
            return View(User);

        }


    }
}