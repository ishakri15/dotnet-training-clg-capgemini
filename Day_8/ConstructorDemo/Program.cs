namespace ConstructorDemo;

class Vehicle
{
    public string Make { set; get; }
        public string Model { set; get; }

        public Vehicle()
        {
            Console.WriteLine("Default Constructor called");
        }
        public Vehicle(string make1,string model1)
        {
            this.Make = make1;
            this.Model = model1;
            Console.WriteLine($"Parameterized " +
                $"Constructor called: Make={Make}, Model={Model}");
        }
        public Vehicle(Vehicle v)
        {
                this.Model=v.Model;
            this.Make=v.Make;
            Console.WriteLine($"copy constructor called:{this.Make}--{this.Model}");
        }
}
class Car : Vehicle
{
    public int noofdoors { set; get; }
        public Car(string make1,string moldel1,int noofdoors1):base(make1 ,moldel1)
        {
            noofdoors = noofdoors1;
            Console.WriteLine($"car constructor:{Make}--{Model}--{noofdoors}");
        }
}
class Program
{
    static void Main(string[] args)
    {
        Vehicle cc1 = new Vehicle();//for default constructor
        Vehicle cc2 = new Vehicle("suziki", "waganor");//parametized
        Vehicle cc3= new Vehicle("renault", "duster");//parametized
        Vehicle cc4 = new Vehicle(cc3);//copy constructor
        Car cc = new Car("Toyato", "canry", 4);
        Console.ReadLine();
    }
}
