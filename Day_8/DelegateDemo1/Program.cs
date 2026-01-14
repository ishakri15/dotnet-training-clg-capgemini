namespace DelegateDemo1;
//delegate is a functional pointer
//return type of delegate should match with the method's return type
//and parameter should also match
class Program
{
    public static void add(int x, int y)
    {
        Console.WriteLine($"The sum is : {x+y}");
    }
    public static int substract(int x, int y)
    {
        return x - y;
    }
    public static int multiply(int x, int y)
    {
        return x * y;
    }
    public static void divide(int x, int y)
    {
        Console.WriteLine($"The division is : {x/y}");
    }

    public delegate void mydelegate1(int a, int b);
    public delegate int mydelegate2(int a, int b);
    static void Main(string[] args)
    {
        mydelegate1 m1 = add;
        m1(12, 45);
        mydelegate2 m2 = substract;
        Console.WriteLine($"The substraction is : {m2(43, 16)}");
        m2 += multiply; //multi cast delegate, same pointer pointing to multiple 
        Console.WriteLine($"The multiplication is : {m2(4, 16)}");
        mydelegate1 m3 = add;
        m3 += divide;
        m3.Invoke(100,50); //other way of calling a delegate

        //using for each loop
        mydelegate2 m4 = substract;
        m4 += multiply;
        foreach(mydelegate2 del in m4.GetInvocationList())
        {
            Console.WriteLine($"Result : {del(50,10)}");
        }
        Console.ReadLine();
    }
}
