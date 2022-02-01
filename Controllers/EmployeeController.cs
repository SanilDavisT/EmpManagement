using Microsoft.AspNetCore.Mvc;

namespace EmpManagement.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddData(string n1,string n2,string n3)
        {
            return View();
        }
    }
}
