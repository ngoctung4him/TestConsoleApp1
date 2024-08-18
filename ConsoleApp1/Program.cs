using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)            
        {
            Console.WriteLine("CALCULATOR APPLICATION");
            // Prompt user for input
            Console.Write("What is the first number? ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("What is the second number? ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            // Display menu options
            Console.WriteLine("Select an operation:");
            Console.WriteLine("1 - Addition");
            Console.WriteLine("2 - Subtraction");
            Console.WriteLine("3 - Multiplication");
            Console.WriteLine("4 - Division");

            // Get user choice
            Console.Write("Enter your choice (1-4): ");
            int choice = Convert.ToInt32(Console.ReadLine());

            // Perform the selected operation
            double result = 0;
            bool validOperation = true;

            switch (choice)
            {
            case 1:
            result = num1 + num2;
                Console.WriteLine($"The result of addition is: {result}");
                break;

            case 2:
            result = num1 - num2;
            Console.WriteLine($"The result of subtraction is: {result}");
            break;

            case 3:
            result = num1 * num2;
            Console.WriteLine($"The result of multiplication is: {result}");
            break;

            case 4:
            if (num2 != 0)
            {
                result = num1 / num2;
                Console.WriteLine($"The result of division is: {result:F2}");
            }
            else
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
            }
            break;

            default:
                Console.WriteLine("Invalid choice. Please select a number between 1 and 4.");
                validOperation = false;
            break;
        }

        if (validOperation)
        {
            // Output the result
            Console.WriteLine($"Here is the result: {result:F2}");
               
        }
        Console.Read();
}
    }
}
