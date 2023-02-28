// See https://aka.ms/new-console-template for more information
// 1. Напишите программу, которая на вход принимает два числа и проверяет,
// является ли первое число квадратом второго.


Console.WriteLine("Введите число: ");
string s_a = Console.ReadLine()!;
string s_b = Console.ReadLine()!;
int a = int.Parse(s_a);
int b = int.Parse(s_b);

if (a == b * b) Console.WriteLine("Yes");
else Console.WriteLine("No");

//Console.WriteLine("Hello, World!");
