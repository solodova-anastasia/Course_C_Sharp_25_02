﻿// See https://aka.ms/new-console-template for more information
//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8

string s_a = Console.ReadLine("Введите число")!;
int a = int.Parse(s_a);
int b = 2;

while (2 <= a)
{
if (a%2 == 0)
{
Console.Write(b+" ");
b++;
}
}


//Console.WriteLine("Hello, World!");