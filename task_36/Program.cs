﻿// Задача 36: Задайте одномерный массив,
// заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] CreateArrayRndInd(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

int GetSumOddPos(int[] array_num)
{
    int sum = 0;

    for (int i = 1; i < array_num.Length; i++)
    {
        sum = sum + array_num[i];
        i++;
    }
    return sum;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0) Console.Write("[");
        if (i < array.Length - 1) Console.Write(array[i] + ", ");
        else Console.Write(array[i] + "]");
    }
}

Console.Clear();

Console.WriteLine("Введите количество элементов массива:");
int num = Convert.ToInt32(Console.ReadLine());

int[] arrayRndInd = CreateArrayRndInd(num, -20, 20);
int sumOddPos = GetSumOddPos(arrayRndInd);

PrintArray(arrayRndInd);
Console.WriteLine($" -> {sumOddPos}");