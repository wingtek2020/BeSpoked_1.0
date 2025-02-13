using System;

namespace API.Entities
{
    public class Sales
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int Quantity{ get; set; } = 1;
        public int CustomerUserId { get; set; }
        public DateTime ProductSoldDate { get; set; }
        public decimal ProductSoldPrice { get; set; }
        public int ProductSalesRepUserId { get; set; }
        
    }
}
