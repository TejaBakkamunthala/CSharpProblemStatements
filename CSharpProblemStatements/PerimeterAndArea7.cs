using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProblemStatements
{

   // Compute perimeter and area of a circle.Take diameter of circle as user input, Compute and print out perimeter and area of circle.

    public class PerimeterAndArea7
    {



        int radius;
        public void dia()
        {
            Console.WriteLine("Diameter  ");
            int diameter =Convert.ToInt32(Console.ReadLine());
             radius = diameter / 2;
            
        }

       
       public void perimeter()
        {
    
            double perimeterr = 2 * Math.PI * radius;
            Console.WriteLine("Perimeter Of Circle " +perimeterr);
            
        }


        public void area()
        {
            double area = Math.PI * radius * radius;
            Console.WriteLine("Area Of Circle " + area);
            Console.ReadKey();

        }
    }
}
