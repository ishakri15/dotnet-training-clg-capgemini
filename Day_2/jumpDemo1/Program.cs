namespace jumpDemo1;

class Program
{
    static void Main(string[] args)
    {
        jumpDemos();
        //continueDemo();
        //gotoDemo();
        Console.ReadLine();
    }
    private static void jumpDemos(){
        int sum = 0;
        int num;
        do{
            Console.WriteLine("Enter a number");
            num = Convert.ToInt32(Console.ReadLine());
            if(num < 0){
                Console.WriteLine("Enter positive number only");
                continue;
            }else{
                sum = sum + num;
            }
            if(num == 0){
                break;
            }
        }while(true);
        Console.WriteLine($"Sum of the numbers is {sum}");

    }

    private static void continueDemo(){
        int counter = 0;
        while(counter < 10){
            counter++;
            if(counter == 5){
                continue;
            }
            Console.WriteLine($"{counter}");
        }
    }

    private static void gotoDemo(){
        int num;
        L1 : Console.WriteLine("Enter a value for num : ");
        num = Convert.ToInt32(Console.ReadLine());
        if(num == 1){
            goto test;
        }else{
            goto L1;
        }
        test : Console.WriteLine("Its all done");
    }
}
