using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Entities
{
    public class UserCommission
    {
        public UserCommission(int salesRepId, decimal commissionPercentage)
        {
            SalesRepId = salesRepId;
            CommissionPercentage = commissionPercentage;
        }
        public int Id { get; set; }
        [ForeignKey("SalesRepId")]
        public int SalesRepId { get; set; } //foreign key to AppUser
        public virtual AppUser? SalesRep { get; set; }

        [Column(TypeName = "decimal(18, 8)")]
        public decimal CommissionPercentage { get; set; }
        //public DateTime StartDate { get; set; }
        //public DateTime? EndDate { get; set; }
        public bool Active { get; set; } = true;
    }
}
