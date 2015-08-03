using ShoppingList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShoppingList.Controllers
{
    public class ShoppingListController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {
            List<Products> products = new List<Products>
            {
                new Products {Name = "Apple", Price = 1.99m},
                new Products {Name = "Eggs", Price = 3.29m},
                new Products {Name = "Ice Cream", Price = 4.99m}
            };
            
            
            List<Customer> customer = new List<Customer>
            {
                new Customer { ListOfProducts = products, LastName = "Fleming", FirstName = "Jeremy"}
            };

            IndexViewModel vm = new IndexViewModel
            {
                Customers = customer
            };
            
            return View(vm);
        }

        public ActionResult Create()
        {
            Products product = new Products();
            return View(product);
        }

        [HttpPost]
        public ActionResult Create(Products product)
        {
            return View();
        }

    }


}