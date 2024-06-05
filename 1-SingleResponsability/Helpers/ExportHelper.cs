using System.Text;
using SingleResponsibility.Models;

namespace SingleResponsibility.Helpers
{
    internal static class ExportHelper
    {
        public static void ExportStudents(IEnumerable<Student> students)
        {
            string csv = String.Join(",", students.Select(x => x.ToString()).ToArray());
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Id;FullName;Grades");

            foreach (var item in students)
            {
                sb.AppendLine($"{item.Id};{item.FullName};{String.Join("|", item.Grades)}");
            }

            File.WriteAllText(
                Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Students.csv"),
                sb.ToString(),
                Encoding.Unicode
            );
        }
    }
}
