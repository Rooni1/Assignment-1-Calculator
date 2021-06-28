using System;
using System.IO;
using System.Linq;

namespace Calculator
{
   
    public class Program
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
                                  "4:  -Division"       + " \n" +
                                  "5:  -Square Root"    + " \n" +
                                  "0:  -To Close Program");
                userinput = GetUserInput();
                double x;
                double y;
                double Result;
                switch (userinput)
                {
                    case 1:
                       (x,y) = UserInput();
                       Result = Addition(x,y);
                       Console.WriteLine("The Answer is" + " "+ Result);
                        break;

                    case 2:
                       (x,y) = UserInput();
                       Result = Subtraction(x, y);
                       Console.WriteLine("The Answer is" + " " + Result);
                        break;

                    case 3:
                        (x,y) = UserInput();
                        Result = Multipicaton(x,y);
                        Console.WriteLine("The Answer is" + " " + Result);
                        break;

                    case 4:
                        (x,y) = UserInput();
                        Result = Division(x, y);
                        Console.WriteLine("The Answer is" + " " + Result);
                        break;

                    case 5:
                        Console.WriteLine("Enter a Number");
                        (x) = GetUserInput();
                        Result = GetSquareRoot(x);
                        Console.WriteLine("The Answer is" + " " + Result);
                        
                        break;

                    case 0:
                        
                        Console.WriteLine("Thankyou for using my Calculator");
                        Console.WriteLine("Press any key to exit Program");
                        Console.ReadKey();
                        break;

                }
                
                    
            } while(userinput != 0);


        }
        public static double Addition(double[] InputArray)
        {
            //Console.WriteLine("------You chosse to perform Addition------");
            //(x,y) = UserInput();
            //double z = x+y;
            //Console.WriteLine("The Answer is" + " " + z);
            //double SumOfInputArray = InputArray.Sum();
            double SumOfInputArray = 0;
            foreach(double values in InputArray)
            {
                SumOfInputArray += values;
            }

            return SumOfInputArray;
        }
        public static double Addition(double x, double y)
        {
            //Console.WriteLine("------You chosse to perform Addition------");
            //(x,y) = UserInput();
            //double z = x+y;
            //Console.WriteLine("The Answer is" + " " + z);
            //double SumOfInputArray = InputArray.Sum();
            double AddiotonOfInput = x + y;

            return AddiotonOfInput;
        }
        public static double Subtraction(double[] InputArray)
        {
            //Console.WriteLine("------You chosse to perform Subtraction------");
            //var (x, y) = UserInput();
            //double z = x - y;
            //Console.WriteLine("The Answer is" + " " + z);
            double SubtractionOfArray = InputArray.Aggregate((DifferenceOfFirstTwoIndex, next) => DifferenceOfFirstTwoIndex - next);
            
            return SubtractionOfArray;
                      
        }
        public static double Subtraction(double x , double y)
        {
            //Console.WriteLine("------You chosse to perform Subtraction------");
            //var (x, y) = UserInput();
            //double z = x - y;
            //Console.WriteLine("The Answer is" + " " + z);
            double DifferenceOfInput = x - y;
            return DifferenceOfInput;

        }
        public static double Multipicaton(double x, double y)
        {
            //Console.WriteLine("------You chosse to perform Multipication------");
            //var (x, y) = UserInput();
            //Console.WriteLine("The Answer is" + " " + z);
            //double MultiplyValuesOfArray = InputArray.Aggregate((total, next) => total * next);
            double MultiplicationOfInput = x * y;
            return MultiplicationOfInput;

        }
        public static double Division(double x, double y)
        {
            double DivisionOfInput = x / y;
            return DivisionOfInput;
        }
        public static double GetSquareRoot(double SquareRoot)
        {

            /*Console.WriteLine("------You chosse to get Squareroot------");
            try
            {
               
                Console.WriteLine("Enter Number");
                double InputNumber = Convert.ToDouble(Console.ReadLine());
               
                Console.WriteLine("The Square Root of Number you Entered is" + " " + SquareRoot);
            }
            catch(FormatException)
            {
                Console.WriteLine("Please Enter the correct format!");
                Console.WriteLine("Press Enter to restart");
                Console.ReadLine();
            }*/
            SquareRoot = Math.Sqrt(SquareRoot);

            return SquareRoot;

        }
        public static int GetUserInput()
        {
            int number = 0;
            try
            {
                string userInput = Console.ReadLine();
                int.TryParse(userInput, out number);
               
            }
            catch(FormatException)
            {
                Console.WriteLine("Please Enter the correct format!");
                Console.WriteLine("Press Enter to restart");
                Console.ReadLine();
            }

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
                secondnumber = Convert.ToDouble(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Please Enter the correct format!");
                Console.WriteLine("Press Enter to restart");
                Console.ReadLine();
            }

            if(firstnumber.Equals(null) || secondnumber.Equals(null))
            {
                    throw new ArgumentNullException("You Must give some value");
                   
            }
                                     
               
              

            
            return (firstnumber, secondnumber);
        }
    }
}
