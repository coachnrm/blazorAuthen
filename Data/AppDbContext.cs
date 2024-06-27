using blazorAuthen.Models;
using Microsoft.EntityFrameworkCore;

namespace blazorAuthen.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<ApplicationUser> Users {get; set;}

    }
}