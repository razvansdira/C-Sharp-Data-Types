using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Data_Types
{
    class Exercise8
    {
        static void Main(String[] args)
        {
            float radius;
            float pi =3.1415f;

            Console.Write("Radius: ");
            radius = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine(" Output:");

            Console.WriteLine("Surface: {0}", 4*pi*(radius*radius));
            Console.WriteLine(" Volume: {0} ", 4/3*pi*(radius*radius*radius));

            Console.ReadLine();
        }
    }
}
