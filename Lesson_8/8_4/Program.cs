// Задача 1: Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
// Например:
// 1472
// 5923
// 8424
// 5267
// Наименьший элемент - 1, на выходе получим следующий массив:
// 923
// 424
// 267

void Print(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
            Console.Write($" {arr[i, j],3} ");
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

int[] MinElem(int[,] arr, int max_num)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);
    int min_num = arr[0, 0];
    int[] indexes = new int[2];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
            if (min_num > arr[i, j])
            {
                min_num = arr[i, j];
                indexes[0] = i;
                indexes[1] = j;
            }
    }
    Console.WriteLine(arr[indexes[0], indexes[1]]);
    return indexes;
}

void WithoutRowColumns(int[,] arr, int[] m_indexes)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
            if (m_indexes[0] == i || m_indexes[1] == j) continue;
            else Console.WriteLine($"{arr[i, j],3}");
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.Write("Enter the number of rows: ");
int row_num = int.Parse(Console.ReadLine()!);
Console.Write("Enter the number of columns: ");
int column_num = int.Parse(Console.ReadLine()!);
Console.Write("Enter the minimum number of matrix: ");
int start = int.Parse(Console.ReadLine()!);
Console.Write("Enter the maximum number of matrix: ");
int stop = int.Parse(Console.ReadLine()!);

int[,] mass = MassNums(row_num, column_num, start, stop);
Print(mass);

int[] muss_sum = MinElem(mass);
WithoutRowColumns(muss_sum);