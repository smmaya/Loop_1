using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pętle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 100, suma = 0;
            for (int i = 1; i <= n; i++)
            {
                suma = suma + i;
            }
            Console.WriteLine("Suma " + n + " pierwszych liczb = " + suma);

            Console.ReadKey();

        }
    }
}