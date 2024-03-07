using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpProblemStatements
{
    internal class PrintPrimeNumber
    {
        public void findprintNUmber()
        {
            int[] arr = { 2, 3, 4, 5, 6, 7, 8, 9, 21, 23, 25, 27,29,30 };

            for(int i = 0; i < arr.Length; i++)
            {
                int count = 0;
                for(int j= 1; j <=arr[i]; j++)

                {
                    
                    if ((arr[i] % j) == 0)
                    {
                        count++;
                    }

                }
                if(count==2)
                {
                    Console.WriteLine(arr[i] + " ");
                }
            }
            Console.ReadKey();

        }


    }
}
