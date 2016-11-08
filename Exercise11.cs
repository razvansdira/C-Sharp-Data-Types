using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Data_Types
{
    class Exercise11
    {
        static void Main(string[] args)
        {
            int nr;
            string result;
            Console.Write("Input a decimal number ");
            nr = Convert.ToInt32(Console.ReadLine());
            result = "";
            while (nr > 1)
            {
                int remainder = nr % 2;
                result = Convert.ToString(remainder) + result;
                nr /= 2;
            }
            result = Convert.ToString(nr) + result;

            Console.WriteLine("Binary: {0}", result);
            Console.ReadLine();
        }
    }
}
