namespace StackDemo;

class Program
{
    static void Main(string[] args)
    {
        Stack<int> numstack = new Stack<int>();
        
        //push elements in stack
        numstack.Push(10);
        numstack.Push(20);
        numstack.Push(30);
        numstack.Push(40);

        Console.WriteLine("Printing elements of stack : ");
        foreach(int i in numstack)
        {
            Console.WriteLine(i);
        }

        //pop elements from stack
        int poppedElement = numstack.Pop();
        Console.WriteLine($"Popped element : {poppedElement}");
        Console.WriteLine("Printing elements of stack : ");
        foreach(int i in numstack)
        {
            Console.WriteLine(i);
        }

        //peek the top element without removing it
        int topElement = numstack.Peek();
        Console.WriteLine($"Peeked element : {topElement}");
        foreach(int i in numstack)
        {
            Console.WriteLine(i);
        }
    }
}
