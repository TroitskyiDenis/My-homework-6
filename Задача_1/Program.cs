// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.


using System;
using static System.Console;

Clear();

Write("Введите количество строк  массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Write("Введите количество столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] randomArray = new double[m,n];

void mas(int m, int n)
{
int i,j;
Random rand = new Random();
for (i = 0; i < m; i++)
{
Console.WriteLine();
for (j = 0; j < n; j++)
{
randomArray[i,j] = rand.NextDouble();
Write($"{randomArray[i,j]:F2} ");
}

}

}
mas(m,n);