using API.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace API.DTO
{
    public class SalesDTO
    {
        public int Id { get; set; }
        public required string ProductName { get; set; }
        public required string CustomerName { get; set; }
        public required string SalesRepName { get; set; }
        public int Quantity { get; set; } = 1; //how many sold
        public DateTime ProductSoldDate { get; set; }
        [Column(TypeName = "decimal(18, 8)")]
        public decimal ProductSoldPrice { get; set; }
    }
}
