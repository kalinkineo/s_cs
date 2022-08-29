// Задача 45: Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного
// копирования.

Console.Clear();

int [] array = CreateArrayRndInd(8,1,9);
int [] newArray = CopyArray(array);



int[] CopyArray (int[] array)
{
    int[] copyArr = new int[array.Length];

    for (int i = 0; i < copyArr.Length; i++)
    {
        copyArr[i] = array[i];
    }
    return copyArr;
}

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