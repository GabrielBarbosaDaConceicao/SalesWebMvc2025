using Microsoft.EntityFrameworkCore;
using SalesWebMvc.Models;

namespace SalesWebMvc.Context
{
    public class SalesWebMvcDbContext : DbContext
    {
        public SalesWebMvcDbContext(DbContextOptions<SalesWebMvcDbContext> options) : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }
    }
}