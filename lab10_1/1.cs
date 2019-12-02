using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10_1
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Введите цену за один килограмм конфет");
            double x = Convert.ToDouble(Console.ReadLine());
            for (double i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0}кг конфет стоит {1} рублей", i * 0.1, x * (i * 0.1));
            }
        }
    }
}
