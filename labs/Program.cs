using System;

namespace lab3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var rnd = new Random();
            var array = new int[10];
            int oddSum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(-10, 10);
                if (array[i] % 2 > 0)
                {
                    oddSum += array[i];
                }
                Console.Write($"{array[i]}  ");
            }
            Console.WriteLine();
            Console.WriteLine($"Сумма нечетных чисел равна= {oddSum}");
            Console.WriteLine("Введите значение числа A");
            var a = int.Parse(Console.ReadLine());
            for (int i = 0; i < array.Length; i++)
            {

                if (array[i] > a)
                {
                    Console.WriteLine($"Индекс большего числа {i}");
                }
            }
            Console.WriteLine("Введите значение положительного числа k");
            var k = int.Parse(Console.ReadLine());
            for (int i = 0; i < array.Length; i++)
            {

                if (array[i] == k && array[i] >= 0)
                {
                    Console.WriteLine($"K = {k}, кратно {array[i]} с индексом {i}");
                }
            }


            var rnd = new Random();
            int[,] array = new int[10, 10];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    array[i, j] = rnd.Next(1, 100);
                    Console.Write($"{array[i, j]}\t");
                }
                Console.WriteLine();
            }
            long multiplicaton = 1;
            for (int i = 0; i < 1; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write($"{array[i, j]}\t");
                    multiplicaton *= array[i, j];
                }
                Console.WriteLine();
            }
            Console.WriteLine($"Произведение первой строки = {multiplicaton}");

            Console.WriteLine("Введите m матрицы");
            var m = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите n матрицы");
            var n = int.Parse(Console.ReadLine());
            var rnd = new Random();
            int[,] array = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    array[i, j] = rnd.Next(0, 10);
                    Console.Write($"{array[i, j]}\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Введите число для поска в матрице");
            var number = int.Parse(Console.ReadLine());
            var counter = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (array[i, j] == number)
                    {
                        counter++;
                    }
                }
            }
            Console.WriteLine($"Данной число встречается в этой матрице {counter} раз");

        }
    }
}
