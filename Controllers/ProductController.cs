using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Northwind.Models;

namespace Northwind.Controllers
{
    public class ProductController : Controller
    {
         // this controller depends on the NorthwindRepository
        private NorthwindContext _NorthwindContext;
        public ProductController(NorthwindContext db) => _NorthwindContext = db;

        //modify Category method to sort categories by name
        //add Index controller method (pass filtered list of products to view)
        //NOTE: do not include discontinued products
        public IActionResult Category() => View(_NorthwindContext.Categories.OrderBy(b => b.CategoryName));

        //HELP!!! - link each category to a new controller method (Product/Index)
        public IActionResult Index(int id) => View(_NorthwindContext.Products.Where(p => p.CategoryId == id && p.Discontinued == false));   

        public IActionResult Discounts() => View();
    }
}