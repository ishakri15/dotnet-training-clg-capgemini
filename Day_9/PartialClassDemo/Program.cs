namespace PartialClassDemo;

public partial class Employee
{
    public int EmpId{get; set;}
    public string EmpName{get; set;}
    public Employee(int empId, string empName)
    {
        this.EmpId = empId;
        this.EmpName = empName;
    }
}
public partial class Employee
{
    public void DisplayEmployee()
    {
        Console.WriteLine($"{EmpId}---{EmpName}");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Employee emp = new Employee(101,"Alice");
        emp.DisplayEmployee();
        Console.ReadLine();
    }
}
