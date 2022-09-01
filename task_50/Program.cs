// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого числа в массиве нет

int[,] GetMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 100);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j == 0) Console.Write("[");
            if (j < array.GetLength(1) - 1)
                Console.Write($"{array[i, j],3},");
            else
                Console.Write($"{array[i, j],3}]");
        }
        Console.WriteLine();
    }
}

void PrintNumberSearch(int[,] matrix, int i, int j)
{
    if ((i >= matrix.GetLength(0))||(j >= matrix.GetLength(1)) )
        Console.WriteLine($"Такого числа в массиве нет");
    else
        Console.WriteLine($"Число -> {matrix[i,j]}");
}

Random rnd = new Random();
int m = rnd.Next(2, 10);
int n = rnd.Next(2, 10);

int[,] matrixResult = GetMatrix(m, n);
PrintMatrix(matrixResult);

Console.WriteLine("");
Console.Write("Введите номер строки c 0: ");
int array_i = Convert.ToInt32(Console.ReadLine());


Console.Write("Введите номер столбца c 0: ");
int array_j = Convert.ToInt32(Console.ReadLine());

PrintNumberSearch(matrixResult, array_i, array_j);


