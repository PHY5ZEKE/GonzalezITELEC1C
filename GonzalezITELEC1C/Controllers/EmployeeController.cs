using Microsoft.AspNetCore.Mvc;

namespace GonzalezITELEC1C.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Employee()
        {
            return View();
        }
    }
}
