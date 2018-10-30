using DigitalLibraryWin.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Web.Mvc;


namespace DigitalLibraryWin.Controllers
{
    public class UserController : Controller
    {
        sakilaEntities db = new sakilaEntities();

        public ActionResult Index()
        {
           List<user_table> user = db.user_table.ToList();

            return View(user);
        }

            // Get 
            public ActionResult Create()
        {
            var user = new User();
            
            
           /*  User.Group = new List<UserGroup>();

            User.Group.Add(new UserGroup() { Name = "Fodbold", isInVolved = false });
            User.Group.Add(new UserGroup() { Name = "Basketball", isInVolved = false });
            User.Group.Add(new UserGroup() { Name = "Styrketræning", isInVolved = false });
            User.Group.Add(new UserGroup() { Name = "Playstation", isInVolved = false }); */
            return View(user);
               
        }

        [HttpPost]
        [ValidateAntiForgeryToken]  
        public ActionResult Create([Bind(Include = "Email, Username, Password, ConfirmPassword, Date")] user_table model)
        {
            //Debug.WriteLine("Name: " + model.Username + " Email " + model.Email + " DatoForOprettelse " + model.Date);
            //foreach (var grp in model.Group)
            //{
            // Debug.WriteLine(grp.Name + " : " + grp.isInVolved.ToString());
            //}
            //model.Date = DateTime.Today;

            if (ModelState.IsValid)
            {
               
                {
                    db.user_table.Add(model);
                    db.SaveChanges();

                    return RedirectToAction("Index");
                }
            }
            return HttpNotFound();
            }

        
        //Get
        public ActionResult Edit(int? id)
        {
            user_table user = db.user_table.Find(id);
            if (user != null)
            {
                return View(user);
            }
            return HttpNotFound();

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id)
        {
            user_table user = db.user_table.Find(id);
            if (TryUpdateModel(user, "",
            new string[] { "Email", "Username", "Password", "ConfirmPassword"}))
            db.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult Delete(int? id)
        {
            if (id != null)
            {
                user_table user = db.user_table.Find(id);

                return View(user);
            }
            return HttpNotFound();
        }
            

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            user_table user = db.user_table.Find(id);
            db.user_table.Remove(user);
            db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}