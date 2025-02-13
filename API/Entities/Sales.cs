using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Entities
{
    public class Sales
    {
        public int Id { get; set; }
        [ForeignKey("ProductId")]
        public int ProductId { get; set; } //foreign key to Product
        public virtual required Product Product { get; set; }
        public int Quantity{ get; set; } = 1; //how many sold
        [ForeignKey("CustomerId")]
        public int CustomerId { get; set; } //foreign key to AppUser
        public virtual required AppUser Customer { get; set; }
        public DateTime ProductSoldDate { get; set; }
        [Column(TypeName = "decimal(18, 8)")]
        public decimal ProductSoldPrice { get; set; }
        [ForeignKey("SalesRepId")]
        public int SalesRepId { get; set; } //foreign key to AppUser
        public virtual required AppUser SalesRep { get; set; }

    }
}
