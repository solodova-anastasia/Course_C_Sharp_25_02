// See https://aka.ms/new-console-template for more information
//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7->max = 7
//a = 2 b = 10->max = 10
//a = -9 b = -3->max = -3

Console.WriteLine("Введите 2 числa: ");
string s_a = Console.ReadLine()!;
string s_b = Console.ReadLine()!;
int a = int.Parse(s_a);
int b = int.Parse(s_b);
if (a > b)
{
    Console.Write(a+" = max", b+" = min");
}
else if (a == b)
{
    Console.Write("a = b");
}
else
{
    Console.Write(a+" = min", b+" = max");
}
