using Microsoft.EntityFrameworkCore;
using SalesWebMvc.Models;

namespace SalesWebMvc.Context
{
    public class SalesWebMvcDbContext : DbContext
    {
        public SalesWebMvcDbContext(DbContextOptions<SalesWebMvcDbContext> options) : base(options)
        {
        }

        public DbSet<Department> Departments { get; set; }
    }
}