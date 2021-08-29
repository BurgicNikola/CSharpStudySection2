using System;

namespace Lesson03MethodsWithReturnValueAndParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(20, 11));
            Console.WriteLine(Add(Add(3,4), Add(33,3)));
            Console.WriteLine(Multiply(4, 3));
            Console.WriteLine(Divide(7,3));
            Console.ReadKey();
        }

        /// <summary>
        /// A method returning the sum of two integers.
        /// </summary>
        /// <param name="num2"></param>
        /// <param name="num2"></param>
        /// <returns>num1 + num2</returns>
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        } 

        /// <summary>
        /// A method returning the multiplication of two integers.
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns>num1 * num2</returns>
        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

         /// <summary>
         /// A method returning the division of two doubles.
         /// </summary>
         /// <param name="num1"></param>
         /// <param name="num2"></param>
         /// <returns>num1 / num2</returns>
        public static double Divide(double num1, double num2)
        {
            return num1 / num2;
        }
    }
}
