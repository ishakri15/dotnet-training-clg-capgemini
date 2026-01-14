namespace EnumDemo;

class Employee
{
    public int Id{set; get;}
    public string Name{set; get;}
    public EmployeeType Type{get; set;}
}
enum EmployeeType
{
    FullTime, PartTime, Contract 
}

class Program
{
    enum Weekdays{sun=10, mon, tues, wed, thurs=100, fri, sat};
    static void Main(string[] args)
    {
        Console.WriteLine($"{(int)Weekdays.fri}");
        Console.WriteLine($"{(int)Weekdays.mon}");
        Employee emp = new Employee();
        emp.Id = 101;
        emp.Name = "Riya";
        emp.Type = EmployeeType.FullTime;
        Console.WriteLine($"{emp.Id}---{emp.Name}---{emp.Type}");
        Console.ReadLine();
    }
}
