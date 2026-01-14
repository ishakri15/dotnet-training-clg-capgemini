namespace WriteOnlysetMethodsDemo;

class Customer
    {
       // int kk; this is not a property
        private int _cid=-1;
       
        public int ID
        {
            set
            {
                _cid = value;
            }
           
        }
        private string _Cname=string.Empty;
        public string CustomerName
        {
            set
            {
                _Cname = value;
            }
            
        }
        public void displaycustomer()
        {
            Console.WriteLine($"{_cid}--{_Cname}");
        }

        //Auto implemented properties
        public int cid{get; set;}
        public string cname{get; set;}
       
    }
class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine($"{kk}");
        Customer obj = new Customer();
        obj.ID = 101;
        obj.CustomerName = "ravi";
        obj.displaycustomer();
        //
        obj.cid = 102;
        obj.cname = "riya";
        Console.WriteLine($"{obj.cid}---{obj.cname}");
        Console.ReadLine();
    }
}
