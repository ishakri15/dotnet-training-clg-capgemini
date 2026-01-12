namespace JaggedArrayDemo;
 class Program
    {
        static void Main(string[] args)
        {
            int[][] jaggedArray = new int[3][];//already row is defind
            int i, j;
            // jaggedArray[0] = new int[2] { 12, 45 };
            // jaggedArray[1] = new int[3] { 23, 56, 78 };
            // jaggedArray[2] = new int[1] { 1000 };

            Console.WriteLine("\n Read from user");
            for(i=0; i<jaggedArray.Length; i++){
                Console.WriteLine($"\n I am in row {i+1} asking you to enter ");
                Console.WriteLine("\n Enter number of columns");
                int colSize = Convert.ToInt32(Console.ReadLine());
                jaggedArray[i] = new int[colSize];
                for(j=0; j<jaggedArray[i].Length; j++){
                    Console.WriteLine($"\n Enter element at [{i+1},{j+1}]");
                    jaggedArray[i][j] = Convert.ToInt32(Console.ReadLine());
                }

            }

            Console.WriteLine("\n Printing jagged array elements");
            for (i = 0; i < jaggedArray.Length; i++)
            {
              Console.WriteLine($" \n I am in {i+1} row having {jaggedArray[i].Length} elements :");
                for (j = 0; j < jaggedArray[i].Length;j++)
                {
                    Console.WriteLine($"{jaggedArray[i][j]}");
                }
            }
        }
    }