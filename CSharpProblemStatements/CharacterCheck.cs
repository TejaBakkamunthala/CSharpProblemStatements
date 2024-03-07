using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProblemStatements
{
    internal class CharacterCheck
    {


        public void CharacterCheck1()

        {

            Console.WriteLine("Enter String...");

            String str = Console.ReadLine();


            for (int i = 0; i < str.Length; i++)
            {
                if (str.Contains('a') && str.Contains('e') && str.Contains('p'))
                {
                    Console.WriteLine("All Present");
                    break;

                }

                else if (str.Contains('a') || str.Contains('e') || str.Contains('p'))
                {
                    Console.WriteLine("One Or More Present ");
                    break;

                }
                else
                {
                    Console.WriteLine("None Present ");
                    break;
                }
            }
            Console.ReadKey(); 
        }

        }
  
}
