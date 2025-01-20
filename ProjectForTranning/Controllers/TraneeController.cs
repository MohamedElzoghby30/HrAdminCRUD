using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectForTranning.Models;

namespace ProjectForTranning.Controllers
{
    public class TraneeController : Controller
    {
        ApplicationDbContext context = new ApplicationDbContext();
        public IActionResult Index()
        {
            List<Tranee> TraneeList = context.tranees.ToList();


            return View("Index",TraneeList);
        }
    }
}
