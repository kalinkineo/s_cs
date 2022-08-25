// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

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

int GetCountEvenNumber(int[] tempArray)
{
    int cen = 0;

    for (int i = 0; i < tempArray.Length; i++)
    {
        if ((tempArray[i] % 2) == 0)
        {
            cen = cen + 1;
        }
    }

    return cen;
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

int[] newArray = CreateArrayRndInd(num, 100, 999);
int countEvenNumber = GetCountEvenNumber(newArray);
PrintArray(newArray);
Console.WriteLine($" -> {countEvenNumber}");