using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;


//Write a program which  prompts user to enter 2 numbers (numbers can have decimal numbers). Program computes the square of sum of these two numbers and square of difference between these 2 numbers . 

namespace CSharpProblemStatements
{
    internal class SquareSumDiff
    {


        public void sumOfTwoNumbers()
        {
            Console.WriteLine("Enter Number 1..");
            int num1=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Number 2... ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int sum = num1 + num2;
            Console.WriteLine("Sum "+sum);

            double SquareOfSum = Math.Sqrt(sum);
            Console.WriteLine("Square of sum of two numbers "+SquareOfSum);
            Console.ReadKey();

        }


      

        public void differenceOfTwoNumbers()
        {
            Console.WriteLine("Enter NUmber 1..");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Number2..");
            int num2 =Convert.ToInt32( Console.ReadLine());

            int diff = num1 - num2;
            Console.WriteLine("Diff "+diff);

            int SquareOfdiff = (int)Math.Sqrt(diff);
            Console.WriteLine("Square of difference oF two Numbers "+SquareOfdiff);
            Console.ReadKey();





            
         



        }
    }
}
