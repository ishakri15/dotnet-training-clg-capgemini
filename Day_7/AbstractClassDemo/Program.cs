namespace AbstractClassDemo;
public abstract class Polygon
{
    public void testFunction()
    {
        Console.WriteLine("***************************************");
    }
    public abstract void area(int x, int y);
}
public abstract class Polygon2
{
    public abstract void area(int side);
}
class Triangle : Polygon
{
    public override void area(int x, int y)
    {
        Console.WriteLine($"Area of triangle is : {0.5 * x * y}");
    }
}
class Rectangle : Polygon
{
    public override void area(int x, int y)
    {
        Console.WriteLine($"Area of rectangle is : {x * y}");
    }
}
class Square : Polygon2
{
    public override void area(int side)
    {
        Console.WriteLine($"Area of square is : {side * side}");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Polygon polygon; // = new Polygon() not possible because partial methods are there
        //so I am taking only reference, It is a car without petrol
        polygon = new Triangle();
        polygon.area(12,4);
        polygon = new Rectangle();
        polygon.area(12,5);
        Polygon2 polygon2;
        polygon2 = new Square();
        polygon2.area(4);
    }
}
