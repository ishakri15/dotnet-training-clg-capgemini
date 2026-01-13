namespace Question1;
public abstract class Employee
{
    public abstract double CalculateSalaryp(double x, double y);
    public virtual void DisplayEmployeeInfo(string name, string empId)
    {
        Console.WriteLine($"Employee ID : {empId}");
        Console.WriteLine($"Employee name : {name}");
    }
}
public abstract class Employee2
{
    public abstract double CalculateSalaryc(double x, int y);
    public virtual void DisplayEmployeeInfo(string name, string empId)
    {
        Console.WriteLine($"Employee ID : {empId}");
        Console.WriteLine($"Employee name : {name}");
    }
}

class PermanentEmployee : Employee, IWork
{
    public override double CalculateSalaryp(double basicSalary, double benefits)
    {
        return basicSalary + benefits;
    }
    public void performWork()
    {
        Console.WriteLine("This is permanent employee");
    }
    public bool RequestLeave(int days)
    {
        if(days <= 30)
        {
            Console.WriteLine($"Leaves approved for {days} days");
            return true;
        }
        else
        {
            return false;
        }
    }
}
class ContractEmployee : Employee2, IWork
{
    public override double CalculateSalaryc(double hourlyRate, int hoursWorked)
    {
        return hourlyRate * hoursWorked;
    }
    public void performWork()
    {
        Console.WriteLine("This is contract employee");
    }
    public bool RequestLeave(int days)
    {
        if(days <= 10)
        {
            Console.WriteLine($"Leaves approved for {days} days");
            return true;  
        }
        else
        {
            return false;
        }
    }
}
interface IWork
{
    void performWork();
    bool RequestLeave(int days);
}
class Program
{
    static void Main(string[] args)
    {
        PermanentEmployee pp = new PermanentEmployee();
        ContractEmployee cc = new ContractEmployee();
        Console.WriteLine("Info of permanent employee");
        pp.DisplayEmployeeInfo("Raj","25");
        pp.performWork();
        pp.RequestLeave(20);
        Console.WriteLine($"Salary : {pp.CalculateSalaryp(25000,2500)}");
        Console.WriteLine("Info of contract employee");
        cc.DisplayEmployeeInfo("Riya","21");
        cc.performWork();
        cc.RequestLeave(9);
        Console.WriteLine($"Salary : {cc.CalculateSalaryc(2200,45)}");
    }
}
