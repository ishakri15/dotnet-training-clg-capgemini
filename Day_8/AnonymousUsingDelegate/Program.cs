namespace AnonymousUsingDelegate;

class Program
{
    // public static void add(int x, int y)
    // {
    //     Console.WriteLine($"The sum is : {x+y}");
    // }
    // public static int substract(int x, int y)
    // {
    //     return x - y;
    // }
    // public static int multiply(int x, int y)
    // {
    //     return x * y;
    // }
    // public static void divide(int x, int y)
    // {
    //     Console.WriteLine($"The division is : {x/y}");
    // }
    public delegate void mydelegate1(int a, int b);
    public delegate int mydelegate2(int a, int b);
    static void Main(string[] args)
    {
       mydelegate1 m1 = delegate(int x, int y)
       {
           Console.WriteLine($"The sum is : {x+y}");
       }; 
       m1 += delegate(int x, int y)
       {
           Console.WriteLine($"The division is : {x/y}");
       };
       m1(12,4);
       mydelegate2 m2 = delegate(int x, int y)
       {
           return x - y;
       };
       Console.WriteLine($"Substraction : {m2.Invoke(12,2)}");
       m2 += delegate(int x, int y)
       {
           return x * y;
       };
       Console.WriteLine($"Multiplication : {m2.Invoke(12,2)}");
       Console.ReadLine();
    }
}
