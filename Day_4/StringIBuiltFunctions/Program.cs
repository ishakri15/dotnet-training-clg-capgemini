namespace StringIBuiltFunctions;

class Program
{
    static void Main(string[] args)
    {
        string str = "Hello World!";
        string str2 = "Hello";
        string str3 = "world";
        string sample = "";
        string sample2 = string.Empty;
        Console.WriteLine($"{sample}---{sample2}");

        //properties of string
        //here chars denote index
        Console.WriteLine($"chars means index value : {str[1]}");
        Console.WriteLine($"Length : {str.Length}");

        //methods of string
        //modfiying
        Console.WriteLine($"Insert : {str.Insert(7,"Beautiful ")}");
        Console.WriteLine($"Remove : {str.Remove(7,5)}");
        Console.WriteLine($"Replace : {str.Replace("World", "Universe")}");
        Console.WriteLine($"Trim : {str.Trim()}");
        Console.WriteLine($"Trimstart : {str.TrimStart()}");
        Console.WriteLine($"Trimend : {str.TrimEnd()}");
        Console.WriteLine($"PadLeft: '{str2.PadLeft(10, '*')}'");
        Console.WriteLine($"PadRight: '{str2.PadRight(10, '-')}'");
        Console.WriteLine($"ToUpper: {str3.ToUpper()}");
        Console.WriteLine($"ToLower: {str2.ToLower()}");

        // Extracting
        Console.WriteLine($"Substring: {str.Substring(7, 5)}");
        Console.WriteLine($"Split: {string.Join(" , ", str.Split(' '))}");

        // Formatting
        double number = 12345.6789;
        Console.WriteLine($"Currency: {number.ToString("C")}");          
        Console.WriteLine($"Exponential: {number.ToString("E")}");
        Console.WriteLine($"General: {number.ToString("G")}");
        Console.WriteLine($"Percentage: {number.ToString("P")}");
        DateTime date = DateTime.Now;
        Console.WriteLine($"Short Date: {date.ToString("d")}");
        Console.WriteLine($"Long Date: {date.ToString("D")}");
        Console.WriteLine($"Short Time: {date.ToString("t")}");
        Console.WriteLine($"Long Time: {date.ToString("T")}");

        // Searching
        Console.WriteLine($"StartsWith 'Hello': {str.StartsWith("Hello")}");
        Console.WriteLine($"EndsWith '!': {str.EndsWith("!")}");
        Console.WriteLine($"IndexOf 'World': {str.IndexOf("World")}");
        Console.WriteLine($"Contains 'World': {str.Contains("World")}");

        //comparing
        string ss1 = "isha";
        string ss2 = "esha";
        //<0 means ss1 is smaller than ss2
        Console.WriteLine($"Compare : {string.Compare(ss1, ss2)}");
        Console.WriteLine($"Compare to : {ss1.CompareTo(ss2)}");
        Console.WriteLine($"Equals : {ss1.Equals(ss2)}");
        Console.ReadLine();
    }
}
