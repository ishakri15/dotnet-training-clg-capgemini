using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionConsoledemo
{
    public class ICICIBankException : ApplicationException
    {
        public ICICIBankException (string message) : base(message)
        {
            
        }
    }
     class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter value in a ...");
            int a = Convert.ToInt32(Console.ReadLine());
            L1: Console.WriteLine("enter value in b..");
            try
            {
                
                int b = Convert.ToInt32(Console.ReadLine());
                int c = a / b;


                Console.WriteLine("the division result is {0}", c);


            }
            //comments can come nothing 
            catch (DivideByZeroException ee)
            {

                Console.WriteLine("don't enter denominator as zero : " + ee.Message);
                goto L1;

            }
            catch (FormatException ee)
            {

                Console.WriteLine("don't enter characters and special symbols: " + ee.Message);
                goto L1;
            }
            catch (Exception ee)
            {
                Console.WriteLine("some general error check it :" + ee.Message);
                goto L1;
            }

            finally
            {

                Console.WriteLine("I am still alive ...");
            }


            try
            {
                Console.WriteLine("Enter the age : ");
                int age = Convert.ToInt32(Console.ReadLine());
                if(age < 18)
                {
                    ICICIBankException ex = new ICICIBankException("Age is less than 18, so you are not eligible to apply");
                    throw ex;
                }
                else
                {
                    Console.WriteLine("Click this link to open an account : " + "https://www.icicibank.com/");
                }
            }
            catch(ICICIBankException ex)
            {
                Console.WriteLine("ICICI Bank Exception : " + ex.Message);
            }

            Console.ReadLine();

        }
    }
}
