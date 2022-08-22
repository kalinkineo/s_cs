// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] GetArray(int count)
{
    int[] array = new int[count];

    for (int i = 0; i < array.Length; i++)
    {
        count = new Random().Next(100, 999);
        array[i] = count;
    }

    return array;
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

void OutputResult(int[] outpuntArray, int countEven)
{
    Console.Write("{");
    for (int i = 0; i < outpuntArray.Length; i++)
    {
        Console.Write(outpuntArray[i]);
        if (i != outpuntArray.Length - 1)
        {
            Console.Write(",");
        }
        else
        {
            Console.Write("}");
        }
    }

    Console.WriteLine($" -> {countEven}");
}

Console.Clear();

Console.WriteLine("Введите количество элементов массива:");
int num = Convert.ToInt32(Console.ReadLine());

int[] newArray = GetArray(num);
int countEvenNumber = GetCountEvenNumber(newArray);
OutputResult(newArray, countEvenNumber);