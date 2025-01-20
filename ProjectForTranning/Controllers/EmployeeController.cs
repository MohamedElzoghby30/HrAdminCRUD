using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectForTranning.Models;
using ProjectForTranning.ViewModel;

namespace ProjectForTranning.Controllers
{
    public class EmployeeController : Controller
    {
        ApplicationDbContext context = new ApplicationDbContext();
        public IActionResult Index()
        {
            List<Empolyee> EmployeeList = context.Empolyee.ToList();
            return View("Index", EmployeeList);

        }
        public IActionResult Edit(Empolyee EmpFromRequest)
        {

            Empolyee EmpDB = context.Empolyee.FirstOrDefault(x => x.Id == EmpFromRequest.Id);

            return View("Edit", EmpDB);

        }
        public IActionResult Add()
        {
            EmployeeAndDept EmpolyeeDept = new EmployeeAndDept();
            EmpolyeeDept.Departments =  context.Department.ToList();

            return View("Add", EmpolyeeDept);
        }
        public IActionResult SaveEmp(Empolyee EmpFromRequest)
        {
            Empolyee EmpDB = new Empolyee();
            EmpDB.Name = EmpFromRequest.Name;
            EmpDB.Address = EmpFromRequest.Address;
            EmpDB.ImagURL = EmpFromRequest.ImagURL;
            EmpDB.JobTitle = EmpFromRequest.JobTitle;
            EmpDB.DepartmentID = EmpFromRequest.DepartmentID;
            context.Empolyee.Add(EmpFromRequest);
            context.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            Empolyee EmpDB = context.Empolyee.FirstOrDefault(x => x.Id == id);
            context.Empolyee.Remove(EmpDB);
            context.SaveChanges();
            return RedirectToAction("Index");

        }
        public IActionResult SaveEdit(Empolyee EmpFromRequest)
        {

            Empolyee EmpDB = context.Empolyee.FirstOrDefault(x => x.Id == EmpFromRequest.Id);
            EmpDB.Name = EmpFromRequest.Name;
            EmpDB.Address = EmpFromRequest.Address;
            EmpDB.ImagURL = EmpFromRequest.ImagURL;
            EmpDB.JobTitle = EmpFromRequest.JobTitle;
            EmpDB.Id = EmpFromRequest.Id;
            EmpDB.DepartmentID = EmpFromRequest.DepartmentID;
            context.SaveChanges();


            return RedirectToAction("Index");
        }

    }
}
