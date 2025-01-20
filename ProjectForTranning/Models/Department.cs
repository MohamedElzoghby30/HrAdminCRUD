namespace ProjectForTranning.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? ManagerName { get; set; }
        public List<Empolyee>? Empolyees { get; set; }
        public List<Instractor>? Instractors { get; set; }
        public List<Tranee>? Tranees { get; set; }
        public List<Course>? Courses { get; set; }

    }
}
