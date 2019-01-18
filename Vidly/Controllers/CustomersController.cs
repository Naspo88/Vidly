﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        private static List<Customer> _customers = new List<Customer>
        {
            new Customer { Name = "John Smith", Id = 1 },
            new Customer { Name = "Mary Williams", Id = 2 }
        };

        // GET: Customers
        public ActionResult Index()
        {
            return View(_customers);
        }

        // GET: Customers/Details/{id}
        public ActionResult Details(int id)
        {
            if (_customers.Exists(cust => cust.Id == id))
            {
                var customer = _customers.Find(cust => cust.Id == id);
                return View(customer);
            }

            return HttpNotFound();


        }
    }
}