using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson05UserInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculate();
            Console.Read();
        }

        /// <summary>
        /// Prompts the user to enter two numbers and prints their sum to the console.
        /// </summary>
        public static void Calculate()
        {
            Console.WriteLine("This program prints the sum of the two numbers that you enter.");
            Console.Write("Enter the first number: ");
            string num1 = Console.ReadLine();
            Console.Write("Enter the second number: ");
            string num2 = Console.ReadLine();
            Console.WriteLine("The sum of the two numbers that you entered is " + (int.Parse(num1) + int.Parse(num2)) + ".");
        }
    }
}
