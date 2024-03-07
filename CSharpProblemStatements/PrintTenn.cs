using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProblemStatements
{

    //Read a number from user as string and print 10 times of that number as string only

    internal class PrintTenn
    {

        public void PrintTen()
        {
            Console.WriteLine("Enter a  number ");

            String num1 = Console.ReadLine();

            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(num1 + " ");

            }
            Console.ReadKey();

         
        }
    }
}
