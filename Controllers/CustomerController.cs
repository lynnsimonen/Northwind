using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Northwind.Models;

namespace Northwind.Controllers
{
    public class CustomerController: Controller
    {
       // this controller depends on the NorthwindRepository
        private NorthwindContext _NorthwindContext;
        public CustomerController(NorthwindContext db) => _NorthwindContext = db;

        // public IActionResult Register() => View();

        public IActionResult CustomerList() => View(_NorthwindContext.Customers.OrderBy(c => c.CompanyName));

        [HttpPost]
        [ValidateAntiForgeryToken]
        //Add Customer
        public IActionResult Register(Customer customer)
        {
            if (ModelState.IsValid)
            {
                if (_NorthwindContext.Customers.Any(b => b.CompanyName == customer.CompanyName))
                {
                    ModelState.AddModelError("", "Name must be unique");
                }
                else
                {
                    _NorthwindContext.AddCustomer(customer);
                    return RedirectToAction("Index");
                }
            }
            return View();
        }
        public IActionResult DeleteCustomer(int id)
        {
            _NorthwindContext.DeleteCustomer(_NorthwindContext.Customers.FirstOrDefault(b => b.CustomerId == id));
            return RedirectToAction("Index");
        }
     
    }
}