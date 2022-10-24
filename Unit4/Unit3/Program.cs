using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit3
{
    class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Введите количество ярусов");
            int N = int.Parse(Console.ReadLine());
            int A = N * N;
            int B = (A / 2);
            for (int i = 1; i < N+1; i++)
            {
               int j = i;
                for (int i3 = 0; i3 < N; i3++,j++)
                {
                    for (int i1 = 0; i1 < A; i1++)
                    {
                        if (i1 < B + j && i1 > B - j)
                            Console.Write("*");
                        else
                            Console.Write(" ");
 
                    }
                    Console.WriteLine();
                }
            }
            Console.ReadKey();

        }
    }
}
