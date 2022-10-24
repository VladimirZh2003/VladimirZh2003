using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit2
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, a;
            Console.WriteLine("Enter N:");
            N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");
            if (N % 2 == 0) N++;
            for (int i = 0; i < N; i += 2)
            {
                for (int j = 0; j < (N - 1) / 2 - (i / 2); j++) Console.Write(' ');
                for (int j = 0; j < i + 1; j++) Console.Write('*');
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}

