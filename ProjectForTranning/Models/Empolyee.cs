using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectForTranning.Models
{
    public class Empolyee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Address { get; set; }
        public string ImagURL { get; set; }
        public string JobTitle { get; set; }

        public Department? Department { get; set; }

        [ForeignKey(nameof(Department))]
        public int DepartmentID { get; set; }

    }
}
