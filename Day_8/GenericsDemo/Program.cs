namespace GenericsDemo;

class Program
{
    // public static void swap(ref int x, ref int y)
    // {
    //     int temp;
    //     temp = x;
    //     x = y;
    //     y = temp;
    // }
    // public static void swap(ref DateTime x, ref DateTime y)
    // {
    //     DateTime temp;
    //     temp = x;
    //     x = y;
    //     y = temp;
    // }
    // public static void swap(ref string x, ref string y)
    // {
    //     string temp;
    //     temp = x;
    //     x = y;
    //     y = temp;
    // }
    static void Main(string[] args)
    {
        DateTime date1 = DateTime.Now;
        DateTime date2 = DateTime.Now.AddDays(2);
        Console.WriteLine("\n before swapping");
        Console.WriteLine($"Date1:{date1} \nDate2:{date2}");
        //swap(ref date1, ref date2);
        Helper1.swap<DateTime>(ref date1, ref date2);
        Console.WriteLine("\nAfter swapping");
        Console.WriteLine($"Date1:{date1} \nDate2:{date2}");

        int a = 10, b = 20;
        Console.WriteLine("\n before swapping");
        Console.WriteLine($"a:{a} \nb:{b}");
        Helper1.swap<int>(ref a, ref b);
        Console.WriteLine("\nAfter swapping");
        Console.WriteLine($"a:{a} \nb:{b}");
        Console.WriteLine($"The int sum is : {Helper1.add(a,b)}");

        double d1 = 344.56;
        double d2 = 678.23;
        Console.WriteLine($"The double sum is : {Helper1.add(d1,d2)}");


        Console.WriteLine("\n before swapping");
        Console.WriteLine($"d1:{d1} \nd2:{d2}");
        Helper2<double>.swap(ref d1, ref d2);
        Console.WriteLine("\n after swapping");
        Console.WriteLine($"d1:{d1} \nd2:{d2}");
        Console.WriteLine($"The double sum is : {Helper2<double>.add(d1,d2)}");
        Console.WriteLine($"The int sum is : {Helper2<int>.add(a,b)}");
        Console.ReadLine();
}
}
