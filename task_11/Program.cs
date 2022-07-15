// Задача 11. Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int num = new Random().Next(10, 1000);
int result = SecondDelete(num);

Console.WriteLine($"Рандомное число:{num}  Результат: {result} ");

int SecondDelete(int num){

    int firstDigit = num / 100;
    int lastDigit = num % 10;

    return result = firstDigit * 10 + lastDigit;
}







