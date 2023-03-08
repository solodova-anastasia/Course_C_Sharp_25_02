// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// ЧЕРНОВИК!
Console.WriteLine("Введите число A");
Console.WriteLine("Введите число B");
int A = int.Parse(Console.Readline());
int B = int.Parse(Console.Readline());
int result = A;
{
        for (int i = 1; i <= B; i++)
        {
            result = result * A;
        }
    Console.WriteLine("a в степени b = " + result);
}

int A = int.Parse(Console.ReadLine()!);
int result = NumVStepen(A);
Console.WriteLine(result);