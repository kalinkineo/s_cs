// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

Console.Clear();

Console.WriteLine("Введите число1: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число2: ");
int numB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число3: ");
int numC = Convert.ToInt32(Console.ReadLine());


bool Triangle(int num1, int num2, int num3)
{
    return num1 < (num2 + num3) && num2 < (num1 + num3) && num3 < (num2 + num1);
}

bool result = Triangle(numA, numB, numC);
Console.WriteLine(result? "Является тругольником" : "Не может быть треугольником");