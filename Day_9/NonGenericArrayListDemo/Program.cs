using System.Collections;

namespace NonGenericArrayListDemo;

class Program
{
    static void Main(string[] args)
    {
        ArrayList obj = new ArrayList();
        obj.Add(1);
        obj.Add(true);
        obj.Add("Raghav");
        obj.Add(DateTime.Now);
        obj.Add(234.567);
        Console.WriteLine($"no. of elements : {obj.Count}");
        Console.WriteLine($"capacity : {obj.Capacity}");
        foreach(var ele in obj)
        {
            Console.WriteLine(ele);
        }
        int[] fourmore = new int[]{100,200,300,400};
        obj.AddRange(fourmore);
        Console.WriteLine($"no. of elements : {obj.Count}");
        Console.WriteLine($"capacity : {obj.Capacity}");
        foreach(var ele in obj)
        {
            Console.WriteLine(ele);
        }
        obj.Insert(0,"first");
        obj.RemoveAt(3);
        Console.WriteLine($"no. of elements : {obj.Count}");
        Console.WriteLine($"capacity : {obj.Capacity}");
        foreach(var ele in obj)
        {
            Console.WriteLine(ele);
        }
        Console.ReadLine();
    }
}
