﻿// 3. Напишите программу, которая принимает на вход число и проверяет,
// кратно ли оно одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

void Find(int num)
{
if (num % 7 == 0 && num % 23 == 0)
Console.WriteLine("да");
else Console.WriteLine("нет");
}
Find(int.Parse(Console.ReadLine()!));



//Console.WriteLine("Hello, World!");