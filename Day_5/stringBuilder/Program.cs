using System.Text;
namespace stringBuilder;

class Program
{
    public static void concat1(string s1)
    {
        string st = "world";
        s1 = s1 + st;
    }

    public static void concat2(StringBuilder sb2)
    {
        sb2.Append("everyone");
    }
    static void Main(string[] args)
    {
        //as string is immutable , I will use stringbuilder in strings
        //whenever I create a string literal or concat I am creating a new obj
        //not good practice, declare once and append in that object which is 
        //possible in stringbuilder and it is mutable also can be changed

        string s1 = "hello";
        StringBuilder sb1 = new StringBuilder("hai");
        concat1(s1);
        concat2(sb1);
        Console.WriteLine($"{s1}---{sb1}");

        string[] weekDays = new string[]
        {
            "Monday","Tuesday","Wednesday","Thursday","Friday","Saturday","Sunday"
        };
        // i want the output like this 
        // Monday ,Tuesday ,Wednesday ,Thursday,Friday ,Saturday and Sunday
        //  but it will not happen as it is immutable 
        StringBuilder sb = new StringBuilder();
        for(int i=0; i<weekDays.Length; i++)
        {
            sb.Append(weekDays[i]);
            if (i < weekDays.Length - 2)
            {
                sb.Append(" , ");
            }else if(i == weekDays.Length - 2)
            {
                sb.Append(" and ");
            }
        }
        Console.WriteLine(sb.ToString());
        Console.ReadLine();
    }
}
