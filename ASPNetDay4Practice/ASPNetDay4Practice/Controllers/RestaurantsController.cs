using ASPNetDay4Practice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPNetDay4Practice.Controllers
{
    public class RestaurantsController : Controller
    {
        private DataContext _db = new DataContext();

        // GET: Restaurants
        public ActionResult Index()
        {
            var rest = from r in _db.Restaurant select r;
            return View(rest.ToList());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Restaurants restaurant)
        {
            if (ModelState.IsValid)
            {
                _db.Restaurant.Add(restaurant);
                _db.SaveChanges();

                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Edit()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Edit(int id)
        {
            return View();
        }

        public ActionResult Delete()
        {
            return View();
        }

        [HttpPost]
        public ActionResult DeleteReally(int id)
        {
            return View();
        }

    }
}