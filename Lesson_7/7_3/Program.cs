﻿// 3. Задайте двумерный массив. Найдите сумму элементов главной диагонали.
// https://4apple.org/summa-diagonalnyh-jelementov-matricy/
// https://ru.wikipedia.org/wiki/%D0%93%D0%BB%D0%B0%D0%B2%D0%BD%D0%B0%D1%8F_%D0%B4%D0%B8%D0%B0%D0%B3%D0%BE%D0%BD%D0%B0%D0%BB%D1%8C

void Print(int[,] arr)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
            Console.Write($" {arr[i, j]} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] MassNums(int row, int column, int from, int to)
{
    int[,] arr = new int[row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            arr[i, j] = new Random().Next(from, to);

    return arr;
}

int SumMass (int [,] array)
{
  int sumarray = 0;
  for (int i = 0; i < array.GetLength(0); i = i++)
      for (int j = 0; j < array.GetLength(1); j++)
    {
      if (i == j) sumarray = sumarray + array[i, j];
    }
  return sumarray;
}

int num_row = int.Parse(Console.ReadLine()!);
int num_column = int.Parse(Console.ReadLine()!);
int start = int.Parse(Console.ReadLine()!);
int stop = int.Parse(Console.ReadLine()!);

int[,] mass = MassNums(num_row, num_column, start, stop);
Print(mass);
int sum = SumMass(mass);
Console.WriteLine($"Sum: {sum}");