using Microsoft.AspNetCore.Mvc;

namespace kostrykin
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var students = DataStudents.students;

            return View(students);
        }
    }
}