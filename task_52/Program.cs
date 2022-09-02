// Задача 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] GetMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    Random rnd = new Random();
    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 10);
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

void PrintAverageColumn(int[,] matrix)
{
    double sum = 0;
    double average;

    Console.Write("Среднее арифметическое каждого столбца: ");

    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum = sum + matrix[i, j];
        }

        average = sum / matrix.GetLength(0);

        Console.Write($"{Math.Round(average, 1)}; ");
        sum = 0;     
    }
}

Random rnd = new Random();
int m = rnd.Next(2, 5);
int n = rnd.Next(2, 5);

int[,] matrixResult = GetMatrix(m, n);
PrintMatrix(matrixResult);

Console.WriteLine("");

PrintAverageColumn(matrixResult);
