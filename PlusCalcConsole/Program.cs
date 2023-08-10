using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlusCalcConsole
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Plus Calculator");

            // Prompt for the first number
            Console.Write("Enter the first number: ");
            string input1 = Console.ReadLine();
            double number1 = Convert.ToDouble(input1);

            // Prompt for the second number
            Console.Write("Enter the second number: ");
            string input2 = Console.ReadLine();
            double number2 = Convert.ToDouble(input2);

            // Calculate the sum
            double sum = number1 + number2;

            // Display the result
            Console.WriteLine($"The sum of {number1} and {number2} is: {sum}");
        }
    }
}
