// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

//Console.Clear();
int numPositive = 0;
NumPositiveNumbers();
Console.Write($"Количесвто позитивных чисел = {numPositive} ");

void NumPositiveNumbers()
{
    Console.WriteLine("Введите новое число");
    Console.WriteLine("Для завершения ввода и вывода результата введите: quit ");
    string str = Console.ReadLine();

    if (str == "quit")
        return;

    int num = Convert.ToInt32(str);
    if (num > 0)
        numPositive++;

    NumPositiveNumbers();
}


