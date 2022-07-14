// Задача 7. Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает последнюю цифру
// этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

Console.WriteLine("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if ((99 < num) && (num < 1000)) {
    int lastDigit = num % 10;
    Console.WriteLine(lastDigit);
}
else {
    Console.WriteLine("Ошибка! Необходимо ввести трехзначное число");
}

