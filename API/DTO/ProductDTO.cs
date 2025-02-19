﻿using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.DTO
{
    public class ProductDTO
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
        public decimal DiscountPercentage { get; set; }
        public int QuantityOH { get; set; } = 0;
        public bool Active { get; set; }
    }
}
