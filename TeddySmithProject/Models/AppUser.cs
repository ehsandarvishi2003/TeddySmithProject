using Microsoft.AspNetCore.Connections;
using Microsoft.AspNetCore.Identity;
using Microsoft.Owin.BuilderProperties;

namespace TeddySmithProject.Models
{
    public class AppUser:IdentityUser
    {
        public int? Pace  { get; set; } 
        public Microsoft.Owin.BuilderProperties.Address? Adress { get; set; }
        public int Mileage { get; set; } 
    }
}
