namespace OpenClose.Interfaces
{
    internal interface IEmployee
    {
        string FullName { get; set; }

        int HoursWorked { get; set; }

        decimal CalculateMonthlySalary();
    }
}
