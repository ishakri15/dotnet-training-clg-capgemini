namespace Assignment2;

//Read a string it can be of one word or many words for every word starting character of word should be upper case ?
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a string : ");
        string input = Console.ReadLine();
        char[] arr = input.ToCharArray();
        if(arr.Length > 0)
        {
            arr[0] = (char)(arr[0]-32);
        }
        for(int i=0; i<arr.Length-1; i++)
        {
            if(arr[i] == ' ' && arr[i+1] != ' ')
            {
                arr[i+1] = (char)(arr[i+1]-32);
            }
        }
        string str = new string(arr);
        Console.WriteLine($"{str}");

        //another method
        // string result = "";
        // result = result + char.ToUpperInvariant(input[0]);
        // for(int i=1; i<input.Length; i++)
        // {
        //     if(input[i]==' ' && input[i+1]!=' ')
        //     {
        //         result = result + ' ' + char.ToUpperInvariant(input[i+1]);
        //         i++;
        //     }
        //     else
        //     {
        //         result = result + input[i];
        //     }
        // }
        // Console.WriteLine($"{result}");
    }
}
