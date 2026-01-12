namespace staticFunctionDemo;

class Abcd{
    int a=1;
    static public void count(){
        Abcd obj = new Abcd();
        obj.a = obj.a + 1;
        Console.WriteLine($"The value is {obj.a}");
    }   
}
class Program
{
    static void Main(string[] args)
    {
        Abcd.count();
        Console.ReadLine();
    }
}
