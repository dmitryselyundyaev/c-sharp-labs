using System;

namespace lab1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите x = ");
            var x = double.Parse(Console.ReadLine());
            Console.Write("Введите y = ");
            var y = double.Parse(Console.ReadLine());
            Console.Write("Введите z = ");
            var z = double.Parse(Console.ReadLine());
            var max = 0.0;
            var min = 0.0;
            if ((Math.Pow(x, 3) > Math.Pow(y, 2)) && (Math.Pow(x, 3) > (x * y)))
            {
                max = Math.Pow(x, 3);
            }
            else if ((Math.Pow(y, 2) > Math.Pow(x, 3)) && (Math.Pow(y, 2) > (x * y)))
            {
                max = Math.Pow(y, 2);
            }
            else
            {
                max = (x * y);
            }
            if (x < (y * z))
            {
                min = x;
            }
            else
            {
                min = (y * z);
            }
            var result = (max + x) / (Math.Pow(min, 2) - y);
            if (result != 0)
            {
                Console.WriteLine($"Ваш результат равен = {result}");
            }
            else
            {
                Console.WriteLine("Внимание ваш результат равен = 0");
            }
            Console.ReadLine();

            Console.Write("Введите x = ");
            var x = double.Parse(Console.ReadLine());
            Console.Write("Введите y = ");
            var y = double.Parse(Console.ReadLine());
            if (((x > 0 && y > 0) || (x < 0 && y < 0)) && (y == 1.0 / x) && (x != 0 && y != 0))
            {
                Console.WriteLine("N2");
            }
            else if (((x <= 0 && y > 0) || (y <= 0 && x > 0)) || (x == 0 && y == 0))
            {
                Console.WriteLine("N3");
            }
            else if ((x > 0 && y > 0) || (x < 0 && y < 0))
            {
                Console.WriteLine("N1");
            }

            Console.Write("Введите a = ");
            var a = double.Parse(Console.ReadLine());
            Console.Write("Введите b = ");
            var b = double.Parse(Console.ReadLine());
            Console.Write("Введите c = ");
            var c = double.Parse(Console.ReadLine());
            if (a == b)
            {
                Console.WriteLine($"Есть пара чисел a = {a} и b = {b}");
            }
            else if (a == c)
            {
                Console.WriteLine($"Есть пара чисел a = {a} и c = {c}");
            }
            else if (c == b)
            {
                Console.WriteLine($"Есть пара чисел c = {c} и b = {b}");
            }
        }
    }
}
