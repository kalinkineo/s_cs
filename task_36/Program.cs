// Задача 36: Задайте одномерный массив,
// заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] GetArray(int count)
{
    int[] array = new int[count];
    
    for (int i = 0; i < array.Length; i++)
    {
        count = new Random().Next(-100, 100);
        array[i] = count;
    }

    return array;
}

int GetSumOddPos(int[] array_num)
{
    int sum = 0;

    for (int i = 0; i < array_num.Length; i++)
    {
        sum = sum + array_num[i];
        i++;
    }
    return sum;
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

int[] randomArray = GetArray(num);
int sumOddPos = GetSumOddPos(randomArray);

OutputResult(randomArray, sumOddPos);