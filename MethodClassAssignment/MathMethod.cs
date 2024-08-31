using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassAssignment
{
    class MathMethod
    {
        //declaring the two integers to be used as parameters for the void method. 
        public int integer1;
        public int integer2;

        //Creating the void method that takes two integers as parameters.
        public void MyMethod(int integer1, int integer2)
        {
            //Math operation on the first integer
            //The VOID method does not return any value from the math operation

            _ = integer1 + 8; //No need to declare variable for the result since method does not return an output.            

            //Displaying the second integer to the screen or Console window.

            Console.WriteLine("The second integer is: " + integer2);
            Console.ReadLine();
        }
    }
}
