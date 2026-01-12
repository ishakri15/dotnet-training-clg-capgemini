namespace refOutDemo;

class Program
{
    public void swapByOut(out int x, out int y){
        x=10;
        y=20;
        int temp;
        temp = x;
        x = y;
        y = temp;
        Console.WriteLine($"Inside function : {x}--{y}");
    }

    public void calculate(int a, int b, out int add, out int sub){
        add = a+b;
        sub = a-b;
    }
    static void Main(string[] args)
    {
        int a,b;
        Program p = new Program();
        p.swapByOut(out a, out b);
        
        int adds, subs;
        p.calculate(12,5, out adds, out subs);
        Console.WriteLine($"The addition is {adds} and substraction is {subs}");
        Console.ReadLine();
    }
}
