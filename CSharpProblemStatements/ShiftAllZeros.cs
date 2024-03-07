using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProblemStatements
{
    internal class ShiftAllZeros
    {


        public void ShiftAllZeros1()

        {

            int[] arr = { 12, 0, 42, 0, 4 };

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }


         /*   for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                {
                    arr[i] = arr[i + 1];
                    arr[arr.Length - 1] = 0;
                }
            
            }
            Console.WriteLine();
        
            for(int i = 0; i < arr.Length; i++){
                Console.Write(arr[i] + "  ");

            }
            Console.ReadKey();*/
        }
    }
}
