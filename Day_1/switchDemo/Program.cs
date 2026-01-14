namespace switchDemo;

class Program
{
    static void Main(string[] args)
    {
        int a,b,c;
        char ch;
        Console.WriteLine("enter two numbers");
        a = Convert.ToInt32(Console.ReadLine());
        b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("enter your choice");
        Console.WriteLine("*********************************");
        Console.WriteLine("A.Addition\nB.Subtraction\nC.Multiplication\nD.Division");
        ch = Convert.ToChar(Console.ReadLine());
        switch(ch){
            case 'A':
              case 'a':
                c=a+b;
                Console.WriteLine($"The addition of {a} and {b} is {c}");
                break;
            case 'B':
              case 'b':
                c=(a>b)?(a-b):(b-a);
                Console.WriteLine($"The subtraction of {a} and {b} is {c}");
                break;
            case 'C':
              case 'c':
                c=a*b;
                Console.WriteLine($"The multiplication of {a} and {b} is {c}");
                break;
            case 'D':
              case 'd': 
                    c=a/b;
                    Console.WriteLine($"The division of {a} and {b} is {c}");
                    break;
            default:
                Console.WriteLine("Invalid choice");
                break;
        }
    }
}
