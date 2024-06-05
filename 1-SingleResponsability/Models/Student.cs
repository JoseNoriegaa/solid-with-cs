namespace SingleResponsibility.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public List<double> Grades { get; set; }

        public Student()
        {
            this.FullName = string.Empty;
            this.Grades = new List<double>();
        }

        public Student(int id, string fullName, List<double> grades)
        {
            this.Id = id;
            this.FullName = fullName;
            this.Grades = grades;
        }
    }
}
