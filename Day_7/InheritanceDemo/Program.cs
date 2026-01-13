using System.Reflection.PortableExecutable;

namespace InheritanceDemo;
class Father
{
    public void marutiCar()
    {
        Console.WriteLine("Maruti Car");
    }
}
class Son : Father
{
    public void BMWCar()
    {
        Console.WriteLine("BMW Car");
    }
}
//sealed classes cannot be overridden
sealed class GrandSon : Son //Father //multiple inheritance is not allowed in C# 
{
    public void AudiCar()
    {
        Console.WriteLine("Audi Car");
    }
}
class Program
{
    static void Main(string[] args)
    {
        GrandSon grandSon = new GrandSon();
        grandSon.marutiCar();
        grandSon.BMWCar();
        grandSon.AudiCar();
        Father father = new Father();
        father.marutiCar();
        //father.AudiCar();//using base class object, we cannot access subclass functions
        //father.BMWCar();
    }
}
