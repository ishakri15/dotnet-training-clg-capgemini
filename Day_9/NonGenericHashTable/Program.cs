using System.Collections;

namespace NonGenericHashTable;

class Program
{
    static void Main(string[] args)
    {
        Hashtable ht = new Hashtable();
        ht.Add(1,"kiran");
        ht.Add('a',789.77);
        ht.Add("Mahesh",DateTime.Now);
        foreach(DictionaryEntry entry in ht)
        {
            Console.WriteLine($"ID:{entry.Key}---Value:{entry.Value}");
        }
        if (ht.ContainsKey(1))
        {
            Console.WriteLine($"ID:1 , value is {ht[1]}");
        }
        ht.Remove('a');
        foreach(DictionaryEntry entry in ht)
        {
            Console.WriteLine($"ID:{entry.Key}---Value:{entry.Value}");
        }
        Console.ReadLine();
    }
}
