using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpProblemStatements
{
    internal class FirstRepeatedElement
    {

        public void FirstRepeatedElement1()
        {

            // int[] arr = new int[5];
            int[] arr = { 2, 3, 2, 4, 5, 5 };

            int[] arr1 = new int[arr.Length];
            //for(int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = Convert.ToInt32(Console.ReadKey());
            //}

            for(int i=0;i<arr.Length; i++)
            {
                Console.Write(arr[i]+" ");
            }


            int k = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                
                int count = 0;                
                for(int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                    count++;
                    }

                }
                
                if (count >1)
                {
                    arr1[k] = arr[i];
                    k++;
                }
            }

            for(int i = 0; i < arr1.Length; i++)
            {
                Console.Write(arr1[i]);
            }

            Console.WriteLine();
            Console.WriteLine(arr1[0]);
        }
    }
}
