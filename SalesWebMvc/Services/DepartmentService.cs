using SalesWebMvc.Data;
using SalesWebMvc.Models;
using System.Collections.Generic;
using System.Linq;
namespace SalesWebMvc.Services
{
    public class DepartmentService
    {
        private readonly SallesWebMvcDbContext _context;
        public DepartmentService(SallesWebMvcDbContext context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}