using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectForTranning.Models
{
    public class CourseResult
    {
        public int Id { get; set; }

        public double Degree { get; set; }
        public Course Course { get; set; }

        [ForeignKey(nameof(Course))]
        public int CourseId { get; set; }
        public Tranee Tranee { get; set; }

        [ForeignKey(nameof(Tranee))]
        public int TraneeId { get; set; }
    }
}
