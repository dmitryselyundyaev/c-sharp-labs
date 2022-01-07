using System;
using System.Collections.Generic;

namespace ConsoleApp40
{
    class Program
    {
        static void Main(string[] args)
        {

            #region EX1
            //Console.Write("Введите n = ");
            //var n = int.Parse(Console.ReadLine());
            //var myArray = new int[n];
            //var rnd = new Random();
            //var negativeNumSum = 0;
            //for (var i = 0; i < myArray.Length; i++)
            //{
            //    myArray[i] = rnd.Next(-10, 20);
            //    Console.WriteLine(myArray[i]);
            //    if (myArray[i] < 0)
            //    {
            //        negativeNumSum += myArray[i];
            //    }
            //}
            //Console.WriteLine($"Сумма отрицательных элементов = {negativeNumSum}");
            //Console.Write("Введите число А = ");
            //var a = int.Parse(Console.ReadLine());
            //var count = 0;
            //for (var i = 0; i < myArray.Length; i++)
            //{
            //    if (myArray[i] > 0 && myArray[i] < a)
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine($"Количество положительных элементов которые не превосходят число А = {count}");
            //for (var i = myArray.Length - 2; i > 0; i--)
            //{
            //    if ((myArray[i] == myArray[i - 1] * -1) || (myArray[i] == myArray[i + 1] * -1))
            //    {
            //        if (myArray[i] == myArray[i - 1] * -1)
            //        {
            //            Console.WriteLine($"Первая пара сосендин элементов имеет индексы {i} и {i - 1}");
            //        }
            //        else
            //        {
            //            Console.WriteLine($"Первая пара сосендин элементов имеет индексы {i} и {i + 1}");
            //        }
            //        break;
            //    }
            //    else if (i == 1)
            //    {
            //        Console.WriteLine("Нет пар соседних элементов с разными знаками");
            //    }
            //}
            #endregion
            #region EX2
            //Console.Write("Введите n = ");
            //var n = int.Parse(Console.ReadLine());
            //Console.Write("Введите m = ");
            //var m = int.Parse(Console.ReadLine());
            //int[,] myArray = new int[n, m];
            //var rnd = new Random();
            //var count = 0;
            //for (var i = 0; i < m; i++)
            //{
            //    for (var j = 0; j < n; j++)
            //    {
            //        myArray[j, i] = rnd.Next(0, 10);
            //        Console.Write($"{myArray[j, i]} \t");
            //        if (myArray[j, i] == 7)
            //        {
            //            count++;
            //        }
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine($"Количество числе 7 в данном массиве = {count}");
            #endregion
            #region EX3
            //var n = 15;
            //var m = 5;
            //int[,] myArray = new int[n, m];
            //var rnd = new Random();
            //var list = new List<int> { };
            //for (var i = 0; i < m; i++)
            //{
            //    for (var j = 0; j < n; j++)
            //    {
            //        myArray[j, i] = rnd.Next(0, 100);
            //        Console.Write($"{myArray[j, i]} \t");
            //        if (myArray[j,i] > 0 && myArray[j,i] <= 10)
            //        {
            //            list.Add(myArray[j, i]);
            //        }
            //    }
            //    Console.WriteLine();
            //}
            //var expectedArray = list.ToArray();
            //var multiplication = 1;
            //foreach (var num in expectedArray)
            //{
            //    multiplication *= num;
            //}
            //Console.WriteLine($"Произведение одномерного массива = {multiplication}");

            #endregion

        }
    }
}
