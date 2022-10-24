using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, p;
            double s;
            Console.WriteLine("Введите стороны треугольника!");

            Console.WriteLine("Сторона a");
            a = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Сторона b");
            b = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Сторона c");
            c = Convert.ToInt16(Console.ReadLine());
            if ((a + b <= c) && (a + c <= b) &&(b + c <= a))
                {
                Console.WriteLine("Треугольник не существует");
                }
            else
            {
                p = (a + b + c) / 2;
                s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

                Console.WriteLine("Площадь треугольника");
                Console.Write(s);
                Console.WriteLine("\n");
            }

            Console.ReadKey();
        
        }
    }
}
