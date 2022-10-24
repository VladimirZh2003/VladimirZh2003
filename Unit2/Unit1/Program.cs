using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit1
{   class Program
    {
        static void Main(string[] args)
        {
            int N, a;
            Console.WriteLine("Enter N:");
            N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");
            for (int i = N; i != 0; i--)
            {
                {
                    for (int j = i; j != 0; j--)
                    {
                        Console.Write("*");
                    }
                    Console.Write("\n");
                }
            }

            Console.ReadKey();
        }
    }
}
