namespace NamedOptionalParameterDemo;

class Program
{
    public static void ShowMessage(int age = 28, String name = "Mr. X"){
        Console.WriteLine($"The person with name {name} is having age {age}");
    }
    static void Main(string[] args)
    {
        ShowMessage(24,"Alice");
        ShowMessage(name : "Bob", age : 30); //named parameter
        ShowMessage(); //default values are given in the method parameters
        ShowMessage(name : "Charlie"); //default age is taken
        ShowMessage(age : 35); //default name is taken
        Console.ReadLine();
    }
}
