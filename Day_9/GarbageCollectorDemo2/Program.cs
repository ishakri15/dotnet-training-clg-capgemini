namespace GarbageCollectorDemo2;
class GarbageCollection : IDisposable
{
    public void DoSomething()
    {
        Console.WriteLine("performing usual tasks");
    }
    public void Dispose()
    {
        GC.SuppressFinalize(this);
        Console.WriteLine("disposing object");
        Console.WriteLine("freeing the resources captured by object");
    }
    ~GarbageCollection()
    {
        Console.WriteLine("destroying object");
        Console.WriteLine("freeing the resources captured by object");
    }
}
class Program
{
    static void Main(string[] args)
    {
        GarbageCollection garbage = new GarbageCollection();
        garbage.DoSomething();
        garbage.Dispose();
    }
}
