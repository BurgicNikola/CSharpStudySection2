using System;

namespace Lesson07Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 3;
            int num3;

            // Unary operator
            num3 = -num1;
            Console.WriteLine($"num3 is {num3}");

            bool isSunny = true;
            Console.WriteLine($"Is it sunny? {!isSunny}");

            // Increment operators
            int num = 0;
            num++;
            Console.WriteLine("num is {0}", num);
            // Post increment
            Console.WriteLine("num is {0}", num++);
            // Pre increment
            Console.WriteLine("num is {0}", ++num);

            // Decrement operators
            num--;
            Console.WriteLine("num is {0}", num);
            // Post decrement
            Console.WriteLine("num is {0}", num--);
            // Pre decrement
            Console.WriteLine("num is {0}", --num);


            Console.Read();
        }
    }
}
