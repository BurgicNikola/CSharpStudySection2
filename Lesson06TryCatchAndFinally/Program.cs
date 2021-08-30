using System;

namespace Lesson06TryCatchAndFinally
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number: ");
            string input = Console.ReadLine();

            try
            {
                // To see possible exceptions, hover over Parse:
                int intInput = int.Parse(input);
            }
            // In case a user enters letters or symbols.
            catch (FormatException)
            {
                Console.WriteLine("Format exception, please enter number next time.");
            }
            // In case user enters too big of a number for Int32.
            catch (OverflowException)
            {
                Console.WriteLine("Overflow exception, the number was too long or too short for Int32.");
            }
            // In case the value of input remains empty. Does not happen here, bcs empty string is created, and the string does not have a null value.
            catch (ArgumentNullException)
            {
                Console.WriteLine("Argument null exception, the value is null.");
            }
            // Code to be executed whenever TryCatch is done. Error or no error, code in 'finally' will be run.
            finally
            {
                Console.WriteLine("This is called anyways.");
            }

            DivideByZero();

            Console.ReadKey();
        }

        public static void DivideByZero()
        {
            Console.Write("Please enter a number: ");
            string input = Console.ReadLine();
            try
            {
                Console.WriteLine(int.Parse(input) / 0);
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Argument null exception.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Format exception.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Overflow exception.");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Divide by zero exception.");
            }
            finally
            {
                Console.WriteLine("Program ended.");
            }
        }
    }
}
