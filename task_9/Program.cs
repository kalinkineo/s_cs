// Задача 9. Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

int num = new Random().Next(10, 100);

int MaxDigit(int num){
    int firstDigit = num / 10;
    int secondDigit = num % 10;

    if (firstDigit == secondDigit) return 0;
    if (firstDigit > secondDigit) return firstDigit;
    return secondDigit;
}

int maxDigit = MaxDigit(num);

if (maxDigit == 0)
    Console.WriteLine("Цифры одинаковые");
else 
    Console.WriteLine($" {num} -> {maxDigit}");