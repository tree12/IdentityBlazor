using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeshoCore.Entities.Enum;

namespace VeshoCore.Entities.Data
{
    public class VeshoIdentityUser: IdentityUser
    {
        public string PreName { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string? RegNo { get; set; } = string.Empty;
        public UserType UserType { get; set; } = UserType.VESHO;
        public string? Note { get; set; } = string.Empty;
    }
}
