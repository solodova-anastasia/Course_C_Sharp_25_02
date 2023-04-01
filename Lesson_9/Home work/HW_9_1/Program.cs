// Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

int SumNum(int M, int N)
{
    if (M > N || M < 0 || N < 0) return 0;
    if (M == N) return N;
    return SumNum(M + 1, N) + M;
}

Console.WriteLine("Введите целое положительное число M");
int num_1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите целое положительное число N");
int num_2 = int.Parse(Console.ReadLine()!);

Console.WriteLine(SumNum(num_1, num_2));
