using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Entities
{
    public class UserCommission
    {
        public int Id { get; set; }
        public int AppUserId { get; set; }
        public AppUser? AppUser { get; set; }
        [Column(TypeName = "decimal(18, 8)")]
        public decimal CommissionPercentage { get; set; }
        //public DateTime StartDate { get; set; }
        //public DateTime? EndDate { get; set; }
        public bool Active { get; set; }
    }
}
