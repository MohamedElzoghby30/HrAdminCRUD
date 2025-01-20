using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectForTranning.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int MinDegree { get; set; }
        public int Degree { get; set; }

        List<Instractor> Instractors { get; set; }

        public Department Department { get; set; }

        [ForeignKey(nameof(Department))]
         public int DeptId { get; set; }
          
        public List<CourseResult> CourseResults { get; set; }


    }
}
