using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Data_Types
{
    class Exercise6
    {
        static void Main(string[] args)
        {
            int x,y;

            Console.WriteLine("Ecuations: ");
            Console.WriteLine(" x = y² + 2 * y + 1");

            for (y=-5; y<=5; y++)
            {
                x = y * y + 2 * y + 1;
                Console.WriteLine("y = {0} ; x = ({0} * {0}) + 2 * {0} + 1 = {1}", x, y);
            }

            Console.ReadLine();
        }
    }
}
