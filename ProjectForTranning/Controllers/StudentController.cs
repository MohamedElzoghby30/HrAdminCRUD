using Microsoft.AspNetCore.Mvc;
using ProjectForTranning.Models;

namespace ProjectForTranning.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ShowDetails(int num)
        {
            var st = new StudentBL();
            var X =st.GetStudent(num);
            return View("ShowDetails",X);
        }
        public IActionResult ShowAll(int num)
        {
            var st = new StudentBL();
            var X = st.GetAll();
            return View("ShowAll", X);
        }

    }
}
