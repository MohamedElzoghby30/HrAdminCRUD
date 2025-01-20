using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectForTranning.Models
{
    public class Tranee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string Address { get; set; }
        public int Grade { get; set; }
        Department Department { get; set; }

        [ForeignKey(nameof(Department))]
        public int DeptId { get; set; }

        public List<CourseResult> courseResults { get; set; }
       
    }
}
