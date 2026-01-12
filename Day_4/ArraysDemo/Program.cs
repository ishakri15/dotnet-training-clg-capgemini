namespace ArraysDemo;

class Customer{
    public int custId;
    public string custName;
}
class Program
{
    public void PrintArray(int[] arr){
        for(int i=0; i<arr.Length; i++){
            Console.Write($"\t{arr[i]}");
        }
    }
    static void Main(string[] args)
    {
        int[] aa1 = new int[]{23,45,67,78,89};
        //above is infinite array, I can keep as many
        //elements I want so above , I had done declaration also
        // and initialization also

        int[] aa2 = new int[3]{12,23,34};
        //above is fixed array so declaration and initialization 
        string[] names = new string[]{"sachin","ravi","kiran","sita"};
        char[] chars = new char[4]{'a','b','c','d'};

        int[] a = new int[5]; //this is only declaration that is fixed
        int i,j,sum=0;
        for(i=0; i<a.Length; i++){
            Console.Write($"Enter element {i+1} : ");
            a[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("Elements in the array are: ");
        Program p = new Program();
        p.PrintArray(a);

        Console.WriteLine("\nFinding sum of array elements : ");
        for(i=0; i<a.Length; i++){
            sum += a[i];
        }
        Console.WriteLine($"{sum}");


        //for each loop
        Console.WriteLine("\nprinting array using foreach loop : ");
        foreach(int el in a){  //only for reading purpose , you cannot modify it
            Console.Write($"\t{el}");
        }
        // differne between for loop and for each is that 
        // for each loop is read only loop u cannot the array 
        // now i will modify array using for loop

        Console.WriteLine("\nModifying array using for loop");
        for(i=0; i<a.Length; i++){
            a[i] = a[i]*3;
        }
        p.PrintArray(a);

        //searching element in array
        Console.WriteLine("\nEnter an element to search in the array : ");
        int key = Convert.ToInt32(Console.ReadLine());
        int flag = 0;
        for(i=0; i<a.Length; i++){
            if(a[i] == key){
                Console.WriteLine($"The element {key} is found at position {i+1} ");
                flag = 1;
                break;
            }
        }
        if(flag == 0){
            Console.WriteLine("Element not found");
        }

        //sorting an array
        Console.WriteLine("\nSorting the array");
        for(i=0; i<a.Length-1; i++){
            for(j=i+1; j<a.Length; j++){
                if(a[i]>a[j]){
                    int temp = a[i];
                    a[i] = a[j];
                    a[j] = temp;
                }
            }
        }
        Console.WriteLine("After sorting the array : ");
        p.PrintArray(a);

        //array of objects
        Customer[] cList = new Customer[3];
        Console.WriteLine("\nEnter customer details : ");
        for(i=0; i<cList.Length; i++){
            Customer c = new Customer();
            Console.WriteLine($"Enter customer {i+1} details : ");
            Console.WriteLine("Enter customer id : ");
            c.custId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter customer name : ");
            c.custName = Console.ReadLine();
            cList[i] = c;
        }
        Console.WriteLine("Customer details are : ");
        foreach(Customer cust in cList){
            Console.WriteLine($"{cust.custId}---{cust.custName}");
        }

        //updating customer details
        Console.WriteLine("\nEnter customer id to update : ");
        int cid = Convert.ToInt32(Console.ReadLine());
        flag = 0;
        for(i=0; i<cList.Length; i++){
            if(cList[i].custId == cid){
                Console.WriteLine("Enter new customer name : ");
                cList[i].custName = Console.ReadLine();
                flag = 1;
                break;
            }
        }
        if(flag == 0){
            Console.WriteLine("Customer id not found");
        }
        Console.WriteLine("Updated Customer details are : ");
        foreach(Customer cust in cList){
            Console.WriteLine($"{cust.custId}---{cust.custName}");
        }
        Console.ReadLine();
    }
}
