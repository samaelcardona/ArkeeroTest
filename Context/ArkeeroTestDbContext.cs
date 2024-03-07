using ArkeeroTest.Models;
using Microsoft.EntityFrameworkCore;

namespace ArkeeroTest.Context
{
    public class ArkeeroTestDbContext : DbContext
    {
        public ArkeeroTestDbContext(DbContextOptions<ArkeeroTestDbContext> options)
            : base(options)
        {
            
        }

        public DbSet<Product> Products { get; set; }

    }
}
