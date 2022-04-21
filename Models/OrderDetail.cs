using System;
using System.ComponentModel.DataAnnotations.Schema;
namespace Northwind.Models
{
    public class OrderDetail
    {
        public int OrderDetailId { get; set; }
        public int OrderId { get; set; }        
        public int ProductId { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public Decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        
        [Column(TypeName = "decimal(5,3")]
        public Decimal Discount { get; set; }
    }
}