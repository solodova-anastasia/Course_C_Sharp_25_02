// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void Intersection(double b1, double k1, double b2, double k2)
{
    double k_sub = k1 - k2;
    if (k_sub != 0)
    {
        double x = (b2 - b1) / (k1 - k2);
        double y = k1 * x + b1;
        Console.WriteLine($"Точки пересечения: {x}, {y}");
    }
    else if (k1 == k2 && b1 == b2)
        Console.WriteLine("Существует бесконечное количество точек пересечения");
    else
        Console.WriteLine("Прямые параллельны, точек пересечения не существует");
}

Console.Write("Введите значение b1: ");
int b1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите значение k1: ");
int k1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите значение b2: ");
int b2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите значение k2: ");
int k2 = int.Parse(Console.ReadLine()!);
Intersection(b1, k1, b1, k2);
