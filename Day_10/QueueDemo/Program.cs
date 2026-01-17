namespace QueueDemo;

class Program
{
    static void Main(string[] args)
    {
        Queue<string> queue = new Queue<string>();
        //FIFO
        queue.Enqueue("Annu");
        queue.Enqueue("Bishakha");
        queue.Enqueue("Chandani");
        queue.Enqueue("Disha");
        Console.WriteLine("Elements in queue : ");
        foreach(string name in queue)
        {
            Console.WriteLine(name);
        }

        //Dequeue elements from the queue
        string dequeuele = queue.Dequeue();
        Console.WriteLine($"the element dequeued is : {dequeuele}");
        Console.WriteLine("Elements in queue : ");
        foreach(string name in queue)
        {
            Console.WriteLine(name);
        }

        string peekedele = queue.Peek();
        Console.WriteLine($"the element peeked is : {peekedele}");
        Console.WriteLine("Elements in queue : ");
        foreach(string name in queue)
        {
            Console.WriteLine(name);
        }
    }
}
