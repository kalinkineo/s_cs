// Задача 4: Напишите программу, которая принимает на вход
// три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите первое целое число: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе целое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье целое число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int temp = 0;

if ((num  >= num1 ) && (num >= num2))
    temp = num;
if ((num1 >= num ) && (num1 >= num2)) 
    temp = num1;    
if ((num2  >= num ) && (num2 >= num1))
    temp = num2;

Console.WriteLine($"Максимальное число: {temp} ");