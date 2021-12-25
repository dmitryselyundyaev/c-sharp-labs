using System;

namespace lab1_2
{
    class Program
    {
        static void Main(string[] args)
        {

            #region ЗАДАНИЕ 2 ВАРИАНТ 9
            Console.Write("Введите x = ");
            double x = Convert.ToDouble(Console.ReadLine());
            double y = 4.0 * Math.Sin(15 * Math.Pow(Math.E, x / 8.0) + 10.2) - 9.0 * Math.Cos(Math.Pow(Math.E, -x)) + Math.Sqrt(x + 5.0 / 3.0);
            Console.WriteLine($"Y = {Math.Round(y, 3)}");
            #endregion
            #region ЗАДАНИЕ 3 ВАРИАНТ 9
            Console.Write("Введите катет a = ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите катет a = ");
            double b = Convert.ToDouble(Console.ReadLine());
            double p = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2)) + a + b;
            Console.WriteLine($"Периметр треугольника = {Math.Round(p, 2)}");
            #endregion



            #region ЗАДАНИЕ 2 ВАРИАНТ 11
            Console.Write("Введите x = ");
            double x = Convert.ToDouble(Console.ReadLine());
            double y = 1.3 * Math.Pow(Math.E, x / -2.0) + Math.Abs(Math.Cos(2.0 * Math.PI * x / 3.0 - 1.4)) - (6.0 / 11.00);
            Console.WriteLine($"Y = {Math.Round(y, 3)}");


            #endregion
            #region ЗАДАНИЕ 3 ВАРИАНТ 11
            Console.Write("Введите первое число = ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите второе число = ");
            double b = Convert.ToDouble(Console.ReadLine());
            double addition = a + b;
            double subtraction = a - b;
            double multiplication = a * b;
            double division = a / b;
            Console.WriteLine($"Сумма = {addition}, Разность = {subtraction}, Произведение = {multiplication}, Частное = {division}.");
            #endregion



            #region ЗАДАНИЕ 1 ВАРИАНТ 9
            Console.Write("X = ");
            var x = double.Parse(Console.ReadLine());
            Console.Write("Y = ");
            var y = double.Parse(Console.ReadLine());
            Console.Write("Z = ");
            var z = double.Parse(Console.ReadLine());
            var result = 0.0;
            if (x < y)
            {
                if (x + z > x)
                {
                    result = x + z / Math.Pow(x, 2);
                }
                else
                {
                    result = x / Math.Pow(x, 2);
                }
            }
            else
            {
                if (x + z > y)
                {
                    result = x + z / Math.Pow(x, 2);
                }
                else
                {
                    result = y / Math.Pow(x, 2);
                }
            }
            if (result == 0)
            {
                Console.WriteLine($"результат равен {result}");
            }
            else
            {
                Console.WriteLine($"F = {result}");
            }
            #endregion
            #region ЗАДАНИЕ 2 ВАРИАНТ 9

            Console.Write("X = ");
            var x = double.Parse(Console.ReadLine());
            Console.Write("Y = ");
            var y = double.Parse(Console.ReadLine());
            if (y > 0 && y > x && x > 0)
            {
                Console.WriteLine("N1");
            }
            else
            {
                if (y < 0 && x < 0 && x > y)
                {
                    Console.WriteLine("N2");
                }
                else
                {
                    if (x <= 0 && x <= y)
                    {
                        Console.WriteLine("N3");
                    }
                    else
                    {
                        Console.WriteLine("N4");
                    }
                }
            }

            #endregion
            #region ЗАДАНИЕ 3 ВАРИАНТ 9
            NULL

            #endregion

            #region ЗАДАНИЕ 1 ВАРИАНТ 11
            Console.Write("X = ");
            var x = double.Parse(Console.ReadLine());
            Console.Write("Y = ");
            var y = double.Parse(Console.ReadLine());
            Console.Write("Z = ");
            var z = double.Parse(Console.ReadLine());
            var result = 0.0;
            if (x < y + z)
            {
                if (x > y)
                {
                    result = x / (x + Math.Sin(z));
                }
                else
                {
                    result = x / (y + Math.Sin(z));
                }
            }
            else
            {
                if (x > y)
                {
                    result = (y + z) / (x + Math.Sin(z));
                }
                else
                {
                    result = (y + z) / (y + Math.Sin(z));
                }
            }
            if (result == 0)
            {
                Console.WriteLine($"Результат равен {result}");
            }
            else
            {
                Console.WriteLine($"F = {result}");
            }
            #endregion
            #region ЗАДАНИЕ 2 ВАРИАНТ 11

            Console.Write("X = ");
            var x = double.Parse(Console.ReadLine());
            Console.Write("Y = ");
            var y = double.Parse(Console.ReadLine());
            if (y < 1.0 - Math.Pow(x, 2) && y < 1.0)
            {
                if (x >= 0)
                {
                    Console.WriteLine("N2");
                }
                else
                {
                    Console.WriteLine("N1");
                }
            }
            else
            {
                if ((x <= 0 && y >= 0) || (x >= 0 && y <= 0))
                {
                    Console.WriteLine("N4");
                }
                else
                {
                    Console.WriteLine("N3");
                }
            }

            #endregion
            #region ЗАДАНИЕ 3 ВАРИАНТ 11
            while (true)
            {
                Console.Write("Площадь круга = ");
                var CircleP = double.Parse(Console.ReadLine());
                Console.Write("Площадь квадрата = ");
                var SquareP = double.Parse(Console.ReadLine());
                var CircleDiameter = 2 * Math.Sqrt(CircleP / Math.PI);
                var SquareSideLenght = Math.Sqrt(SquareP);
                if (CircleDiameter < SquareSideLenght)
                {
                    Console.WriteLine(SquareSideLenght);
                    Console.WriteLine(CircleDiameter / 2);
                    Console.WriteLine("Круг можно вписать в квадрат");
                }
                else
                {
                    Console.WriteLine(SquareSideLenght);
                    Console.WriteLine(CircleDiameter / 2);
                    if ((CircleDiameter / 2) > (SquareSideLenght * (Math.Sqrt(2) / 2)))
                    {
                        Console.WriteLine("Квадрат можно вписать в круг ");
                    }
                }
            }
            #endregion
        }
    }
}
