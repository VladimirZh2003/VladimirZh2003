using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit7
{
    class Program
    {
        static void Main(string[] args)
        {
            byte a, b, c;
            Console.WriteLine("Enter the first number");
            a = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            b = Convert.ToByte(Console.ReadLine());
            c = (byte)(a & b);
            Console.Write("And ");
            Console.WriteLine(c);
            c = (byte)(a | b);
            Console.Write("Or ");
            Console.WriteLine(c);
            c = (byte)(a^b);
            Console.Write("XOR ");
            Console.WriteLine(c);

        }
    }
}
