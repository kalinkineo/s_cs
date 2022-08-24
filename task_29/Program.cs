// Задача 29: Напишите программу, которая задаёт массив из 8 элементов, заполненный
// псевдослучайными числами и выводит их на экран.

// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

int[] GetAndOutputRandomArray()
{
    int[] array = new int[8];
    for (int i = 0; i < array.Length; i++)
    {
        int num = new Random().Next(0, 1000);
        array[i] = num;

        Console.Write(array[i]);
        if (i != array.Length - 1)
            Console.Write(",");
    }

    Console.Write(" -> ");
    return array;
}

void OutputResult(int[] outpuntArray, int countEven)
{
    Console.Write("[");
    for (int i = 0; i < outpuntArray.Length; i++)
    {
        Console.Write(outpuntArray[i]);
        if (i != outpuntArray.Length - 1)
        {
            Console.Write(",");
        }
        else
        {
            Console.WriteLine("]");
        }
    }
}

Console.Clear();
int[] randomArray = GetAndOutputRandomArray();
OutputResult(randomArray, 8);