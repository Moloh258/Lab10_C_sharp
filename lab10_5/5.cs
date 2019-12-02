using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите вещественное число, затем целое число");
            double a = Convert.ToDouble(Console.ReadLine());
            int x = Convert.ToInt32(Console.ReadLine());
            double y = 0;
            int b = -1;
            for (int i = 0; i <= a; i++)
            {
                b = b * (-1);
                y += (Math.Pow(x, i) * b);
            }
            Console.WriteLine("Ответ: {0}", y);
        }
    }
}
