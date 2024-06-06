using OpenClose.Interfaces;

namespace OpenClose.Models
{
    internal class EmployeeContractor: IEmployee
    {

        public string FullName { get; set ; }
        public int HoursWorked { get; set ; }

        public EmployeeContractor(string fullName, int hoursWorked)
        {
            this.FullName = fullName;
            this.HoursWorked = hoursWorked;
        }        

        public decimal CalculateMonthlySalary()
        {
            decimal hourValue = 20000M;
            return hourValue * this.HoursWorked;
        }
    }
}
