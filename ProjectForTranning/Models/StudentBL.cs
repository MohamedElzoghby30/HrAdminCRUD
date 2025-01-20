namespace ProjectForTranning.Models
{
    public class StudentBL
    {
        List<Student> students =
        [
             new Student(){  Name="Mohamed" ,Id=5},
             new Student(){  Name="Ahmed" ,Id=6},
             new Student(){  Name="Mo" ,Id=7},
             new Student(){  Name="Ali" ,Id=8},
        ];
        public List<Student> GetAll()
        {
            return students;
        }

        public List<Student> GetStudent(int Id)
        {
            return students.Where(x=>x.Id==Id).ToList();
        }
    }
}
