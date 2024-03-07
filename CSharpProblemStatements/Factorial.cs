using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Write a program which can compute the factorial of a given numbers.  Develop this as function and call from main. function should return factorial. 
Suppose the following input is supplied to the program: 8 Then, the output should be: 40320*/
namespace CSharpProblemStatements
{
    internal class Factorial
    {


        public void factorial1()
        {
            int num = 8;
            int fact = 1;
           

            for(int i = num; i > 0; i--)
            {
                fact = fact * i;
               
            }

            Console.WriteLine("Factorial Of " + num + "  " + fact);
            Console.ReadKey();

        }
    }
}
