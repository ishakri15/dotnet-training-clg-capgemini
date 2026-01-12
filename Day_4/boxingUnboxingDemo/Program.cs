namespace boxingUnboxingDemo;

public  class Emp
    {
       public  int age;
    }
class Program
{
    static void Main(string[] args)
    {
        object objectone, objectwo; //referecne types
        string stringone;
        Emp emp = new Emp();
        
        int a; //value type
        a = 5;
        objectone = a; //boxing here value type to ref
        Console.WriteLine($"Object one is :{objectone} "); //object one
        //above ref to value type i am doing
        objectwo = 9; //this is also boxing directly
        stringone = a.ToString(); //i am converting and keeping it
        //above thing is also boxing only not compatible
        //then also i had kept
        Console.WriteLine($"string one is : {stringone}");
        emp.age = 12; // here also boxing is happing
        Console.WriteLine($"The employee a value is : {emp.age}");
        //above i am printing refercnes variable value unboxing
        
        int? salary; //nullable types it can store null values
        string? name;
        salary = null;
        name = null;
    }
}