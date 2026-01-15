namespace TryParseDemo;

class Program
{
    static void Main(string[] args)
    {
        //tryParseDemo();
        //parseDemo();
        Console.WriteLine("Enter product price : ");
        //decimal price = Convert.ToDecimal(Console.ReadLine());
        decimal price = Convert.ToDecimal(string.IsNullOrWhiteSpace(Console.ReadLine()));
        Console.WriteLine($"Product price is : {price}");
        Console.ReadLine();
    }

    private static void parseDemo()
    {
        Console.WriteLine("Enter product price : ");
        decimal price = decimal.Parse(Console.ReadLine());
        //here if you enter wrong value, it will throw an exception
        Console.WriteLine($"Product price is : {price}");
    }
    private static void tryParseDemo()
    {
        Console.WriteLine("Enter product price : ");
        string input = Console.ReadLine();
        bool isvalid = decimal.TryParse(input, out decimal price);
        //if it becomes true then it will store its value in price variable
        //try parse return type is boolean
        // for any type i can do tryparse ,here this will not throw exception 
        // becasue i am handing in else block the logic 
        if(isvalid)
        {
            Console.WriteLine($"Product price is : {price}");
        }
        else
        {
            Console.WriteLine("Invalid price input, please enter numeric value");
        }
    }
}
