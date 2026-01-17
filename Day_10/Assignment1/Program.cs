using System.Text.RegularExpressions;
namespace Assignment1;
//I am giving you a string and from that string u need to find out no of vowels counts in the string ?
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a string : ");
        string input = Console.ReadLine();
        int prevLength = input.Length;
        string afterremoving = Regex.Replace(input, "[aeiouAEIOU]", "");
        int newLength = afterremoving.Length;
        int result = prevLength - newLength;
        Console.WriteLine($"No. of vowels in this string are : {result}");

        //another method
        int count = 0;
        foreach(char c in input)
        {
            if(c=='a' || c=='e'||c=='i'||c=='o'||c=='u'||c=='A' || c == 'E' || c == 'I' || c == 'O' || c == 'U')
            {
                count++;
            }
        }
        Console.WriteLine($"No. of vowels in this string are : {count}");
    }
}
