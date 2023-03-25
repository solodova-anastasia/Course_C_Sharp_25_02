// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// Метод заполнения массива:
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

// Метод вывода массивана экран:
void PrintArray(int[,] Array, int M, int N)
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

void Average(int[,] array, int M, int N)
{
    int row = array.GetLength(0);
    int column = array.GetLength(1);

    for (int j = 0; j < array.GetLength(1); j++)

    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum = sum + array[i, j];
        }
        sum = sum / row;
         Console.WriteLine();
        Console.WriteLine($"Среднее арифметическое элементов в столбце {j+1}: {sum}");
    }
    Console.ReadLine();
}

// Ввод диапазона массива:
Console.Write("Введите колличество строк двумерного массива M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите колличество столбцов двумерного массива N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int[,] Array = new int[M, N];
FillArray(Array, M, N);

// Передача данных в метод вывода на экран:
PrintArray(Array, M, N);
Average(Array, M, N);
