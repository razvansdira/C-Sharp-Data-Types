using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Data_Types
{
    class Exercise2
    {
        static void Main(string[] args)
        {
            int nr, width, height;

            Console.Write("Enter a number: ");
            nr = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the desired width: ");
            width = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Expected output:");

            height = width;

            for(int row=0; row<height; row++)
            {
                for (int column=0; column<width; column++)
                {
                    Console.Write(nr);
                }
                Console.WriteLine();
                width--;
            }
            Console.ReadKey();
        }
    }
}