namespace paramsDemo;

class Employee
{
    // public void Tsalary(int sal, int bonus, int allowances)
    // {
    //     Console.WriteLine($"Total salary is : {sal+bonus+allowances}");
    // }
    // public void Tsalary(int sal, int bonus, int allowances, int hraAllowances)
    // {
    //     Console.WriteLine($"Total salary is : {sal+bonus+allowances+hraAllowances}");
    // }
    // public void Tsalary(int sal, int bonus)
    // {
    //    Console.WriteLine($"Total salary is : {sal+bonus}");
    // }

    public void Tsalary(params int[] sal)
    {
        int ts = 0;
        for(int i=0; i<sal.Length; i++)
        {
            ts = ts + sal[i];
        }
        Console.WriteLine($"Total salary is : {ts}");
    }

}
class Program
{
    static void Main(string[] args)
    {
        Employee emp = new Employee();
        emp.Tsalary(50000,10000,5000);
        emp.Tsalary(50000,10000,5000,8000);
        emp.Tsalary(50000,10000);
        emp.Tsalary(50000, 10000, 5000, 8000, 2000, 3000);
    }
}
