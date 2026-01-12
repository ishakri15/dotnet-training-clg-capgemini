namespace IfDemo;

class Program
{
    static void Main(string[] args)
    {
        ifdemo();
        ifelseDemo();
        Console.ReadLine();
    }
    private static void ifdemo(){
        //simple if demo
        int a,b,c,d,l;
        Console.WriteLine("enter values in a,b,c,d");
        a = Convert.ToInt32(Console.ReadLine());
        b = Convert.ToInt32(Console.ReadLine());
        c = Convert.ToInt32(Console.ReadLine());
        d = Convert.ToInt32(Console.ReadLine());
        l = a;
        if(b>l){
            l = b;
        }
        if(c>l){
            l = c;
        }
        if(d>l){
            l = d;
        }
        Console.WriteLine($"The largest number is {l}");
    }

    private static void ifelseDemo(){
        //if else demo
        int a,b,c,d;
        Console.WriteLine("enter values in a,b,c,d");
        a = Convert.ToInt32(Console.ReadLine());
        b = Convert.ToInt32(Console.ReadLine());
        c = Convert.ToInt32(Console.ReadLine());
        d = Convert.ToInt32(Console.ReadLine());
        if(a>b && a>c && a>d){
            Console.WriteLine($"The greatest number is {a}");
        }
        else if(b>c && b>d){
            Console.WriteLine($"The largest number is {b}");
        }
        else if(c>d){
            Console.WriteLine($"The largest number is {c}");
        }
        else{
            Console.WriteLine($"The largest number is {d}");
        }
    }
}
