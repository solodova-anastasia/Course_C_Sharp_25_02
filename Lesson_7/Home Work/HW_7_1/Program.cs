// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

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

string Position(int[,] array, int num);
int pos1 = 0;
int pos2 = 0;
{
    if (array[i, j] == num)
        pos1 = i + 1 && pos2 = j + 1;
    Console.WriteLine($"{num}");
}
 Console.WriteLine("такого элемента в массиве не существует");

Console.WriteLine("Enter amount of rows: ");
int num_row = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter amount of columns: ");
int num_column = int.Parse(Console.ReadLine()!);
int start = int.Parse(Console.ReadLine()!);
int stop = int.Parse(Console.ReadLine()!);
int pos1 = int.Parse(Console.ReadLine()!);
int pos2 = int.Parse(Console.ReadLine()!);

int[,] mass = MassNums(num_row, num_column, start, stop, pos1, pos2);
Print(mass);
int num = int.Parse(Console.ReadLine()!);
string sum = Position(mass, num);