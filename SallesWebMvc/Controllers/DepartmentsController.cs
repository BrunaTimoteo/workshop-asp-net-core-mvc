using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using SallesWebMvc.Models;

namespace SallesWebMvc.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Department> departamentos = new List<Department>();
            departamentos.Add(new Department()
            {
                Id = 1,
                Name = "Eletronics"
            });
            departamentos.Add(new Department()
            {
                Id = 2,
                Name = "Fashion"
            });

            return View(departamentos);
        }
    }
}