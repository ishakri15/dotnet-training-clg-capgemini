namespace EventDelegateInConsole;

class Program
{
    public Program()
    {
        myevent = new mydelegate1(testFunction);
    }
    public void testFunction()
    {
        Console.WriteLine("Test function called");
    }
    public delegate void mydelegate1();
    public event mydelegate1 myevent;
    static void Main(string[] args)
    {
        Program p = new Program();
        p.myevent();
        //above two lines can be written in a single line like this : 
        new Program().myevent();
        Console.ReadLine();
    }
}
