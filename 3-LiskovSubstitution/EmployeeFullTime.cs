namespace Liskov
{
    public class EmployeeFullTime : Employee
    {
        public int ExtraHours { get; set; }

        public EmployeeFullTime(string fullname, int hoursWorked, int extraHours) : base(fullname, hoursWorked)
        {
            this.ExtraHours = extraHours;
        }

        public override decimal CalculateSalary()
        {
            decimal hourValue = 50;
            return hourValue * (this.HoursWorked + this.ExtraHours);
        }
    }
}
