﻿// Задача 15: Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите цифру обозначающую день недели [1-7]: ");
int day = Convert.ToInt32(Console.ReadLine());

if (day < 1 || day > 7)
    Console.WriteLine("Ошибка! Введите цифру в диапазоне от 1 до 7");
else
    Console.WriteLine(SearchHoliDay(day));

string SearchHoliDay(int dayc)
{
    if (dayc > 5)
        return "Это выходной день";
    return "Этот день не является выходным";
}
