using KhumaloCraft_Emporium.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace KhumaloCraft_Emporium.Data
{
    public class AppDbContext: IdentityDbContext<IdentityUser>

    {
    }

    public DbSet<User> Users { get; set; }
    public DbSet<Product> Products { get; set; }


}
