using Microsoft.AspNetCore.Identity;
using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PizzaSite.Models
{
    public class AspNetUserModel : IdentityUser
    {

        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
