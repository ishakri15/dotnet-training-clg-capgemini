namespace Question2;

abstract class Product
{
    public abstract double CalculateDiscountedPrice(double Price);
    public virtual void DisplayProductInfo(string ProductID, string ProductName)
    {
        Console.WriteLine($"Product Id : {ProductID}");
        Console.WriteLine($"Product name : {ProductName}");
    }
}
interface IDeliverable
{
    void Deliver();
    int GetDeliveryTime();
}
class PhysicalProduct : Product, IDeliverable
{
    public override double CalculateDiscountedPrice(double Price)
    {
        if(Price > 1000)
        {
            return Price - Price * 0.1;
        }
        return Price;
    }
    public double CalculateShippingCost(double weight)
    {
        return weight * 5;
    }
    public void Deliver()
    {
        Console.WriteLine("Your product is shipped");
    }
    public int GetDeliveryTime()
    {
        int time = 7 ;
        return time;
    }
}
class DigitalProduct : Product, IDeliverable
{
    //public double fileSizeinMb;
    public override double CalculateDiscountedPrice(double Price)
    {
        return Price - Price * 0.05;
    }
    public void Deliver()
    {
        Console.WriteLine("You can download your product from this link : www.product.com");
    }
    public int GetDeliveryTime()
    {
        int time = 0 ;
        return time;
    }
}
class Program
{
    static void Main(string[] args)
    {
        L1 : Console.WriteLine("Enter your choice : pp for Physical Product and dp for Digital Product : ");
        string choice = Console.ReadLine();
        if(choice == "pp")
        {
            PhysicalProduct pp = new PhysicalProduct();
            Console.WriteLine("for Physical Product : ");
            pp.DisplayProductInfo("101","Notebook");
            Console.WriteLine($"Discounted price : {pp.CalculateDiscountedPrice(1200)}");
            Console.WriteLine($"Shipping cost : {pp.CalculateShippingCost(2)}");
            pp.Deliver();
            Console.WriteLine($"Your product will be delivered in {pp.GetDeliveryTime()} days");
        }
        else if(choice == "dp")
        {
            DigitalProduct dp = new DigitalProduct();
            Console.WriteLine("for Digital Product : ");
            dp.DisplayProductInfo("C245","Digital poem book");
            Console.WriteLine($"Discounted price : {dp.CalculateDiscountedPrice(500)}");
            Console.WriteLine($"There is no shipping cost !!");
            dp.Deliver();
            Console.WriteLine($"Product delivered !!");
        }
        else
        {
            Console.WriteLine("Invalid choice");
            goto L1;
        }        
    }
}
