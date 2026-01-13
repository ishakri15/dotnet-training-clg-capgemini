namespace VirtuaFunctions;
class BaseClass
{
    public virtual void Display()
    {
        Console.WriteLine("base class display method");
    }
}
class SubClass : BaseClass
{
    public override void Display()
    {
        Console.WriteLine("sub class display method");
    }
}
class Program
{
    static void Main(string[] args)
    {
        BaseClass obj = new SubClass();
        obj.Display();
        Console.ReadLine();
    }
}
