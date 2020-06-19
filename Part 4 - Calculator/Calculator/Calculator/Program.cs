using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string prompt = "Please choose one of the following: add, subtract, multiply, divide";
            Console.WriteLine(prompt);
            string userInput = Console.ReadLine();
            
            if(userInput == "add")
            {
                string prompt1 = "Please enter in a number: ";
                Console.WriteLine(prompt1);
                double a = Convert.ToDouble(Console.ReadLine());

                string prompt2 = "Please enter in another number: ";
                Console.WriteLine(prompt2);
                double b = Convert.ToDouble(Console.ReadLine());

                double result = a + b;
                string resultMessage = "The result of " + a + " + " + b + " = " + result;
                Console.WriteLine(resultMessage);
            }
            else if(userInput == "subtract")
            {
                string prompt1 = "Please enter in a number: ";
                Console.WriteLine(prompt1);
                double a = Convert.ToDouble(Console.ReadLine());

                string prompt2 = "Please enter in another number: ";
                Console.WriteLine(prompt2);
                double b = Convert.ToDouble(Console.ReadLine());

                double result = a - b;
                string resultMessage = "The result of " + a + " - " + b + " = " + result;
                Console.WriteLine(resultMessage);
            }
            else if (userInput == "multiply")
            {
                string prompt1 = "Please enter in a number: ";
                Console.WriteLine(prompt1);
                double a = Convert.ToDouble(Console.ReadLine());

                string prompt2 = "Please enter in another number: ";
                Console.WriteLine(prompt2);
                double b = Convert.ToDouble(Console.ReadLine());

                double result = a * b;
                string resultMessage = "The result of " + a + " * " + b + " = " + result;
                Console.WriteLine(resultMessage);
            }
            else if (userInput == "divide")
            {
                string prompt1 = "Please enter in a number: ";
                Console.WriteLine(prompt1);
                double a = Convert.ToDouble(Console.ReadLine());

                string prompt2 = "Please enter in another number: ";
                Console.WriteLine(prompt2);
                double b = Convert.ToDouble(Console.ReadLine());

                double result = a / b;
                string resultMessage = "The result of " + a + " / " + b + " = " + result;
                Console.WriteLine(resultMessage);
            }
            else
            {
                Console.WriteLine("ERROR - INVALID INPUT");
            }
        }
    }
}
