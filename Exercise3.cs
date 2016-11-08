using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Data_Types
{
    class Exercise3
    {
        static void Main(string[] args)
        {
            string id, pass;
            int ctr = 0;

            do
            {
                Console.Write("Introduceti nume de utilizator: ");
                id = Console.ReadLine();

                Console.Write("Introduceti parola: ");
                pass = Console.ReadLine();

                ctr++;
            }
            while((id != "razvan" && pass != "1234") && (ctr != 3));

            if (ctr == 3)
                Console.WriteLine("Incercati mai tarziu.");
            else
                Console.WriteLine("Parola corecta.");
            Console.ReadLine();
        }
    }
}
