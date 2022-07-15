﻿// Задача 17. Напишите программу, которая принимает на вход координаты точки (X и Y),
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости,
// в которой находится эта точка. 

// if (x > 0 && y > 0)
//     Console.WriteLine("Первая четверть ");

// else if (x < 0 && y > 0)
//     Console.WriteLine("Вторая четверть ");

// else if (x < 0 && y < 0)
//     Console.WriteLine("Третья четверть ");   

// if (x > 0 && y < 0)
//     Console.WriteLine("Четвертая четверть "); 
// else Console.WriteLine("Введены некорректные данные "); 

Console.WriteLine("Введите координаты точки X: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки Y: ");
int y = Convert.ToInt32(Console.ReadLine());

string Quarter(int xc, int yc)
{
    if (xc > 0 && yc > 0) return "Первая четверть ";
    if (xc < 0 && yc > 0) return "Вторая четверть";
    if (xc < 0 && yc < 0) return "Третья четверть ";   
    if (xc > 0 && yc < 0) return "Четвертая четверть"; 

    return "Введены некорректные данные "; 
}

string result = Quarter(x, y);
Console.WriteLine(result);