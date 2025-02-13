using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;

namespace API.Entities
{
    public class AppUser
    {
        public int AppUserId { get; set; }
        public required string UserName { get; set; } //email for now
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? AddressLine1 { get; set; }
        public string? Phone { get; set; }
        public required DateTime StartDate { get; set; } //save UTC
        public DateTime? TerminationDate { get; set; } //if null not terminated



        public int RoleId { get; set; }
        public Role? Role { get; set; }
        public List<AppUser>? Customer { get; set; }
        public List<AppUser>? SalesRep { get; set; }

    }
}
