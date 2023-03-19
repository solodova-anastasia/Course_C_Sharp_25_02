// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int EnterNumber(int num)
{
    int count = 0;

    for (int i = 0; i <= num; i++)
    {
        Console.Write($"Число {i}: ");
        int a = int.Parse(Console.ReadLine()!);
        if (a > 0) count++;
    }
    return count;
}

Console.Write("Сколько чисел будете вводить?");
int a = int.Parse(Console.ReadLine()!);
int result = EnterNumber(a-1);
Console.WriteLine($"Пользователь ввёл {result} число(а) больше 0.");
