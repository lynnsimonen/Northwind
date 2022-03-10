using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Northwind.Models;

namespace Northwind.Controllers
{
    public class CustomerController: Controller
    {
       // this controller depends on the NorthwindRepository
        private NorthwindContext _NorthwindContext;
        public CustomerController(NorthwindContext db) => _NorthwindContext = db;

        public IActionResult CurrentAccount(int id) => View(_NorthwindContext.Customers.Where(p => p.CustomerId == id));

        //return a view when requested (/Customer/Register). 
        //The view will display a form designed to add customer data to the database.        
        [HttpGet]
        public IActionResult Register() => View();

        [HttpPost]
        public IActionResult Register(Customer customer) => View();

        }
}