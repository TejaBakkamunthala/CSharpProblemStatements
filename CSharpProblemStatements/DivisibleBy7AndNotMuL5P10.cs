using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program which will find all such numbers which are divisible by 7 but are not a multiple of 5, between 2000 and 3200 (both included).  The numbers obtained should be printed in a comma-separated sequence on a single line.

namespace CSharpProblemStatements
{
    internal class DivisibleBy7AndNotMuL5P10
    {


        int[] arr = { 2100, 2121, 2222, 2200, 1400, 1414, 2800, 2828 };

        public void DivisibleBy7()
        {

            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i]%7==0 && arr[i] % 5 != 0)
                {

                    Console.Write(arr[i] + ", ");
               
                }
            }

            Console.ReadKey();

        }
    }
}
