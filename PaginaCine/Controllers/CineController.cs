using PaginaCine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace PaginaCine.Controllers
{
    public class CineController : Controller
    {
        readonly CinematronicDBConnection db = new CinematronicDBConnection();
        // GET: Cine
        public ActionResult Index()
        {
            var cines = db.Cines.ToList();
            return View(cines);
        }

        public ActionResult Details(int id)
        {
            var cine = db.Cines.Find(id);
            return View(cine);
        }

        public ActionResult Delete(int id)
        {
            var cine = db.Cines.Find(id);
            return View(cine);
        }

        public ActionResult Edit(int id)
        {
            var cine = db.Cines.Find(id);
            return View(cine);
        }

        [HttpPost]
        public ActionResult Edit(int id, Category c)
        {
            try
            {
                var category = db.Categories.Find(id);

                category.Name = c.Name;
                category.Description = c.Description;
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}