using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Entities
{
    public class Discount
    {
        public int DiscountId { get; set; }
        public required string DiscountName { get; set; }
        [ForeignKey("ProductId")]
        public int ProductId { get; set; } //foreign key to Product
        public virtual Product? Product { get; set; }
        [Column(TypeName = "decimal(18, 8)")]
        public required decimal DiscountPercentage { get; set; }
        public required DateTime StartDate { get; set; }
        public required DateTime EndDate { get; set; }
        public bool Active { get; set; }

    }
}
