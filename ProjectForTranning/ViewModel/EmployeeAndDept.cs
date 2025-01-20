using ProjectForTranning.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectForTranning.ViewModel
{
    public class EmployeeAndDept
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Address { get; set; }
        public string ImagURL { get; set; }
        public string JobTitle { get; set; }
        public int DepartmentID { get; set; }
        public List<Department> Departments { get; set; }
    }
}
