//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
//стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 26
//[-4, -6, 4, 67] -> 0

void Print(int[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
        Console.Write($"{arr[i]} ");
    Console.WriteLine();
}

int[] MassNums(int size, int from, int to)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
        arr[i] = new Random().Next(from, to);
    return arr;
}

void SumPos(int[] arr)
{
    int even_pos;
    even_pos = 0;

    for (int i = 0; i < arr.Length; i+=2)
    {
       even_pos += arr[i];
    }
    Console.WriteLine($"Сумма чисел, стоящих на нечётных позициях: {even_pos}");
} 


int num = int.Parse(Console.ReadLine()!);
int start = int.Parse(Console.ReadLine()!);
int stop = int.Parse(Console.ReadLine()!);

int[] mass = MassNums(num, start, stop);
Print(mass);
SumPos(mass);
