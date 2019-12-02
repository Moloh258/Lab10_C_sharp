using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите вещественное число, затем целое число");
            double a = Convert.ToDouble(Console.ReadLine());
            int x = Convert.ToInt32(Console.ReadLine());
            double y = 0;
            for (int i = 0; i <= a; i++)
            {
                y += Math.Pow(x, i);
            }
            Console.WriteLine("Ответ: {0}", y);
        }
    }
}
