using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Caluclator program to perform basic operations like addition,substaction,multplication and divison.
// 2022-03-25 PJ - First Version

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
                // User inputs
                int.TryParse(Console.ReadLine(), out int selection);
                Console.WriteLine("Enter the First number: ");

                double num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter the Secound number: ");
                double num2 = Convert.ToDouble(Console.ReadLine());
                double result = 0;

                //-selection

                switch (selection)
                {
                    case 1:
                        Console.Clear();
                        result = Addition(num1, num2);
                        break;
                    case 2:
                        Console.Clear();
                        result = Subration(num1, num2);
                        break;
                    case 3:
                        Console.Clear();
                        result = Multiplication(num1, num2);
                        break;
                    case 4:
                        Console.Clear();
                        if (num2 == 0)
                        {
                            Console.WriteLine("Zero is not allowed");
                        }
                        else
                        {
                            result = Divison(num1, num2);
                        }

                        break;
                    default:
                        Console.WriteLine("Not a valld selection,try again");
                        break;
                }
                // display result

                Console.WriteLine("Result is: " + result);
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
        private static double Subration(double num1, double num2)
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
        private static double Divison(double num1, double num2)
        {
            double result = num1 / num2;
            return result;
        }

    }
}