// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArrayRndDouble(int size, int min, int max, int round)
{
    double[] arr = new double[size];
    Random rnd = new Random();
    double temp;

    for (int i = 0; i < arr.Length; i++)
    {
        temp = rnd.NextDouble() * 100;
        arr[i] = Math.Round(temp, round);
    }
    return arr;
}

double SubtractMinFromMax(double[] array_num, int round)
{
    double max = array_num[0];
    double min = array_num[0];

    for (int i = 0; i < array_num.Length; i++)
    {
        if (array_num[i] > max)
        {
            max = array_num[i];
        }

        if (array_num[i] < min)
        {
            min = array_num[i];
        }
    }

    return Math.Round(max - min, round);
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

Console.Clear();

Console.WriteLine("Введите количество элементов массива:");
int num = Convert.ToInt32(Console.ReadLine());

double[] arrayRndDouble = CreateArrayRndDouble(num, -20, 20, 1);
double subtracResult = SubtractMinFromMax(arrayRndDouble, 1);

PrintArray(arrayRndDouble);
Console.WriteLine($" -> {subtracResult}");