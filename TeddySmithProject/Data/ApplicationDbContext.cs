using Microsoft.EntityFrameworkCore;
using Microsoft.Owin.BuilderProperties;
using TeddySmithProject.Models;
using Address = TeddySmithProject.Models.Address;

namespace TeddySmithProject.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> option):base(option)
        {
            
        }
        public DbSet<Race> Races { get; set; }
        public DbSet<Club> Clubs { get; set; }
        public DbSet<Address> Addresses { get; set; }

    }
}
