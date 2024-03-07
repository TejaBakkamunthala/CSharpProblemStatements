using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProblemStatements
{
    internal class RemoveDuplicateElements
    {

        public void RemoveDuplicateElements1()
        {

            String[] strArr = {"25","Anna","False","25","4/15/2021 12:10:51 PM","Anna","False" };

            String[] strArr1 = new string[strArr.Length]; 


            for (int i = 0; i < strArr.Length; i++)
            {
                Console.Write(strArr[i]+"  ");
            }

            int k = 0;

            for(int i = 0; i < strArr.Length; i++)
            {
                int count = 0;
                for(int j=0;j<strArr.Length; j++)
                {
                    if (strArr[i].Equals(strArr[j]))
                    {
                        count++;
                    }
                }
                if (count == 1 || count>1)
                {
                    strArr1[k] = strArr[i];

                }
                k++;
            }


            Console.WriteLine();
            for (int i=0; i < strArr1.Length; i++)
            {
                Console.Write(strArr1[i]+"  ");
            }
        }
    }
}
