namespace Repiper.DesignPatterns.Grasp.High.Cohesion.GOOD;

public class Employee
{
    public string Name { get; set; }
    public double Salary { get; set; }

    public Employee(string name, double salary)
    {
        Name = name;
        Salary = salary;
    }

    public double CalculateSalary()
    {
        return Salary * 12;
    }
}

public class EmployeeRepository
{
    public void Save(Employee employee)
    {
        Console.WriteLine("Employee Saved");
    }
}
    

public class PaySlipGenerator
{
    public void Generate(Employee employee)
    {
        // Gerar Holerite
        Console.WriteLine($"Generate payslip for: {employee.Name}");
    }
}