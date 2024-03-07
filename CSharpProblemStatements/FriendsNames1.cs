using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Write a program which displays 5 your friends' names

namespace CSharpProblemStatements
{
    internal class FriendsNames
    {


       public  void FriendsName1()
        {

           

            String[] arr = {"Raju","Ravi","Hari","Kiran","Manoj"};

            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i] + " ");
            }

            Console.ReadKey();


        }

    }
}
