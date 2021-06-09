using System;
using System.IO;

namespace Calculator
{
   
    class Program
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine("------- Calculator -------");
            int userinput;
            do
            {
                Console.WriteLine("Select a number to perform respective operation");
                Console.WriteLine("1:  -Addition"       + " \n" + 
                                  "2:  -Subtraction"    + " \n" +
                                  "3:  -Multiplication" + " \n" +
                                  "4:  -Dicision"       + " \n" +
                                  "5:  -Square Root"    + " \n" +
                                  "0:  -To Close Program");
                userinput = GetUserinput();
                switch(userinput)
                {
                    case 1:
                        addition();
                        break;

                    case 2:
                        subtraction();
                        break;

                    case 3:
                        multipicaton();
                        break;

                    case 4:
                        division();
                        break;

                    case 5:
                        squareroot();
                        break;

                    case 0:
                        Console.WriteLine("Thankyou for using my Calculator");
                        Console.WriteLine("Press any key to exit Program");
                        Console.ReadKey();
                        break;

                }
                
                    
            } while(userinput != 0);


        }
        static void addition()
        {
               
            var (x,y) =  UserInput();
            double z = x+y;
            Console.WriteLine("The Answer is" + " " + z);
        }
        static void subtraction()
        {
           
                var (x, y) = UserInput();
                double z = x - y;
                Console.WriteLine("The Answer is" + " " + z);
                      
        }
        static void multipicaton()
        {
            try
            {

                Console.WriteLine("Enter the first Number");
                double x = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter the second Number");
                double y = Convert.ToDouble(Console.ReadLine());
                double z = x * y;
                Console.WriteLine("The Answer is" + " " + z);
            }
            catch(FormatException)
            {
                Console.WriteLine("Please Enter the correct format!");
                Console.WriteLine("Press Enter to restart");
                Console.ReadLine();
            }
   
        
        }
        static void division()
        {
           
                try
                {
                    var (x, y) = UserInput();
                    double z = x / y;
                    Console.WriteLine("The Answer is" + " " + z);
                }
                catch(DivideByZeroException)
                {
                    Console.WriteLine("You are trying to divide with Zero");
                    Console.WriteLine("Press Enter to restart");
                    Console.ReadLine();

                }
            
           
        }
        static void squareroot()
        {
            try
            {
                Console.WriteLine("Enter Number");
                double x = Convert.ToDouble(Console.ReadLine());
                double y = Math.Sqrt(x);
                Console.WriteLine("The Square Root of Number you Entered is" + " " + y);
            }
            catch(FormatException)
            {
                Console.WriteLine("Please Enter the correct format!");
                Console.WriteLine("Press Enter to restart");
                Console.ReadLine();
            }

        }
        static int GetUserinput()
        {
            string userInput = Console.ReadLine();

            int number = 0;
            int.TryParse(userInput, out number);

            return number;
        }
        
        private static (double,double) UserInput()
        {
            double firstnumber = 0;
            double secondnumber = 0;
            try
            {
                
                Console.WriteLine("Enter the first Number");
                firstnumber = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter the second Number");
                secondnumber =  Convert.ToDouble(Console.ReadLine());
                                     

            }
            catch (FormatException)
            {
                Console.WriteLine("Please Enter the correct format!");
                Console.WriteLine("Press Enter to restart");
                Console.ReadLine();

            }
            return (firstnumber, secondnumber);
        }
    }
}
