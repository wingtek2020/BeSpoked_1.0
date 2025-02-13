using System;

namespace API.Entities
{
    public class UserCommission
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public decimal CommissionPercentage { get; set; }
    }
}
