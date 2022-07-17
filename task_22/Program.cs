// Задача 22: Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу квадратов чисел от 1 до N. 5 -> 1, 4, 9, 16, 25. 2 -> 1,4 

Console.WriteLine("Введите целое положительное число: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("---------------------");
Console.WriteLine("Число       Квадрат");
Console.WriteLine("---------------------");

WriteSquareTable(n);

Console.WriteLine("---------------------");

void WriteSquareTable(int nc)
{
    int i = 1;

    while (i <= nc){
        Console.WriteLine($"| {i}     |    {i*i}  "); 
        i++;
    }
}