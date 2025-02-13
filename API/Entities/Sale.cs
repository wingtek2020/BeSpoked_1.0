using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Entities
{
    public class Sale
    {
        public Sale(int productId, int quantity, int customerId, decimal productSoldPrice, int salesRepId)
        {
            ProductId = productId;
            Quantity = quantity;
            CustomerId = customerId;
            ProductSoldPrice = productSoldPrice;
            SalesRepId = salesRepId;
            ProductSoldDate = DateTime.Now;
        }
        public int Id { get; set; }
        [ForeignKey("ProductId")]
        public int ProductId { get; set; } //foreign key to Product
        public virtual Product? Product { get; set; }
        public int Quantity{ get; set; } = 1; //how many sold
        [ForeignKey("CustomerId")]
        public int CustomerId { get; set; }//foreign key to AppUser
        public virtual AppUser? Customer { get; set; }
        public DateTime ProductSoldDate { get; set; }
        [Column(TypeName = "decimal(18, 8)")]
        public decimal ProductSoldPrice { get; set; }
        [ForeignKey("SalesRepId")]
        public int SalesRepId { get; set; } //foreign key to AppUser
        public virtual AppUser? SalesRep { get; set; }

    }
}
