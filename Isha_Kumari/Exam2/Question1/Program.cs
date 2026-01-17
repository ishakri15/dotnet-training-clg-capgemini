using System.Security.Cryptography.X509Certificates;

namespace Question1;

abstract class Customer
{
    public abstract double CalculateDiscount(double amount);
    public virtual void DisplayCustomerDetails(string CustomerId, string CustomerName)
    {
        Console.WriteLine($"Customer ID : {CustomerId}, Customer Name : {CustomerName}");
    }
}
class RegularCustomer : Customer, IServiceEligible
{
    public int LoyaltyPoints;
    public RegularCustomer(int Points)
    {
        LoyaltyPoints = Points;
    }
    public override double CalculateDiscount(double amount)
    {
        double discount;
        if(LoyaltyPoints > 100)
        {
            discount = amount * 0.05;
        }
        else
        {
            discount = amount * 0.02;
        }
        return discount;
    }
    public void RequestService()
    {
        Console.WriteLine("Normal service provided");
    }
    public bool IsEligibleForFreeDelivery(double orderValue)
    {
        if(orderValue > 500)
        {
            Console.WriteLine("Standard Delivery");
            return true;
        }
        return false;
    }
}
class VIPCustomer : Customer, IServiceEligible
{
    public string MembershipTier;
    public double AnnualSpend;
    public VIPCustomer(string membershipTier, double annualSpend)
    {
        MembershipTier = membershipTier;
        AnnualSpend = annualSpend;
    }
    public override double CalculateDiscount(double amount)
    {
        double discount = 0;
        if(MembershipTier == "Gold")
        {
            discount = amount * 0.15;
        }
        else if(MembershipTier == "Platinum")
        {
            discount = amount * 0.20;
        }
        return discount;
    }
    public void RequestService()
    {
        Console.WriteLine("VIP service provided");
    }
    public bool IsEligibleForFreeDelivery(double orderValue)
    {
        Console.WriteLine($"You are {MembershipTier} member so you will get free delivery");
        return true;
    }
}
interface IServiceEligible
{
    void RequestService();
    bool IsEligibleForFreeDelivery(double orderValue);
}
class Program
{
    public static void PrintDetails(RegularCustomer r)
    {
        Console.WriteLine("Enter amount : ");
        double amt = Convert.ToDouble(Console.ReadLine());
        r.RequestService();
        Console.WriteLine($"Discount granted : {r.CalculateDiscount(amt)}");
        Console.WriteLine($"Free Delivery provided ? : {r.IsEligibleForFreeDelivery(amt)}");
    }
    public static void PrintDetailsVIP(VIPCustomer v)
    {
        Console.WriteLine("Enter amount : ");
        double amt = Convert.ToDouble(Console.ReadLine());
        v.RequestService();
        Console.WriteLine($"Discount granted : {v.CalculateDiscount(amt)}");
        Console.WriteLine($"Free Delivery provided ? : {v.IsEligibleForFreeDelivery(amt)}");
    }
    static void Main(string[] args)
    {
        RegularCustomer r1 = new RegularCustomer(120);
        RegularCustomer r2 = new RegularCustomer(50);
        RegularCustomer r3 = new RegularCustomer(220);
        r1.DisplayCustomerDetails("101","Riya");
        PrintDetails(r1);
        Console.WriteLine();
        r2.DisplayCustomerDetails("102","Siya");
        PrintDetails(r2);
        Console.WriteLine();
        r3.DisplayCustomerDetails("103","Diya");
        PrintDetails(r3);
        Console.WriteLine();
        VIPCustomer v1 = new VIPCustomer("Gold",50000);
        VIPCustomer v2 = new VIPCustomer("Platinum",80000);
        v1.DisplayCustomerDetails("104","Ram");
        PrintDetailsVIP(v1);
        Console.WriteLine();
        v2.DisplayCustomerDetails("105","Shyam");
        PrintDetailsVIP(v2);
        Console.WriteLine();
    }
}
