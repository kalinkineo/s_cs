// Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if ((99 < num) && (num < 1000)) {
    int firstDigit = num / 100;
    int lastDigit = num % 10;
    Console.WriteLine($"Вторая цифра введеного числа: {(num - firstDigit*100 - lastDigit)/10}");
}
else {
    Console.WriteLine("Ошибка! Необходимо ввести трехзначное число!");
}