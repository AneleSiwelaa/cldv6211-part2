using KhumaloCraft_Emporium.Controllers;
using Microsoft.EntityFrameworkCore;

namespace KhumaloCraft_Emporium.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Work> Work { get; set; }
        public DbSet<About> About { get; set; }
        public DbSet<Contact> Contacts { get; set; }
   
    }
}
 