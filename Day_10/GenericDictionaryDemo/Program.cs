namespace GenericDictionaryDemo;

class Customer
{
    public int Id{get; set;}
    public string Name{get; set;}

}
class Program
{
    static void Main(string[] args)
    {
        Dictionary<int,string> dic = new Dictionary<int, string>();
        Console.WriteLine("Enter number of elements in dictionary");
        int counter = Convert.ToInt32(Console.ReadLine());
        for(int i=0; i<counter; i++)
        {
            Console.WriteLine("Enter key : ");
            int key = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value : ");
            string value = Console.ReadLine();
            dic.Add(key,value);
        }
        Console.WriteLine("Printing the dictionary : ");
        foreach(KeyValuePair<int,string> pair in dic)
        {
            Console.WriteLine($"{pair.Key}:{pair.Value}");
        }

        Dictionary<double, Customer> dicOfCust = new Dictionary<double, Customer>()
        {
            {101.456, new Customer{Id = 101, Name = "riya"}},
            {234.457, new Customer{Id = 105, Name = "diya"}},
            {121.436, new Customer{Id = 101, Name = "riya"}}
        };
        Console.ReadLine();
    }
}
