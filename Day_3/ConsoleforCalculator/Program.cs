using calculator;
namespace ConsoleforCalculator;

class Program
{
    static void Main(string[] args)
    {
        Class2 calc = new Class2();
        int a, b;
        Console.WriteLine("Enter values for a and b : ");
        a = Convert.ToInt32(Console.ReadLine());
        b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Addition : {calc.add(a,b)}");
        Console.WriteLine($"Substraction : {calc.sub(a,b)}");
        Console.WriteLine($"Multiplication : {calc.mul(a,b)}");
        Console.WriteLine($"Division : {calc.div(a,b)}");
    }
}
