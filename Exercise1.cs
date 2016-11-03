using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Data_Types
{
    class Exercise1
    {
        static void Main (String[] args)
        {
            char a, b, c;

            Console.WriteLine("Enter letter: ");
            a = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Enter letter: ");
            b = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Enter letter: ");
            c = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Reverse order: ");
            Console.WriteLine("{0} {1} {2}", c, b, a);

            Console.ReadKey();
        }
    }
}