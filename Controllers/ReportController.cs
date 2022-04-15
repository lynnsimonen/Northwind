using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Northwind.Models;
using Newtonsoft.Json;

namespace Northwind.Controllers
{
    public class ReportController : Controller
    {
         // this controller depends on the NorthwindRepository
        private NorthwindContext _northwindContext;
        public ReportController(NorthwindContext db) => _northwindContext = db;


        
       //public IActionResult ReportOne() => View(_NorthwindContext.Categories.OrderBy(b => b.CategoryName));
  
       public IActionResult ReportOne() {
           List<Category> categories = _northwindContext.Categories.OrderBy(b => b.CategoryName).ToList();
            return View(categories);
       }


        public IActionResult ReportTwo() => View(_northwindContext.Discounts.OrderBy(b => b.DiscountId));

        // public IActionResult Index(int id)
        // {
        //     ViewBag.id = id;
        //     List<Category> categoryList = _northwindContext.Categories.OrderBy(c => c.CategoryName);            
        //     //ViewBag.categoryCurrent = _northwindContext.Categories.FirstOrDefault();
        //     return View(categoryList);
        // }
    }
}
