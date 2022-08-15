// Задача 45: Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного
// копирования.

int[] CopyArray (int[] array)
{
    int[] copyArr = new int[array.Length];

    for (int i = 0; i < copyArr.Length; i++)
    {
        copyArr[i] = array[i];
    }
    return copyArr;
}