namespace loopsDemo;

class Program
{
    static void Main(string[] args)
    {
        //whileLoop();
        //doWhileLoop();
        //doWhileLoop2();
        //noOfNotesQues();
        forLoop();
        Console.ReadLine();
    }
    private static void whileLoop(){
        int counter;
            counter = 1;
            while (counter <= 100)
            {
                Console.Write($"\t{counter}");
                counter++;
            }
    }

    private static void doWhileLoop(){
        int counter;
            counter = 200;
            do
            {
                Console.Write($"\t{counter}");
                counter++;// commenting this will make infnite loop 
                // which means it is always true 
            } while (counter <= 100);//for one time execution 
            //even if condition is wrong i will use do while loop
    }

    private static void doWhileLoop2(){
        int counter;
            counter =1;
            bool keepgoing = true;
            do
            {
                Console.Write($"\t{counter}");
                if ((counter%100==0) && (counter!=0))
                {
                    Console.WriteLine("\n do you want to continue <y/n>?");
                    if(Console.ReadLine()!="y")
                    {
                        keepgoing = false;
                    }
                }
                counter = counter + 1;
            } while (keepgoing);
    }

    private static void noOfNotesQues(){
        //Divide 480rs into 1rs, 5rs and 10rs notes of equal number
        int total = 480;
        int numOfNotes = 0;
        int sum = 0;
        int x = 1, y = 5, z = 10;
        while(sum < total){
            sum = x + y + z;
            x = x + 1;
            y = y + 5;
            z = z + 10;
            numOfNotes++;
        }
        Console.WriteLine($"Number of notes of each : {numOfNotes} and total no. of notes : {numOfNotes*3}");
    
    }

    private static void forLoop(){
         Console.WriteLine("Enter number to find factorial : ");
         int num = Convert.ToInt32(Console.ReadLine());
         float f = 1.0F;
         int i;
         for(i=1; i<=num; i++){
            f = f * i;
         }
        Console.WriteLine($"Factorial of {num} is {f}");
    }
}
