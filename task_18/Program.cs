﻿// Задача 18: Напишите программу, которая по заданному номеру четверти,
//  показывает диапазон возможных координат точек в этой четверти (x и y). 

Console.WriteLine("Введите номер четверти: ");
int qua = Convert.ToInt32(Console.ReadLine());

string Quarter(int quaC)
{
    if (quaC == 1) return "x > 0 && y > 0";
    if (quaC == 2) return "x < 0 && y > 0";
    if (quaC == 3) return "x < 0 && y < 0 ";   
    if (quaC == 4) return "x > 0 && y < 0"; 

    return "Введены некорректные данные "; 
}

string result = Quarter(qua);
Console.WriteLine(result);