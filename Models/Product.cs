
namespace Northwind.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string QuantityPerUnit { get; set; }

        public decimal UnitPrice { get; set; }
        //[Column(TypeName = "decimal(18,2)")]
        public short UnitsInStock {get; set;}
        public short UnitsOnOrder {get; set;}
        public short ReorderLevel {get; set;}
        public bool Discontinued {get; set;}
        public int CategoryId {get; set;}
        public Category Category { get; set; }
    }
}