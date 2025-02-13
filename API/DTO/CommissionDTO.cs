using API.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace API.DTO
{
    public class CommissionDTO
    {
        public int Id { get; set; }
        public required string SalesRep { get; set; }       
        public decimal CommissionPercentage { get; set; }
    }
}
