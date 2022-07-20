// Задача 13: Напишите программу, которая выводит третью цифру
// заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num <= 99)
{
    Console.WriteLine("У заданного числа нет третьей цифры");
}
else
{
    Console.WriteLine($"Третья цифра заданного числа: {SearchThirddDigit(num)}");
}

int SearchThirddDigit(int numc)
{
    while (numc > 1000)
    {
        numc = numc / 10;
    }

    return numc % 10;
}
