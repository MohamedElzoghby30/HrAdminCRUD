using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectForTranning.Models;

namespace ProjectForTranning.Controllers
{
    public class DepartmentController : Controller
    {
      ApplicationDbContext context = new ApplicationDbContext();
        public IActionResult Index()
        {
            
            List<Department> departmentList = context.Department.Include(x=>x.Empolyees).ToList();
            return View("Index", departmentList);
        }
        public IActionResult Add()
        {

            return View("Add");
        }
        [HttpPost]
        public IActionResult SaveDept(Department newDeptFromRequest)
        {
            if (newDeptFromRequest.Name != null)
            {
                context.Add(newDeptFromRequest);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View("Add",newDeptFromRequest);
        }
        [HttpGet]
        public IActionResult Edit( Department DeptFromRequset )
        {
           Department DeptDB= context.Department.FirstOrDefault(x => x.Id == DeptFromRequset.Id);

            return View("Edit", DeptDB);
        }
        [HttpPost]
        public IActionResult SaveEditDept( Department Dept )
        {
            var EmpFromDB = context.Department.FirstOrDefault(x => x.Id == Dept.Id);
            EmpFromDB.Name = Dept.Name;
            EmpFromDB.ManagerName = Dept.ManagerName;
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
