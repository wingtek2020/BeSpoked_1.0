using System;

namespace API.DTO
{
    public class UserDTO
    {
        public int AppUserId { get; set; }
        public required string UserName { get; set; } //email for now
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? AddressLine1 { get; set; }
        public string? Phone { get; set; }
        public required DateTime StartDate { get; set; } //save UTC
        public DateTime? TerminationDate { get; set; } //if null not terminated
        public required string Role { get; set; }
    }
}
