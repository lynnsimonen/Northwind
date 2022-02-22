using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Northwind.Models;

namespace Northwind.Controllers
{
    public class Product : Controller
    {
         // this controller depends on the NorthwindRepository
        private NorthwindContext _NorthwindContext;
        public Product(NorthwindContext db) => _NorthwindContext = db;

        public IActionResult Category() => View(_NorthwindContext.Categories.OrderBy(b => b.CategoryName));
    
    }
}