namespace Repiper.DesignPatterns.Grasp.High.Cohesion.BAD;

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

    public void SaveEmployeeDatabase()
    {
        // Salvar no Banco de Dados
        Console.WriteLine("Saving employee database");
    }

    public void GeneratePaySlip()
    {
        // Gerar Holerite
        Console.WriteLine($"Generate playslip for {Name}");
    }
}