namespace TwoDArraysDemo;

class Program
{
    static void Main(string[] args)
    {
        int i,j, sum = 0;
        //using nested for loops to print right angled triangle
        for(i=1; i<=5; i++){
            for(j=1; j<=i; j++){
                Console.Write($"\t{i}");
            }
            Console.WriteLine();
        }

        //declaring 2D array
        int[,] a = new int[3,3];
        //declaring 3D array
        int[,,] aa = new int[3,3,3];

        Console.WriteLine("Enter elements for 2D array : ");
        for(i=0; i<a.GetLength(0); i++){
            for(j=0; j<a.GetLength(1); j++){
                Console.Write($"Enter [{i+1},{j+1}] element : ");
                a[i,j] = Convert.ToInt16(Console.ReadLine());
            }
        }
        Console.WriteLine("\n Printing 2D array");
        for(i=0; i<a.GetLength(0); i++){
            for(j=0; j<a.GetLength(1); j++){
                Console.Write($"\t{a[i,j]}");
            }
            Console.WriteLine();
        }

        Console.WriteLine("\nThe sum of matrix : ");
        for(i=0; i<a.GetLength(0); i++){
            for(j=0; j<a.GetLength(1); j++){
                sum += a[i,j];
            }
        }
        Console.WriteLine($"The sum is {sum}");
        Console.ReadLine();
    }
}
