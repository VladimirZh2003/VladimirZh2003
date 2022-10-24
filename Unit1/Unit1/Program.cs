using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, S;
            Console.WriteLine("\t\t\t\tA program that counts the square of a rectangle on two sides");
            Console.WriteLine("Enter first side");
            a = Double.Parse(Console.ReadLine());
            Console.WriteLine("Enter second side");
            b = Double.Parse(Console.ReadLine());
            S = a * b;
            //Console.WriteLine($"Rectangle square {S}");
            Console.Write("Rectangle square ");
            Console.WriteLine(S);
        }
    }
}
