using System;

namespace lab3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Одномерные задание 1
            Console.WriteLine("Введите количество элементов массива");
            var n = int.Parse(Console.ReadLine());
            var rnd = new Random();
            int[] myArray = new int[n];
            var sum = 0;
            for (var i = 0; i < n; i++)
            {
                myArray[i] = rnd.Next(-10, 20);
                Console.Write($"{myArray[i]} \t");
                if (i % 2 == 1)
                {
                    sum += myArray[i];
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Сумаа всех элементов с нечетным индексом = {sum}");

            Console.WriteLine("Введите число А");
            var a = int.Parse(Console.ReadLine());
            var count = 0;
            for (var i = 0; i < n; i++)
            {
                if (myArray[i] > a && myArray[i] % 5 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine($"Число элементов массива значение которых больше {a} и кратных 5 = {count}");

            for (var i = 0; i < n; i++)
            {
                if (myArray[i] % 5 == -2 && myArray[i] < 0)
                {
                    Console.WriteLine($"Первый отрицательный элемент делящийся на 5 с остатком 2 = {i}");
                }
            }
            #endregion
            #region Многомерные задание 2
            var rnd = new Random();
            int[,] myArray = new int[5, 6];
            for (var i = 0; i < 5; i++)
            {
                for (var j = 0; j < 6; j++)
                {
                    myArray[i, j] = rnd.Next(-10, 10);
                    Console.Write($"{myArray[i, j]} \t");
                }
                Console.WriteLine();
            }
            for (var j = 0; j < 6; j++)
            {
                var result = 0;
                var count = 0;
                for (var i = 0; i < 5; i++)
                {
                    if (myArray[i, j] > 0)
                    {
                        result += myArray[i, j];
                        count++;
                    }
                }
                if (count != 0)
                {
                    Console.WriteLine($"Среднее арифметическое положительных чисел стобца №{j} = {(double)(result / count)}");
                }
                else
                {
                    Console.WriteLine($"В столбце {j} нет положительных элементов");
                }
            }
            #endregion
        }
    }
}
