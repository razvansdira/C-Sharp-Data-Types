using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Data_Types
{
    class Exercise4
    {
        static void Main(string[] args)
        {
            int a, b;
            char op;

            Console.Write("Input first number: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input second number: ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input operation: ");
            op = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Operation: ");

            if (op == '+')
                Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
            else if (op == '-')
                Console.WriteLine("{0} - {1} = {2}", a, b, a - b);
            else if ((op == 'x') || (op == '*'))
                Console.WriteLine("{0} * {1} = {2}", a, b, a * b);
            else if (op == '/')
                Console.WriteLine("{0} / {1} = {2}", a, b, a / b);
            else
                Console.WriteLine("Operatie gresita.");

            Console.ReadLine();
        }
    }
}
