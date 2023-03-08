//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12
//ЧЕРНОВИК!!
int SumNum(int num)
{
    int all_sum = 0;
    for (int i = 1; i <= num; i++)
        all_sum += i;
    
    return all_sum;
}

int A = int.Parse(Console.ReadLine()!);
int result = SumNum(A);
Console.WriteLine(result);