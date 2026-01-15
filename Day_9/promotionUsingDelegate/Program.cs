namespace promotionUsingDelegate;

public class Employee
{
    public int ID{get; set;}
    public string Name{get; set;}
    public decimal Salary{get; set;}
    public int Experience{get; set;}

    public Employee(int id, string name, decimal salary, int experience)
    {
        ID = id;
        Name = name;
        Salary = salary;
        Experience = experience;
    }
    public override string ToString()
    {
        return $"ID:{ID} Name:{Name} Salary:{Salary} Experience:{Experience}";
    }
}
public delegate bool PromotionCriteria(Employee emp);
public delegate void Notification(Employee emp);
class Program
{
    public static bool HighSalaryCriteria(Employee emp)
    {
        return emp.Salary > 80000;
    }
    public static bool ExperienceCriteria(Employee emp)
    {
        return emp.Experience >= 5;
    }
    public static void SendHRNotification(Employee emp)
    {
        Console.WriteLine($"HR Notification : Employee {emp.Name} has been promoted !!");
    }
    public static void TeamLeadNotification(Employee emp)
    {
        Console.WriteLine($"Team Lead Notification : Employee {emp.Name} has been promoted !!");
    }
    public static void FinanceTeamNotification(Employee emp)
    {
        Console.WriteLine($"Finance Team Notification : Employee {emp.Name} has been promoted !!");
    }
    public static void PromoteEmployees(Employee[] employees, PromotionCriteria promotionCriteria, params Notification[] notification)
    {
        foreach(var emp in employees)
        {
            if (promotionCriteria(emp))
            {
                Console.WriteLine($"Promoted : {emp}");
                foreach(var notify in notification)
                {
                    notify(emp);
                }
            }
        }
    }
    static void Main(string[] args)
    {
        var employees = new Employee[]
        {
            new Employee(101,"Alice",60000,6),
            new Employee(102,"Bob",45000,4),
            new Employee(103,"Charlie",88000,7),
            new Employee(104,"David",30000,2),  
            new Employee(105,"Eve",82000,8)
        };
        Console.WriteLine("Promotion based on high salary : ");
        PromoteEmployees(employees, HighSalaryCriteria, SendHRNotification, TeamLeadNotification);
        Console.WriteLine("Promotion based on experience : ");
        PromoteEmployees(employees, ExperienceCriteria, SendHRNotification, TeamLeadNotification);
    }
}
