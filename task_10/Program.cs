// Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if ((99 < num) && (num < 1000))
{
    Console.WriteLine($"Вторая цифра введеного числа: {SearchSecondDigit(num)}");
}
else
{
    Console.WriteLine("Ошибка! Необходимо ввести трехзначное число!");
}

int SearchSecondDigit(int numc)
{
    int firstDigit = numc / 100;
    int lastDigit = numc % 10;

    return (numc - firstDigit * 100 - lastDigit) / 10;
}