using System;

namespace lab3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Одномерные 1 задание
            var n = 100;
            var rnd = new Random();
            int[] myArray = new int[n];
            for (var i = 0; i < n; i++)
            {
                myArray[i] = rnd.Next(-100, 200);
                Console.Write($"{myArray[i]} \t");
            }
            Console.WriteLine();
            Console.WriteLine("Введите число для проверки");
            var num = int.Parse(Console.ReadLine());
            var sum = 0;
            for (var i = 0; i < n; i++)
            {
                if (myArray[i] > num && (myArray[i] % 2 == 0))
                {
                    sum += myArray[i];
                }
            }
            Console.WriteLine($"Сумма четных элементов больше заданного числа = {sum}");
            Console.WriteLine();
            Console.WriteLine("Введите A");
            var a = int.Parse(Console.ReadLine());
            var count = 0;
            for (var i = 0; i < n; i++)
            {
                if (myArray[i] < 0 && myArray[i] > a * -1)
                {
                    count++;
                }
            }
            Console.WriteLine($"Количество отрицательных элементов модуля числа {a} = {count}");
            Console.WriteLine();
            for (var i = 1; i < n - 1; i++)
            {
                if ((myArray[i] + myArray[i + 1] == 0) || (myArray[i] + myArray[i - 1] == 0))
                {
                    Console.WriteLine($"{myArray[i - 1]} {myArray[i]} {myArray[i + 1]}");
                    break;
                }
            }
            #endregion
            #region Многомерные 1задание
            Console.WriteLine("Введите n");
            var n = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите m");
            var m = int.Parse(Console.ReadLine());
            var rnd = new Random();
            int[,] myArray = new int[n, m];
            for (var i = 0; i < n; i++)
            {
                for (var j = 0; j < m; j++)
                {
                    myArray[i, j] = rnd.Next(0, 10);
                    Console.Write($"{myArray[i, j]}\t");
                }
                Console.WriteLine();
            }
            for (var j = 0; j < m; j++)
            {
                var num = 0;
                for (var i = 0; i < n; i++)
                {
                    if (myArray[i, j] > num)
                    {
                        num = myArray[i, j];
                    }
                }
                Console.WriteLine($"Наибольшее число в столбце №{j} = {num}");
            }
            #endregion
            #region многомерные 2 задание
            Console.WriteLine("Введите размер квадратой матрицы ");
            int matrixSize = int.Parse(Console.ReadLine());
            var rnd = new Random();
            int[,] myArray = new int[matrixSize, matrixSize];
            for (var i = 0; i < matrixSize; i++)
            {
                for (var j = 0; j < matrixSize; j++)
                {
                    myArray[i, j] = rnd.Next(0, 10);
                    Console.Write($"{myArray[i, j]}\t");
                }
                Console.WriteLine();
            }
            var indexForDiagonal = 0;
            for (var i = 0; i < matrixSize; i++)
            {
                var num = 0;
                for (var j = 0; j < matrixSize; j++)
                {
                    if (myArray[i, j] > num)
                    {
                        num = myArray[i, j];
                    }
                    if (j == (matrixSize - 1))
                    {
                        myArray[i, indexForDiagonal] = num;
                        indexForDiagonal++;
                    }
                }

                Console.WriteLine($"Наибольшее число в строке №{i} = {num}");

            }
            for (var i = 0; i < 10; i++)
            {
                for (var j = 0; j < 10; j++)
                {
                    Console.Write($"{myArray[i, j]}\t");
                }
                Console.WriteLine();
            }
            #endregion
        }
    }
}
