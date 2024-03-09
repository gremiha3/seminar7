// Задача 1: Задайте значения M и N. Напишите
// программу, которая выведет все натуральные числа
// в промежутке от M до N. Использовать рекурсию, не
// использовать циклы.

// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

void ListNumbers(int M, int N)
{
    if (M == N)
    {
        if (N >= 0) Console.Write($"{N}, ");
        return;
    }
    if (M < N)
    {
        ListNumbers(M, N - 1);
        if (N >= 0) Console.Write($"{N}, ");
    }
    if (M > N)
    {
        ListNumbers(M - 1, N);
        if (N >= 0) Console.Write($"{M}, ");
    }
}


Console.WriteLine("Введите число M:");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N:");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

Console.Write($"M = {M}; N = {N} -> \"");
ListNumbers(M, N);
Console.WriteLine("\"");
