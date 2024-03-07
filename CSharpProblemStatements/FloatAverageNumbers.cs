using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProblemStatements
{
    internal class FloatAverageNumbers
    {



        public void averageNumbers()
        {

            float[] arr = { 1.23f, 2.34f, 3.45f, 4.45f, 5.56f };

            float sum = 0;
            for(int i = 0; i < arr.Length; i++)
            {

                sum = sum + arr[i];

                
            }
            float avg = sum / arr.Length;

            Console.WriteLine("Flaot Average Numbers  " + avg);
            Console.ReadKey();


        }
        

    }
}
