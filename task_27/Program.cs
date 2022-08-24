// Задача 27: Напишите программу, которая принимает на вход число
// и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число А");
int num = Convert.ToInt32(Console.ReadLine());

int GetSumNum(int number)
{
    int result = 0;
    int ost = 0;
  
    while(number > 0)
    {
        ost = number % 10;
        result = result + ost;
        number = number / 10;
    }

    return result;
}

int sumNum = GetSumNum(num);

Console.Clear();
Console.WriteLine($"{num} -> = {sumNum}");