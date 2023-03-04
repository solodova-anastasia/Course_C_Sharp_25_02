// See https://aka.ms/new-console-template for more information
//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
//4 -> да
//-3 -> нет
//7 -> нет

Console.WriteLine("Введите число: ");
string s_a = Console.ReadLine()!;
int a = int.Parse(s_a);
if (a%2 == 0) Console.Write(a+" - число чётное");
else Console.Write(a+" - число нечётное");

//Console.WriteLine("Hello, World!");
