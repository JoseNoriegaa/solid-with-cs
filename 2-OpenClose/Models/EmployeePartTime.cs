using OpenClose.Interfaces;

namespace OpenClose.Models
{
    internal class EmployeePartTime: IEmployee
    {
        public string FullName { get; set; }
        public int HoursWorked { get; set; }

        public EmployeePartTime(string fullName, int hoursWorked)
        {
            this.FullName = fullName;
            this.HoursWorked = hoursWorked;
        }

        public decimal CalculateMonthlySalary()
        {
            decimal hourValue = 20000M;
            decimal salary = hourValue * this.HoursWorked;

            if (this.HoursWorked > 160) {
                decimal effortCompensation = 5000M;
                int extraDays = this.HoursWorked - 160;
                salary += effortCompensation * extraDays;
            }

            return salary;
        }
    }
}
