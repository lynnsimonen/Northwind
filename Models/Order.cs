using System;
using System.ComponentModel.DataAnnotations.Schema;
namespace Northwind.Models
{
    public class Order
    {
        public int OrderId { get; set; }        
        public int CustomerId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime RequiredDate { get; set; }
        public DateTime ShippedDate { get; set; }
        public int ShipVia { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public Decimal Freight { get; set; }

        [Column(TypeName ="string(40)")]
        public string ShipName { get; set; }

        [Column(TypeName ="string(60)")]
        public string ShipAddress { get; set; }

        [Column(TypeName ="string(15)")]
        public string ShipCity { get; set; }

        [Column(TypeName ="string(15)")]
        public string ShipRegion { get; set; }

        [Column(TypeName ="string(10)")]
        public string ShipPostalCode { get; set; }

        [Column(TypeName ="string(15)")]
        public string Country { get; set; }
        
        [Column(TypeName = "decimal(5,3")]
        public Decimal Discount { get; set; }
    }
}