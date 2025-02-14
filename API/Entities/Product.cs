using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Entities
{
    public class Product
    {
  
        public int ProductId { get; set; }
        public required string ProductName { get; set; }
        public required string Manufacturer { get; set; }
        public required string Style { get; set; }
        [Column(TypeName = "decimal(18, 8)")]
        public decimal PurchasePrice { get; set; }
        public DateTime PurchaseDate { get; set; }
        [Column(TypeName = "decimal(18, 8)")]
        public decimal SalePrice { get; set; }
        [Column(TypeName = "decimal(18, 8)")]
        public int QuantityOH { get; set; } = 0;
        public bool Active { get; set; }
        public List<Sale>? Sales { get; set; }

    }
}
