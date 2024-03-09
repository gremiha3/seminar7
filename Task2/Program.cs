// Задача 2: Напишите программу вычисления функции
// Аккермана с помощью рекурсии. Даны два
// неотрицательных числа m и n. 

// m = 2, n = 3 -> A(m,n) = 29

int AckermanFunc(int n, int m)
{
    if (n == 0)
    { return m + 1; }
    if (m == 0)
    { return AckermanFunc(n - 1, 1); }
    else
    { return AckermanFunc(n - 1, AckermanFunc(n, m - 1)); }
}

int InputNumber(string str)
{
    Console.WriteLine($"Введите натуральное число: {str}");
    return Convert.ToInt32(Console.ReadLine());
}



int M = InputNumber("M");
while (M < 0)
{
    Console.WriteLine("Число не должно быть отрицательным!");
    M = InputNumber("M");
}

int N = InputNumber("N");
while (N < 0)
{
    Console.WriteLine("Число не должно быть отрицательным!");
    N = InputNumber("N");
}

Console.WriteLine();

Console.Write($"M = {M}; N = {N} -> A(m,n) = {AckermanFunc(N, M)}");

Console.WriteLine();