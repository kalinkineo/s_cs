// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int[] array = new int[20];

for (int i = 0; i < array.Length; i++)
{
    int num = new Random().Next(0, 2);
    array[i] = num;
}

Console.Write("[");
for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i]);
    if (i != array.Length - 1)
        Console.Write(",");
}

Console.Write("]");