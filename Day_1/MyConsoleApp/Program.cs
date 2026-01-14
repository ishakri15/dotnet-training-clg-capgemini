namespace MyConsoleApp;

class Program
{
    static void Main(string[] args)
    {
        int x, y, z;
        Console.WriteLine("Enter values in x and y...");
        x = Convert.ToInt32(Console.ReadLine());
        y = int.Parse(Console.ReadLine());
        z = x + y;
        Console.WriteLine("The sum of {0} and {1} is {2}", x, y, z);
        Console.WriteLine("The sum of " + x + " and " + y + " is " + z);
        Console.WriteLine("The sum of {0,6} and {1,7} is {2,9}", x, y, z);
        //latest way to do is 
        Console.WriteLine($"The sum of {x} and {y} is {z}");
        // printinng constants
        Console.WriteLine($"The value is {45}");
        Console.WriteLine($"The febuary month as either {28} or {29} days ");
        //entering values in a single line 
        Console.WriteLine("enter values in a single line ..");
        string input = Console.ReadLine();
        int m, n;
        m = Convert.ToInt32(input.Split(',')[0]);
        n = Convert.ToInt32(input.Split(',')[1]);
        Console.WriteLine($"The sum of {m} and {n} is {m + n}");
        Console.WriteLine("enter values in a single line but use delimiter from array");
        char[] chars = new char[] { ',', '.', '$', '-' };
        string input1 = Console.ReadLine();
        int m1, n1;
        m1 = Convert.ToInt32(input1.Split(chars)[0]);
        n1 = Convert.ToInt32(input1.Split(chars)[1]);
        Console.WriteLine($"The sum of {m1} and {n1} is {m1 + n1}");
        //findinng range for datta types manualyy with code 
        Console.WriteLine($"the max value of int is " +
            $"{int.MaxValue} and minimum value {int.MinValue}");
        Console.WriteLine($"the max value of byte is " +
           $"{byte.MaxValue} and minimum value {byte.MinValue}");

        //some more data types 
        float ss = 34.56F;
        decimal tt = 897.876M;
        string str = "Raghavendra";
        char ch = 'u';
        Console.WriteLine($"{ss}--- {tt}--- {str}--- {ch}");
    }
}