using Microsoft.AspNetCore.Mvc;
using Northwind.Models;
using System.Linq;

namespace Northwind.Controllers
{
    public class CustomerController: Controller
    {
       // this controller depends on the NorthwindRepository
        private NorthwindContext _NorthwindContext;
        public CustomerController(NorthwindContext db) => _NorthwindContext = db;

        // public IActionResult Register() => View();

        public IActionResult CustomerList() => View(_NorthwindContext.Customers.OrderBy(c => c.CompanyName));

        public IActionResult Register() => View();

        [HttpPost]
        [ValidateAntiForgeryToken]
        //Add Customer
        public IActionResult Register(Customer model)
        {            
            if (ModelState.IsValid)
            {
                if (_NorthwindContext.Customers.Any(b => b.CompanyName == model.CompanyName))
                {
                    ModelState.AddModelError("", "Name must be unique");
                }
                else
                {
                    _NorthwindContext.AddCustomer(model);
                    return RedirectToAction("CustomerList");
                }
            }            
            return View();
            model.CompanyName.Equals("");
        }
        public IActionResult DeleteCustomer(int id)
        {
            _NorthwindContext.DeleteCustomer(_NorthwindContext.Customers.FirstOrDefault(b => b.CustomerId == id));
            return RedirectToAction("CustomerList");
        }
     
    }
}