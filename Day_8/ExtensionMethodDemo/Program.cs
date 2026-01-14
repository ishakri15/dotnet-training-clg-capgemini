namespace ExtensionMethodDemo;

public static class IntExtensions
{
    public static bool IsEven(this int number)
    {
        return number % 2 == 0;
    }
}
public static class StringExtensions
{
    public static bool IsPalindrome(this string str)
    {
        int i = 0; 
        int j = str.Length - 1;
        while (i < j)
        {
            if(str[i] != str[j])
            {
                return false;
            }
            i++;
            j--;
        }
        return true;
    }
}
class Program
{
    static void Main(string[] args)
    {
        int num;
        num = 56;
        bool res = num.IsEven();
        Console.WriteLine($"Is {num} even ? : {res}");
        string strr = "madam";
        //Console.WriteLine(strr);
        Console.WriteLine($"Is {strr} palindrome? : {strr.IsPalindrome()}");
    }
}
