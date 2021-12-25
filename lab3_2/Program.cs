using System;

namespace lab3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region задание 1 линейный массив
            Console.WriteLine("Введите размер массива");
            var n = int.Parse(Console.ReadLine());
            var rnd = new Random();
            int[] myArray = new int[n];
            int module = 10;
            int lessThanModuleSum = 0;
            for (int i = 0; i < n; i++)
            {
                myArray[i] = rnd.Next(-40, 40);
                Console.Write($"{myArray[i]} ");
                if (myArray[i] < 10 && myArray[i] > -10)
                {
                    lessThanModuleSum += myArray[i];
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Сумаа чисел меньших по модулю {module} = {lessThanModuleSum} ");
            for (int i = 0; i < n - 1; i++)
            {
                if (myArray[i] > myArray[i + 1])
                {
                    Console.WriteLine($"Значение индекса {i} больше значение следующего элемента");
                }
            }
            Console.WriteLine();
            for (int i = 1; i < n - 1; i++)
            {
                if (Math.Abs(myArray[i]) == Math.Abs(myArray[i + 1]) || Math.Abs(myArray[i]) == Math.Abs(myArray[i - 1]))
                {
                    Console.WriteLine($"{myArray[i]} с индексом {i} имеет пару ");
                }
            }
            #endregion
            #region задание 1 многомерный 

            Console.WriteLine("Введите размер n");
            var n = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите размер m");
            var m = int.Parse(Console.ReadLine());
            var rnd = new Random();
            int[,] myArray = new int[n, m];
            for (var i = 0; i < n; i++)
            {
                for (var j = 0; j < m; j++)
                {
                    myArray[i, j] = rnd.Next(1, 20);
                    Console.Write($"{myArray[i, j]}\t");
                }
                Console.WriteLine();
            }
            var odd = 0;
            var even = 0;
            for (var i = 0; i < n; i++)
            {
                for (var j = 0; j < m; j++)
                {
                    if (myArray[i, j] % 2 == 0)
                    {
                        even++;
                    }
                    else if (myArray[i, j] % 2 == 1)
                    {
                        odd++;
                    }
                }
            }
            Console.WriteLine($"Количество четных числе в массиве {even} , а нечетных {odd}");
            #endregion

            #region задание 2 многомерный 
            var rnd = new Random();
            int[,] mainArray = new int[5, 10];
            var myList = new List<int> { };
            for (var i = 0; i < 5; i++)
            {
                for (var j = 0; j < 10; j++)
                {
                    mainArray[i, j] = rnd.Next(1, 40);
                    Console.Write($"{mainArray[i, j]}\t");
                    if (mainArray[i, j] >= 1 && mainArray[i, j] <= 20)
                    {
                        myList.Add(mainArray[i, j]);
                    }
                }
                Console.WriteLine();
            }
            var myArray = myList.ToArray();
            int myArraySum = 0;
            for (var i = 0; i < myArray.Length; i++)
            {
                myArraySum += myArray[i];
            }
            Console.WriteLine(myArraySum);
            Console.WriteLine(myArray.Length);
            double result = (double)myArraySum / myArray.Length;
            Console.WriteLine($"{result}");
            #endregion
        }
    }
}
