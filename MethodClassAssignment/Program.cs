using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //INSTANTIATION OF THE MATHMETHOD CLASS
            MathMethod MyMathMethod = new MathMethod();

            //assigning values to the variables
            MyMathMethod.integer1 = 2;
            MyMathMethod.integer2 = 12;

            //Calling the method in the class by passing in two numbers.
            /*Note the arguments need to be in the same order as specified in the method declaration 
              to be identified correctly for processing*/

            MyMathMethod.MyMethod(2, 12);

            //Calling the method in the class, specifying the parameters by name.
            //In this case the arguments are sent with the key: value syntax.
            //That way, the order of the arguments does not matter:

            MyMathMethod.MyMethod(integer2:12, integer1:2);

            //although the order in which the arguments are passed is reversed, the outcome is the same.
        }
    }
}
