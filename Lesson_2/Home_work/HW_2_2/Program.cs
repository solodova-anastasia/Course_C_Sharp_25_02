// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

int TakeNum(int num)
{
if (num % 100 == 0)
Console.WriteLine(num);
else 
return num % 10;
}


int result = TakeNum(new Random().Next(100, 1000));
Console.WriteLine(result);



//Console.WriteLine("Hello, World!");