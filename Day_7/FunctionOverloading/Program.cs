namespace FunctionOverloading;
class Abcd
{
    public void add(int x, int y)
    {
        Console.WriteLine($"The sum of two integers is {x+y}");
    }
    //not an overloaded method
    // public int add(int y, int x)
    // {
    //     return {x+y};
    // }

    public double add(int k, decimal d, double dl)
    {
        return (k + Convert.ToDouble(d) + dl);
    }

    public decimal add(float k, decimal d, double dl)
    {
        return (Convert.ToDecimal(k) + d + Convert.ToDecimal(dl));
    }
}
class Cde : Abcd
{
    public void add(int x, char ch)
    {
        Console.WriteLine($"The sum is {x+ch}");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Cde cde = new Cde();
        cde.add(80,'A');
        cde.add(12,45);
        Console.WriteLine($"{cde.add(123.45F, 345.678M, 8992.899)}");
        Console.WriteLine($"{cde.add(12,456.67M,789.345)}");
    }
}
