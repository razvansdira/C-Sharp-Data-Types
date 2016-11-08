using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Data_Types
{
    class Exercise7
    {
        static void Main (String[] args)
        {
            float km, h, m, s;
            float timeSec, mps, kmph, mph;

            Console.Write("Input distance(meters):");
            km = Convert.ToSingle(Console.ReadLine());

            Console.Write("Input timeSec(hour):");
            h = Convert.ToSingle(Console.ReadLine());

            Console.Write("Input timeSec(minutes):");
            m = Convert.ToSingle(Console.ReadLine());

            Console.Write("Input timeSec(seconds):");
            s = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Output: ");

            timeSec = (h * 3600) + (m * 60) + s;
            mps = km / timeSec;
            kmph = (km / 1000.0f) / (timeSec / 3600.0f);
            mph = kmph / 1.609f;

            Console.WriteLine("Your speed in meters/sec is {0}", mps);
            Console.WriteLine("Your speed in km/h is {0}.", kmph);
            Console.WriteLine("Your speed in miles/hour is {0}", mph);

            Console.ReadLine();
        }
    }
}
