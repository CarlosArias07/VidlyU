using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        private ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult New()
        {
            var membershipTypes = _context.MembershipTypes.ToList();
            var viewModel = new NewCustomerViewModel
            {
                MembershipTypes = membershipTypes
            };

            return View(viewModel);
        }

        public ActionResult CustomersList()
        {
            //Including related data (foreign key) is called ego loading
            var customersList = _context.Customers.Include(c => c.MembershipType).ToList();

            return View(customersList);
        }

        public ActionResult Details(int? id)
        {
            var cus = _context.Customers.Include(c => c.MembershipType).SingleOrDefault(c => c.Id == id);

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