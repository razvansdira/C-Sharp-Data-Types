using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Data_Types
{
    class Exercise10
    {
        static void Main (string[] args)
        {
            int x, y;
            bool both;

            Console.Write("Input first number:");
            x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input second number;");
            y = Convert.ToInt32(Console.ReadLine());

            both = ((x % 2 == 0) && (y % 2 == 0)) ? true : false;

            Console.Write(both ? "Even" : "Odd");
            Console.ReadLine();
        }
    }
}
