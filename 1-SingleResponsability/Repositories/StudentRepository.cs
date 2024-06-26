using SingleResponsibility.Models;

namespace SingleResponsibility.Repositories
{
    public class StudentRepository
    {
        private static FakeStorage<Student> storage = new();

        public StudentRepository()
        {
            InitData();
        }

        private void InitData()
        {
            storage.Add(new Student(1, "Pepito Pérez", new List<double>() { 3, 4.5 }));
            storage.Add(new Student(2, "Mariana Lopera", new List<double>() { 4, 5 }));
            storage.Add(new Student(3, "José Molina", new List<double>() { 2, 3 }));
        }

        public IEnumerable<Student> GetAll()
        {
            return storage.GetAll();
        }
    }
}
