namespace callByValueAndReference;

class Program
{
    public void swapByVal(int x, int y){
        int temp; 
        temp = x;
        x = y;
        y = temp;
    }
    public void swapByRef(ref int  x, ref int y){
        int temp;
        temp = x;
        x = y;
        y = temp;
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        int a,b;
        a = 10; 
        b = 20;
        Program p = new Program();
        Console.WriteLine($"Before swapping : {a}--{b}");
        p.swapByVal(a,b);
        Console.WriteLine($"After swapping by value: {a}--{b}");
        p.swapByRef(ref a,ref b);
        Console.WriteLine($"After swapping by reference: {a}--{b}");
        Console.ReadLine();
    }
}
