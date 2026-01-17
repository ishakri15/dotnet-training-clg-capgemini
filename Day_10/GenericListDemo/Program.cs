namespace GenericListDemo;

class Customer
{
    public int CustomerID{get; set;}
    public string CustomerName{get; set;}
    public static List<Customer> Retrive()
    {
        List<Customer> clist = new List<Customer>()
        {
            new Customer {CustomerID=101,CustomerName="ravi"},
            new Customer {CustomerID=102,CustomerName="Sita"},
            new Customer {CustomerID=103,CustomerName="sohan"},
        };
        return clist; 
    }
    public static void PrintCustomer(List<Customer> clist)
    {
        Console.WriteLine("Displaying customer");
        foreach(Customer c in clist)
        {
            Console.WriteLine($"Customer : {c.CustomerID}-----{c.CustomerName}");
        }
    }
    public static void InsertCustomer(Customer c,List<Customer> clist)
    {
        clist.Add(c);
    }
    public static Customer FindCustomer(int custid, List<Customer> clist)
    {
        Customer custfound = null;
        foreach(Customer c in clist)
        {
            if(c.CustomerID == custid)
            {
                custfound = c;
            }
        }
        return custfound;
    }
    public static void UpdateCustomer(int custId, List<Customer> clist)
    {
        for(int i=0; i<clist.Count; i++)
        {
            if(clist[i].CustomerID == custId)
            {
                Console.WriteLine("Enter new name");
                string newname = Console.ReadLine();
                clist[i].CustomerName = newname;
            }
        }
    }
    public static void DeleteCustomer(int custId, List<Customer> clist)
    {
        for(int i=0; i<clist.Count; i++)
        {
            if(clist[i].CustomerID == custId)
            {
                clist.RemoveAt(i);
            }
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        numbers.Add(1);
        numbers.Add(2);
        numbers.Add(3);
        numbers.Add(4);
        numbers.Add(5);

        List<string> names = new List<string>()
        {
            "ravi","sudha","mohan","madhu"
        };

        foreach(int num in numbers)
        {
            Console.WriteLine($"{num}");
        }
        Console.WriteLine();
        foreach(string str in names)
        {
            Console.WriteLine($"{str}");
        }
        var array = new int[]{1,2,3,4,5,6,7,8,9,10,5}; //static array
        var result = new List<int>();
        foreach(int num in array)
        {
            bool found = false;
            foreach(int ele in result)
            {
                if(ele == num)
                {
                    found = true;
                }
            }
            if (!found)
            {
                result.Add(num);
            }
        }
        foreach(int ele in result)
        {
            Console.WriteLine($"{ele}");
        }


        List<Customer> custlist = Customer.Retrive();
        Customer.PrintCustomer(custlist);
        Customer newcustomer = new Customer()
        {
            CustomerID = 104, CustomerName = "Mahesh"
        };
        Customer.InsertCustomer(newcustomer, custlist);
        Customer.PrintCustomer(custlist);

        Console.WriteLine("Enter id to find customer name : ");
        int custId = Convert.ToInt16(Console.ReadLine());
        Customer custfound = Customer.FindCustomer(custId , custlist);
        if(custfound != null)
        {
            Console.WriteLine($"The customer with {custfound.CustomerID} is having name {custfound.CustomerName}");
        }
        else
        {
            Console.WriteLine("The customer is not there in list ");
        }

        Console.WriteLine("Enter id to update customer name : ");
        int custId2 = Convert.ToInt16(Console.ReadLine());
        Customer.UpdateCustomer(custId2, custlist);
        Customer.PrintCustomer(custlist);

        Console.WriteLine("Enter the customer id whom you want to delete : ");
        int custId3 = Convert.ToInt32(Console.ReadLine());
        Customer.DeleteCustomer(custId3, custlist);
        Customer.PrintCustomer(custlist);
        Console.ReadLine();
    }
}
