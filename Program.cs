using System;

namespace Задание_4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("<<<Создание матрицы>>>");
            Console.WriteLine("Введите количество строк в матрице:");

            int y = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите количество строк в матрице:");

            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите максимальное значение числа в матрице:");

            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[y, x];

            Random rnd = new Random();
            int sum = 0;
            Console.WriteLine();


            for (int i = 0; i < y; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    matrix[i, j] = rnd.Next(n);                                 //Заполнение матрицы
                    Console.Write($"{matrix[i, j], 4} ");                       //Вывод каждого элемента матрицы
                    sum += matrix[i, j];                                        //Суммирование каждого элемента
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine($"Сумма всех элементов матрицы = {sum}");

            Console.ReadKey();
        }
    }
}
