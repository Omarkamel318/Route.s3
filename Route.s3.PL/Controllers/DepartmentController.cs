using Microsoft.AspNetCore.Mvc;
using Route.s3.BLL.Interfaces;
using Route.s3.BLL.Repositories;

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
            return View();
        }
    }
}
