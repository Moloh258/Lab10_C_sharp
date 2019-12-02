using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число");
            int x = Convert.ToInt32(Console.ReadLine());
            double i = 1;
            double a = 1;
            while (x > 0)
            {               
                i += 0.1;
                a *= i;
                x--;
            }
            Console.WriteLine("Ответ: {0}", a);
        }
    }
}
