namespace stringDemo;

class Program
{

    static void Main(string[] args)
    {
        //strings are immutable means once I try to modify the string
        //and again if I check whether it has modified it will not be 
        //bacause string is immutable means cannot be changed
        //but I can override the string within itself and at that time
        //I can modify the string

        string x = "Lucy_and_Roxy";
        x.Substring(0,6);
        Console.WriteLine($"The string x is not modified : {x}");

        //but we can do like this
        x = x.Substring(0,6);
        Console.WriteLine($"The string x is modified : {x}");

        //second thing about string is it is reference type
        string fname;
        string mname;
        string lname;
        Console.WriteLine("Enter first name : ");
        fname = Console.ReadLine();
        Console.WriteLine("Enter middle name : ");
        mname = Console.ReadLine();
        Console.WriteLine("Enter last name : ");
        lname = Console.ReadLine();

        string fullName = fname + " " + mname + " " + lname;
        Console.WriteLine($"{fullName}");
        string fullName2 = string.Concat(fname," ",mname," ",lname);
        Console.WriteLine($"{fullName2}");
        Console.WriteLine($"{fullName2.ToUpper()}");

        Console.WriteLine("\n Enter new fname to be replaced : ");
        string newfName = Console.ReadLine();
        Console.WriteLine($"The new full name is {fullName.Replace(fname,newfName)}");
        Console.ReadLine();
    }
}
