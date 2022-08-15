// Задача 44: Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

Console.Clear();

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());


void Fibon(int numNew)
{
    int num1 = 0;
    int num2 = 1;
    Console.Write($"{num1} {num2} ");
    for (int i = 0; i < numNew - 2; i++)
    {
        int nextEl = num1 + num2;
        Console.Write($"{nextEl} ");
        num1 = num2;
        num2 = nextEl;
    }
}

Fibon(num);