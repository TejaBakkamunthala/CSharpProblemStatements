using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
namespace CSharpProblemStatements
{
   // Compute Average of numbers.Generate 5 random numbers between 10 to 50  and compute the average of these numbers.Print the numbers generated in one line and in next line print the average.

    internal class AverageRandomNumbers6
    {
        public void averageOfRandomNumbers()
        {
            int[] arr = new int[5];

            Console.WriteLine("Enter a random NUmbers from 10 t 50 ");
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i]=Convert.ToInt32(Console.ReadLine());
                

            }

            Console.WriteLine("Printing Numbers  ");
            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+" ");
            }

          //  Console.WriteLine("Average Of Numbers  ");
            int sum = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                sum = sum + arr[i];
                
            }

            Double avg = sum / arr.Length;
            Console.WriteLine("Avaerage Of Numbers  " + avg);
            Console.ReadKey();




        }
    }
}
