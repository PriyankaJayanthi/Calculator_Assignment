using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Caluclator program to perform basic operations like addition,substaction,multplication and divison.
// 2022-03-25 Priyanka J - First Version

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isAlive = true;
            while (isAlive)
            {
                // Menu Creation
                Console.WriteLine("Welcom to Caluclator program:\n Please select the one of the folling option:");
                Console.WriteLine(" 1:Addition" + "\n 2:Subration" + "\n 3:Multiplication" + "\n 4:Divison");
                // User to entere first input
                int.TryParse(Console.ReadLine(), out int selection);
                Console.WriteLine("Enter the First number: ");
                var first_input = Console.ReadLine();
                double num1;
                while (!double.TryParse(first_input, out num1))
                {
                    Console.WriteLine("Input entered is not numeric. Can you please enter numeric value");
                    first_input = Console.ReadLine();
                }

                //User to enter the secound input
                Console.WriteLine("Enter the Secound number: ");
                var secound_input = Console.ReadLine();
                double num2;
                while (!double.TryParse(secound_input,out num2))
                {
                    Console.WriteLine("Input entered is not numeric. Can you please enter numeric value");
                    secound_input = Console.ReadLine();
                }
                double result = 0;
                var output = "";

                //-selection

                switch (selection)
                {
                    case 1:
                        Console.Clear();
                        result = Addition(num1, num2);
                        output = "Addition result is: " + result;
                        break;
                    case 2:
                        Console.Clear();
                        result = Subtraction(num1, num2);
                        output = "Subtraction result is:"+ result;
                        break;
                    case 3:
                        Console.Clear();
                        result = Multiplication(num1, num2);
                        output = "Multiplication result is:"+ result;
                        break;
                    case 4:
                        Console.Clear();
                        if (num2 == 0)
                        {
                            Console.WriteLine("If num2 is 0 is said to be undefine");
                            output = "Division result is NA";
                        }
                        else
                        {
                            result = Division(num1, num2);
                            output = "Division result is: " + result;
                        }
                        

                        break;
                    default:
                        Console.WriteLine("Not a valld selection,try again");
                        break;
                }
                // display result

                Console.WriteLine(output);
                Console.WriteLine("would you like to continue or exit. Enter Any Key - Continue or N - Exit");
                var key = Console.ReadLine().ToUpper();
                if (key == "N")
                {
                    isAlive = false;
                    Console.WriteLine("Thanks for using Caluclator");
                    Console.ReadKey();
                }

            }
        }
        //To perform Addition
        private static double Addition(double num1, double num2)
        {
            double result = num1 + num2;
            return result;
        }
        // To perform subration
        private static double Subtraction(double num1, double num2)
        {
            double result = num1 - num2;
            return result;
        }
        // To perform multplication
        private static double Multiplication(double num1, double num2)
        {
            double result = num1 * num2;
            return result;
        }
        // To perform Divison
        private static double Division(double num1, double num2)
        {
            double result = num1 / num2;
            return result;
        }

    }
}