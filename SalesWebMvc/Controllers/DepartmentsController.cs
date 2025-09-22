using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using SalesWebMvc.Models;

namespace SalesWebMvc.Controllers
{
    public class DepartmentsController : Controller
    {
        private List<Department> list = new List<Department>();

        public IActionResult Index()
        {
            list.Add(new Department { Id = 1, Name = "Computers" });
            list.Add(new Department { Id = 2, Name = "Electronics" });
            list.Add(new Department { Id = 3, Name = "Fashion" });
            list.Add(new Department { Id = 4, Name = "Books" });

            return View(list);
        }
    }
}