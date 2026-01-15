namespace IndexerDemo;

class Abcd
{
    private string[] val = new string[3];
    public string this[int index]
    {
        set
        {
            val[index] = value;
        }
        get
        {
            return val[index];
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        Abcd obj = new Abcd();
        //when I want to use object array as property
        //then I will use indexers
        obj[0] = "CSharp";
        obj[1] = "Java";
        obj[2] = "Cpp";
        Console.WriteLine($"{obj[0]}--{obj[1]}--{obj[2]}");
    }
}
