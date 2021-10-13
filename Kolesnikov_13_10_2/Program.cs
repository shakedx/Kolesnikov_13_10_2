using System;

namespace Kolesnikov_13_10_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координату x:");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите координату y:");
            double y = double.Parse(Console.ReadLine());
            if (x > -1 && x <= 1 && y < 1 && y >= 0 && !(x * x * y * y == 1)) Console.WriteLine("Точка попадает в область");
            else
            {
                Console.WriteLine("Точка не попадает в область");
            }

        }
    }
}
