// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] GetMatrix(int mc, int nc)
{
    double[,] matrix = new double[mc, nc];
    Random rnd = new Random();
    double temp;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            temp = rnd.NextDouble() * 10 - 5;
            matrix[i, j] = Math.Round(temp, 1);
        }
    }
    return matrix;
}

void PrintMatrix(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j == 0) Console.Write(" ");
            if (j < array.GetLength(1) - 1) Console.Write($"{array[i, j],4}   ");
            else Console.Write($"{array[i, j],3} ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

PrintMatrix(GetMatrix(m,n));
