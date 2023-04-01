// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все чётные
// натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

void EvenNumbers(int M, int N)
{
    if (M > N || M == 0 || N == 0) return;
    if (M % 2 == 0)
    {
        Console.Write($"{M}; ");
    }
    EvenNumbers(M + 1, N);
}


Console.WriteLine("Введите целое положительное число M");
int num_1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите целое положительное число N");
int num_2 = int.Parse(Console.ReadLine()!);

EvenNumbers(num_1, num_2);