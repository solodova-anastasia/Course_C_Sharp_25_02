// Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

void Sum(int M, int N)
{
    if (M > N || M == N || M < 0 || N < 0) return 0;
    ValuesSet(M, N - 1);
    Console.Write($"{N} ");
}

int num_1 = int.Parse(Console.ReadLine()!);
int num_2 = int.Parse(Console.ReadLine()!);
Sum(num);

