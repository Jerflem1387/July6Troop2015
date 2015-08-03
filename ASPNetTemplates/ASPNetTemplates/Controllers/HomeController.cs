using ASPNetTemplates.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPNetTemplates.Controllers
{
    public class HomeController : Controller
    {
        private IList<Product> _products;
        private IList<Customer> _customers;
        public HomeController()
        {
            _products = new List<Product>
            { 
            new Product { Id = 1, Name = "apple", Price = 3.99m, Weight = 4.78m},
            new Product { Id = 2, Name = "banana", Price = 2.99m, Weight = .55m}
            };
            _customers = new List<Customer>
            {
                new Customer { FirstName = "Bill", LastName = "Gates", PhoneNumber = 2543456789, Id = 1},
                new Customer { FirstName = "Steve", PhoneNumber = 2342342345, LastName = "Jobs", Id = 2}
            };
        }

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Detail(int id)
        {
            Product prod = _products.FirstOrDefault(p => p.Id == id);
            return View(prod);
        }

        public ActionResult Result(int id)
        {
            Customer cust = _customers.FirstOrDefault(p => p.Id == id);
            return View(cust);
        }

        public ActionResult Phone()
        {
            return View();
        }
    }
}