namespace setAndGetMethodsDemo;

class Customer
{
    //private int ID;
    //private string CustomerName;
    //Another way
    private int _cid = -1;
    public int ID
    {
        set
        {
            _cid = value;
        }
        get
        {
            return _cid;
        }
    }
    private string _Cname = string.Empty;
    public string CustomerName
    {
        set
        {
            _Cname = value;
        }
        get
        {
            return _Cname;
        }
    }
    // public void setID(int k)
    // {
    //     ID = k;
    // }
    // public int getID()
    // {
    //     return ID;
    // }
    // public void setCustomerName(string name)
    // {
    //     CustomerName = name;
    // }
    // public string getCustomerName()
    // {
    //     return CustomerName;
    // }
}
class Program
{
    static void Main(string[] args)
    {
        Customer obj = new Customer();
        // obj.setID(23);
        // obj.setCustomerName("Riya");
        obj.ID = 101;
        obj.CustomerName = "Ravi";
        //Console.WriteLine($"{obj.getID()}----{obj.getCustomerName()}");
        Console.WriteLine($"{obj.ID}---{obj.CustomerName}");
        Console.ReadLine();
    }
}
