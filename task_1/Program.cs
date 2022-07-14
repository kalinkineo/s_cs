// Задача 1. Напишите программу, которая на вход принимает два
// числа и проверяет, является ли первое число квадратом
// второго.
// Пример:
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3 b = 9 -> нет

Console.Write("Введите первое число: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.Write("Ввдите второе число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

if (num1 * num1 == num)
    Console.WriteLine("Первое число является квадратом второго");
else 
    Console.WriteLine("Первое число не является квадратом второго");

