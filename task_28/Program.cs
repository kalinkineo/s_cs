// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120


Console.Clear();
Console.WriteLine("Введи число:");

int a = Convert.ToInt32(Console.ReadLine());

int GetMulti(int numb)
{
    int res = 1;
    for (int i = 1; i <= numb; i++)
    {
        res = res * i;
    }
    return res;
}

int sum = GetMulti(a);
Console.WriteLine($"произведение чисел от 1 до {a} = {sum}");