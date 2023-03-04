//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

Console.WriteLine("Введите 3 числa: ");
string s_a = Console.ReadLine()!;
string s_b = Console.ReadLine()!;
string s_c = Console.ReadLine()!;
int a = int.Parse(s_a);
int b = int.Parse(s_b);
int c = int.Parse(s_c);
if (a > b)
{
    if (a > c)
    {
        Console.Write(a);
    }
    else
    {
        Console.Write(c);
    }
}
else if (b > c)
{
    Console.Write(b);
}
else
{
    Console.Write(c);
}
