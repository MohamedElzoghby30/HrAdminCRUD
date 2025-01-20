using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectForTranning.Models
{
    public class Instractor
    { 
        public int Id { get; set; }
        public string Name { get; set; }

        public string Address { get; set; }
        public string ImgeUrl { get; set; }

        public decimal Salary { get; set; }
        [ForeignKey(nameof(Department))]
        public int DeptId { get; set; }
        public Department Department { get; set; }

        [ForeignKey(nameof(Course))]
        public int CourseId { get; set; }
        public Course Course { get; set; }

    }
}
