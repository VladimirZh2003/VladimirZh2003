using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit4
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 1000;
            int a = 0;
            int n = 0;
            for (int i = n; i < max; i++)
            {
                if (i%3 == 0 || i%5 == 0)
                {
                    a += i;
                }
            }
            
            Console.Write(a);
            Console.ReadKey();
        }
        
    }
}
