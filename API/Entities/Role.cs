using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata;

namespace API.Entities
{
    public class Role
    {
        public int RoleId { get; set; }
        public required string Name { get; set; }


        public List<AppUser>? Users { get; set; }
    }
}
