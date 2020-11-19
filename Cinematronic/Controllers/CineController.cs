using Cinematronic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cinematronic.Controllers
{
    public class CineController : Controller
    {
        readonly CineDbConnection db = new CineDbConnection();
        // GET: Cine
        public ActionResult Index()
        {
            var cines = db.Cines.ToList();
            return View(cines);
        }
        public ActionResult Delete(int id)
        {
            var cine = db.Cines.Find(id);
            return View();
        }
    }
}