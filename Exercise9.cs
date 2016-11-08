using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Data_Types
{
    class Exercise9
    {
        static void Main(string[] args)
        {
            char x;
            Console.Write("Input a symbol: ");
            x = Convert.ToChar(Console.ReadLine());
            if ((x == 'a') || (x == 'e') || (x == 'i') || (x == 'o') || (x == 'u'))
                Console.WriteLine("It's a lowercase vowel.");
            else if ((x >= '0') &&  (x <= '9'))
                Console.WriteLine("It's a digit.");
            else Console.WriteLine("Other symbol");
            Console.ReadLine();
        }
    }
}
