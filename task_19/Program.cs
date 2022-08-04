// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число: ");

int num = Convert.ToInt32(Console.ReadLine());

if ((num <= 9999) || (num > 99999))
{
    Console.WriteLine("Ошибка! Введите пятизначное число");
}
else if (searchPolindrom(num))
{
    Console.WriteLine("Число является полиндромом");
}
else
{
    Console.WriteLine("Число не является полиндромом");
}

bool searchPolindrom(int numc)
{
    if ((numc % 10) == (numc / 10000))
    {
        if (((numc % 100) / 10) == ((numc / 1000) % 10))
            return true;
    }
    return false;
}
