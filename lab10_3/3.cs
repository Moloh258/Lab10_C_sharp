using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n\n\n");
            int b = 0;
            for (int i = 1; i <= a; i++)
            {
                b += 2 * i - 1;
                Console.WriteLine(b);
            }
        }
    }
}
