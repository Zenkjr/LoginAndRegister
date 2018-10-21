using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace WebApplication7.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the WebApplication7User class
    public class WebApplication7User : IdentityUser
    {
        [PersonalData]
        public string Name { get; set; }
        [PersonalData]
        public DateTime Birthday { get; set; }
    }
}
