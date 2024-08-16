using Microsoft.AspNetCore.Mvc;
using RepositoryPatternMvc.Models;
using RepositoryPatternMvc.Repo;

namespace RepositoryPatternMvc.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly EmpRepo repo;
        public EmployeeController(EmpRepo repo) 
        {
            this.repo=repo;
        }
        public IActionResult Index()
        {
            var dt = repo.GetAllEmps();
            return View(dt);
        }
        public IActionResult AddEmp()
        {

            return View();
        }

        [HttpPost]
        public IActionResult AddEmp(Emp emp)
        {
            if (ModelState.IsValid)
            {
                repo.NewEmp(emp);
                TempData["msg"] = "Employee Added successfully";
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

    }
}
