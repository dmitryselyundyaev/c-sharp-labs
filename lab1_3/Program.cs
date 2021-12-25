using System;

namespace lab1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            OperatingSystem os = System.Environment.OSVersion; // Версия операционной системы.

            Console.WriteLine("Platform: {0}", os.Platform);
            System.Console.WriteLine("The current date and time is " +
                System.DateTime.Now); // Дата и время.
            Console.ReadKey();


            Console.Write("Input x = ");
            double x = Convert.ToDouble(Console.ReadLine());
            double x = 0.96;
            double y = Math.Cos(1.5 * x) - Math.Exp(Math.Sin(x + 5.0 / 3.0)) + Math.Sqrt(x + 7.0 / 6.0);

            Console.WriteLine(" x = {0} \t y = {1} ", x, y);
            Console.ReadKey();



            Console.Write("Enter a "); double a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter b "); double b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter с "); double с = Convert.ToInt32(Console.ReadLine());
            double s = 2 * с * (a + b);
            double v = a * b * с;
            Console.Write(" Площадь боковой поверхности = {0} \t Обьем = {1} ", v, s);
            Console.ReadKey(true);
        }
    }
    }
}
