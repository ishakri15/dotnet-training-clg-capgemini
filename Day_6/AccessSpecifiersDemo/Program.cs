using ClassLibrary1;
namespace AccessSpecifiersDemo;

class Abcd
{
    private int a = 1;
    public void seta(int k)
    {
        a = k;
    }
    public int geta()
    {
        return a;
    }
    public int b = 2;
    protected int c = 3;
}
class Program : Class1
{
    static void Main(string[] args)
    {
        Abcd obj = new Abcd();
        Program pp = new Program(); 
        obj.seta(1);
        Console.WriteLine($"{obj.geta()}"); // Accessible
        Console.WriteLine($"{obj.b = 10}"); //Accessible
        // Console.WriteLine($"{pp.b}");
        // Console.WriteLine($"{pp.c}");
        Console.WriteLine($"{pp.d}");
    }
}
