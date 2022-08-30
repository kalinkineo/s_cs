// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите значение b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите значение k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите значение b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите значение k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

double[] PointIntersectionLines;
PointIntersectionLines = PointIntersectionTwoLines(b1, k1, b2, k2);
PrintArray(PointIntersectionLines);

double[] PointIntersectionTwoLines(double b1c, double k1c, double b2c, double k2c)
{
    double x = 0;
    double y = 0;
    double[] pointIntersection = new double[2];

    x = ((b2c - b1c) / (k1c - k2c));
    y = (k1c * x + b1c);

    pointIntersection[0] = x;
    pointIntersection[1] = y;

    return pointIntersection;
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0) Console.Write("[");
        if (i < array.Length - 1) Console.Write(array[i] + ", ");
        else Console.Write(array[i] + "]");
    }
}
