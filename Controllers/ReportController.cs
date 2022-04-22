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

        public IActionResult Category() => View(_northwindContext.Categories.OrderBy(c => c.CategoryName));

        public IActionResult ReportOne(int id)
        {
            ViewBag.id = 1;
            return View(_northwindContext.Categories.OrderBy(c => c.CategoryName));
        }
//--------------------------------------------------------------------------------------------------------------------
        //Pull all orders within the last year
        //Group the orders by Orders.OrderId so the FK can then pull the OrderDetails.OrderId info to calculate sales
        public IActionResult Order() => View(_northwindContext.Orders.Where(d => d.OrderDate >= (DateTime.Now.AddYears(-1)))
        .GroupBy(p => p.OrderId));

       

        public IActionResult ReportTwo(ICollection<Order>ordersThisYear)
        {
        //Take the list of orders (grouped by Orders.OrderId) and do the following
        //group each (orderDetail.OrderId) by product
        //for each item in the group of products in orderdetails calculate sales with... ItemSale=UnitPrice*Quantity*(1-Discount)
        //Sum of ItemSales for each product group (within the last year)
        //To List
       // var OrderDetailPastYear = _northwindContext.OrderDetails.Where(o => o.OrderId().Contains(o.OrderDetailId)).ToList();
        
        ViewBag.ordersThisYear = 1;  //???
        return View(_northwindContext.OrderDetails.GroupBy(b => b.ProductId));
        }
    }
}