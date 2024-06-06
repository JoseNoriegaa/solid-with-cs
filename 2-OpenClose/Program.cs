using OpenClose.Interfaces;
using OpenClose.Models;

ShowEmployeeMonthlySalary(new List<IEmployee>() {
    new EmployeeFullTime("Pepito Pérez", 160),
    new EmployeeFullTime("Manuel Lopera", 180),
    new EmployeeContractor("John Doe", 140)
});

void ShowEmployeeMonthlySalary(IEnumerable<IEmployee> employees)
{
    foreach (var employee in employees)
    {
        Console.WriteLine($"Empleado: {employee.FullName}, Pago: {employee.CalculateMonthlySalary():C1} ");
    }
}
