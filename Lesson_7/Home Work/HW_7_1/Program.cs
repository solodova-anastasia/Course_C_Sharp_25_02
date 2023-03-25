// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int[,] FillArray(int[,] Array, int M, int N)
{
    for (int i = 0; i < M; i++)
    {
        for (int j = 0; j < N; j++)
        {
            Array[i, j] = new Random().Next(-10, 11);
        }
    }
    return (Array);
}

void PrintArray(int[,] Array, int M, int N)
{
    {
        for (int k = 0; k < M; k++)
        {
            for (int l = 0; l < N; l++)
            {
                Console.Write(Array[k, l] + " ");
            }
            Console.WriteLine();
        }
    }
}

void PositionSelection(int[,] Array, int NumberM, int NumberN, int M, int N)
{
    if (NumberM >= M | NumberN >= N | NumberM < 0 | NumberN < 0)
    {
        Console.WriteLine();
        Console.WriteLine("Указанные значения вне диапазона массива");
    }
    else
    {
        Console.WriteLine();
        Console.Write("Полученное число: ");
        Console.WriteLine(Array[NumberM, NumberN]);
    }
}

Console.Write("Введите колличество строк двумерного массива M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите колличество столбцов двумерного массива N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int[,] Array = new int[M, N];
FillArray(Array, M, N);

PrintArray(Array, M, N);

Console.WriteLine();
Console.Write($"Введите номер строки элемента массива от 0 до {M - 1}: ");
int NumberM = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите номер столбца элемента массива от 0 до {N - 1}: ");
int NumberN = Convert.ToInt32(Console.ReadLine());
PositionSelection(Array, NumberM, NumberN, M, N);
