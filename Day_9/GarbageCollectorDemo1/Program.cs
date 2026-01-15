namespace GarbageCollectorDemo1;
class A
{
    public A()
    {
        Console.WriteLine("Creating A");
    }
    ~A()
    {
        for(int i=0; i<1000; i++);
        Console.WriteLine("destroying A");
    }
}
class B : A
{
    public B()
    {
        Console.WriteLine("Creating B");
    }
    ~B()
    {
        for(int i=0; i<1000; i++);
        Console.WriteLine("destroying B");
    }
}
class C : B
{
    public C()
    {
        Console.WriteLine("Creating C");
    }
    ~C()
    {
        for(int i=0; i<1000; i++);
        Console.WriteLine("destroying C");
    }
}
class Program
{
    static void Main(string[] args)
    {
        C cc = new C();
    }
}
