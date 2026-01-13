namespace OperatorOverloading;
class Abcd
{
    int a;
    public Abcd() //default constructor
    {
        
    }
    public Abcd(int k) //parameterized constructor
    {
        a = k;
    }
    public static Abcd operator+(Abcd abcd1, Abcd abcd2)
    {
        Abcd abcd3 = new Abcd();
        abcd3.a = abcd1.a + abcd2.a;
        Console.WriteLine($"The sum is {abcd3.a}");
        return abcd3;
    }
}
class Program
{
    static void Main(string[] args)
    {
        int x = 10;
        int y = 20;
        int z = x + y;
        Abcd abcd1 = new Abcd(100);
        Abcd abcd2 = new Abcd(200);
        Abcd abcd3 = new Abcd();
        abcd3 = abcd1 + abcd2;
        Abcd abcd4 = new Abcd(300);
        abcd3 = abcd1 + abcd2 + abcd4;
        Console.ReadLine();
    }
}
