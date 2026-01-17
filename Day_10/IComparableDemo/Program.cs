namespace IComparableDemo;

class Employee : IComparable
{
    public string Name { get; set; }
    public int Id { get; set; }
    public decimal Salary { get; set; }

    public Employee(string name, int id, decimal salary)
    {
        Name = name;
        Id = id;
        Salary = salary;
    }

    public override string ToString()
    {
        return $"{Name} (ID: {Id}, Salary: {Salary:C})";
    }
    public int CompareTo(object? obj)
    {
        Employee otherEmp = obj as Employee;
        decimal thisSalary = this.Salary;
        decimal otherEmpSalary = otherEmp.Salary;
        if(thisSalary < otherEmpSalary)
        {
            return -1;
        }
        else if(thisSalary > otherEmpSalary)
        {
            return 1;
        }
        else
        {
            return 0;
        }
    }

    // public int Compare(Employee? x, Employee? y)
    // {
    //     decimal thisSalary = x.Salary;
    //     decimal otherEmpSalary = y.Salary;
    //     if(thisSalary < otherEmpSalary)
    //     {
    //         return -1;
    //     }
    //     else if(thisSalary > otherEmpSalary)
    //     {
    //         return 1;
    //     }
    //     else
    //     {
    //         return 0;
    //     }
    // }
    
}
class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>() {12,67,8,2,78,43,22,90,129 };
            // primitive data types 

        numbers.Sort();
        foreach (int i in numbers)
        {
            Console.Write($"{i}  ");
        }

        List<Employee> employees = new List<Employee>() 
        {
            new Employee("Jane", 102, 75000m),
            new Employee("John", 101, 90000m),
            new Employee("Mike", 103, 65000m)
        };

        employees.Sort();
        Console.WriteLine("\n");
        foreach (Employee employee in employees)
        {
            Console.WriteLine(employee);
        }
    }
}
