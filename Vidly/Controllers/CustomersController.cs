using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {        

        // GET: Customers
        public ActionResult Index()
        {

            var customers = GetCustomers();

            return View(customers);
        }


        public ActionResult Detail(int id)
        {
            var customer = GetCustomers().FirstOrDefault(x => x.Id == id);

            if (customer == null) return HttpNotFound();

            return View(customer);
        }

        private IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer>()
            {
                new Customer() { Name = "John Smith", Id = 1 },
                new Customer() { Name = "Mary Williams", Id = 2 }
            };
        }
    }
}