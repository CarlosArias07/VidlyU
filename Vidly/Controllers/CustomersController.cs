using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult CustomersList()
        {
            var customersList = new List<Customer>
            {
                new Customer { Id = 1, Name = "John Smith" },
                new Customer { Id = 2, Name = "Mary Williams" }
            };

            return View(customersList);
        }

        public ActionResult Details(int? id)
        {
            var customersList = new List<Customer>
            {
                new Customer { Id = 1, Name = "John Smith" },
                new Customer { Id = 2, Name = "Mary Williams" }
            };

            Customer cus = customersList.Find(x => x.Id == id);

            if (cus != null)
            {
                return View(cus);
            }
            else
            {
                return HttpNotFound();
            }
        }
    }  
}