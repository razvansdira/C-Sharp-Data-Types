using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Data_Types
{
    class Exercise5
    {
        static void Main (string[] args)
        {
            double r, perim, area;
            double pi = 3.14;

            Console.Write("Input the radius of the circle: ");
            r = Convert.ToDouble(Console.ReadLine());

            perim = 2 * pi * r;
            area = pi * r * r;

            Console.WriteLine("Perimeter: {0}", perim);
            Console.WriteLine("Area: {0}", area);

            Console.ReadLine();
        }
    }
}
