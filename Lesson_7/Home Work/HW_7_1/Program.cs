// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

void Print(int[,] arr, int M, int N)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);

    for (int i = 0; i < M; i++)
    {
        for (int j = 0; j < N; j++)
            Console.Write($" {arr[i, j]} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] MassNums(int[,] arr, int M, int N)
{
    for (int i = 0; i < M; i++)
    {
        for (int j = 0; j < N; j++)
            arr[i, j] = new Random().Next(-10, 11);
    }
    return arr;
}

void PositionSelection(int[,] Array, int NumberM, int NumberN, int M, int N)
{
    if (NumberM >= M | NumberN >= N | NumberM < 0 | NumberN < 0)
    {
        Console.WriteLine();
        Console.WriteLine("Указанные значения вне диапазона массива!");
    }
    else
    {
        Console.WriteLine();
        Console.Write("Полученное число: ");
        Console.WriteLine(Array[NumberM, NumberN]);
    }
}

Console.WriteLine("Enter amount of rows: ");
int num_row = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter amount of columns: ");
int num_column = int.Parse(Console.ReadLine()!);
int[,] Array = new int[M, N];
MassNums(array, M, N);

Print(array, M, N);

Console.WriteLine();
Console.Write($"Введите номер строки элемента массива от 0 до {M - 1}: ");
int NumberM = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите номер столбца элемента массива от 0 до {N - 1}: ");
int NumberN = Convert.ToInt32(Console.ReadLine());
PositionSelection(Array, NumberM, NumberN, M, N);