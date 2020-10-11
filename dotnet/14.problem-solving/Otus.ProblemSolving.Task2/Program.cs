﻿/*
Новогодняя ёлочка программиста состоит из цифр.
На первой строке записана высота ёлочки -
натуральное число от 1 до 100.
Далее на N строчках зарисована сама ёлочка,
сначала 1 цифра, потом 2, на последней строке - N цифр через пробел.
В начале и в конце каждой строки могут быть пробелы, чтобы ёлочка получилась красивой.

Гирляндой называется последовательность цифр, которую можно получить спускаясь от верхушки
ёлки до её подножья, каждый раз смещаясь либо влево-вниз, либо вправо вниз.

Найти гирлянду с максимальной суммой цифр.

Вывести одно число - максимальную сумму найденной гирлянды.
 */
using System;

namespace Otus.ProblemSolving.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); 
            int[,] m = new int[n, n];
            
            for (int i = 0; i < n; i++)
            {
                var values = Console.ReadLine().Trim().Split(' ');
                
                for (int j = 0; j <= i; j++)
                {
                    m[i, j] = int.Parse(values[j]);
                }
            }

            for (int i = n - 2; i >= 0; i--)
            {
                for (int j = 0; j <= i; j++)
                {
                    m[i, j] += Math.Max(m[i + 1, j], m[i + 1, j + 1]);
                }
            }
            
            Console.WriteLine(m[0, 0]);
        }
    }
}