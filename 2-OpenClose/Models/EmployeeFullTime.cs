using OpenClose.Interfaces;

namespace OpenClose.Models
{
    internal class EmployeeFullTime: IEmployee
    {
        public string FullName { get; set; }
        public int HoursWorked { get; set; }

        public EmployeeFullTime(string fullName, int hoursWorked)
        {
            this.FullName = fullName;
            this.HoursWorked = hoursWorked;
        }

        public decimal CalculateMonthlySalary()
        {
            decimal hourValue = 30000M;
            return hourValue * this.HoursWorked;
        }
    }
}
