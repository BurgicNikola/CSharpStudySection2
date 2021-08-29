using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson01IntroToMethods
{

    // Syntax:
    // <Access Specifier> <Return Type> <Method Name>(Parameter List)
    // {
    //      Method Body
    // }

    // Access Specifier - Determines the visibility of a variable or a method from another class.
    // Return Type - Data type of the value the method returns. If the method returns no values, then the return type is void.
    // Method Name - It is a unique identifier and it is case sensitive. It cannot be same as any other identifier declared in the class.
    // Parameter list - Used to pass and receive data from a method. The parameter list refers to the type, order, and number 
    // of the parameters of a method. Parameters are optional; that is, a method may contain no parameters.
    // Method Body - Contains the set of instructions needed to complete the required activity.
    class Program
    {
        static void Main(string[] args)
        {
        }

        /// <summary>
        /// A method returning the sum of two entered integers.
        /// </summary>
        /// <param name="num2"></param>
        /// <param name="num2"></param>
        /// <returns>num1 + num2</returns>
        public int Add(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}
