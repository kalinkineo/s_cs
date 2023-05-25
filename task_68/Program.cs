//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
//Даны два неотрицательных числа m и n.

//m = 3, n = 2 -> A(m,n) = 29

int M = AskNumber("M"); 
int N = AskNumber("N"); 
 
int AckermannFunction(int M, int N) 
{ 
    if (M == 0)
        return N + 1; 
    if (M != 0 && N == 0)
        return AckermannFunction(M - 1, 1); 
    if (M > 0 && N > 0)
        return AckermannFunction(M - 1, AckermannFunction(M, N - 1)); 
    return AckermannFunction(M, N); 
} 
 
Console.WriteLine($"Функция Аккермана для чисел A({M},{N}) = {AckermannFunction(M, N)}"); 
 
int AskNumber(string name) 
{ 
    Console.Write($"Введите число {name}: "); 
    return int.Parse(Console.ReadLine()); 
}
