namespace varAndDynamicDemo;

public class duck{
    public void quack(){
        Console.WriteLine("quack quack");
    }
}
public class Person
    {
        public void quack()
        {
            Console.WriteLine("person imitating as quack");
        }
    }
class Program
{
    public void inTheForest(dynamic d){
        d.quack();
    }
    // public void inTheForest(Person p){
    //     p.quack();
    // }
    static void Main(string[] args)
    {
        int x = 23;
        // x = "hello";
        var kk = 45;
        var name = "sachin";
        var emps = new List<string>{"ravi","kiran","sita"};

        //here based on what value I pass into the variable var
        //it becomes that data type it is in compile time
        //but still some drawback is there in var

        var ss = 120;
        // ss = "helloeveryone"; //it is giving error

        //so what to do, use dynamic keyword in runtime
        dynamic ss1 = 34;
        ss1 = "helloeveryone"; //no error

        Program p = new Program();
        duck d = new duck();
        Person per = new Person();
        p.inTheForest(d);
        p.inTheForest(per);
        Console.ReadLine();
    }
}
