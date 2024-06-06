namespace Liskov
{
    public abstract class Employee
    {
        public string FullName { get; set; }
        public int HoursWorked { get; set; }

        public Employee(string fullName, int hoursWorked)
        {
            FullName = fullName;
            HoursWorked = hoursWorked;
        }

        public abstract decimal CalculateSalary();
    }
}
