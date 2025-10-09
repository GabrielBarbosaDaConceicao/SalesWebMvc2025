using Microsoft.EntityFrameworkCore;
using SalesWebMvc.Data;
using SalesWebMvc.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace SalesWebMvc.Services
{
    public class DepartmentService
    {
        private readonly SallesWebMvcDbContext _context;
        public DepartmentService(SallesWebMvcDbContext context)
        {
            _context = context;
        }

        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }
    }
}