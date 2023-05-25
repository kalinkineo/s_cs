﻿// Задача 64: Задайте значение N. Напишите программу,
// которая выведет все натуральные числа в промежутке от N до 1.
// Выполнить с помощью рекурсии.

//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


int N = AskNumber("N"); 
Console.WriteLine($"{PrintNumber(N)}"); 
 
string PrintNumber(int N) 
{ 
    if (N < 1)  
    { 
        Console.Write("Неверный ввод"); 
        return ""; 
    } 

    if (N == 1)
        return N.ToString(); 
    else
        return "" + N.ToString() + ", " + PrintNumber(--N); 
 
} 
 
int AskNumber(string name) 
{ 
    Console.Write($"Введите число {name}: "); 
    return int.Parse(Console.ReadLine()); 
}
