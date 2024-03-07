using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProblemStatements
{
    internal class SecondLargestElement
    {


        public void SecondLargestElement1()
        {


            int[] arr = { 2, 9, 1, 4, 6 };


            int min = arr[0];
            int temp;


            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {

                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;

                    }
                }
            }

            Console.WriteLine();
            for (int i=0;i<arr.Length; i++)
            {
                Console.Write(arr[i]+" ");
            }
            Console.WriteLine();

            Console.WriteLine("Second Largest Element"+arr[arr.Length-2]);

        }

    
    }
}
