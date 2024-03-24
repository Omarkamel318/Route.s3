using Microsoft.AspNetCore.Mvc;
using Route.s3.BLL.Interfaces;
using Route.s3.BLL.Repositories;
using Route.s3.DAL.Models;

namespace Route.s3.PL.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly IDepartmentRepository _DepartmentRepo;

        public DepartmentController(DepartmentRepository DepartmentRepo)
        {
            _DepartmentRepo = DepartmentRepo;
        }


        public IActionResult Index()
        {
            var departments = _DepartmentRepo.GetAll();
            return View(departments);
        }
        [HttpGet] //by default
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Department department)
        {
            if(ModelState.IsValid)
            {
                 _DepartmentRepo.Add(department);
                 return RedirectToAction(nameof(DepartmentController.Index));

            }
            return View(department);
        }
    }
}
