// Задача 3: Задайте произвольный массив. Выведете
// его элементы, начиная с конца. Использовать
// рекурсию, не использовать циклы.

// [1, 2, 5, 0, 10, 34] => 34 10 0 5 2 1 

// CreateArrayRndInt создает массив значений в заданных пределах заданного размера 
int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max);
    }
    return array;
}
// PrintArray печатает массив в прямом направлении
void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length - 1) { Console.Write($"{array[i]}"); }
        else { Console.Write($"{array[i]}, "); }
    }
    Console.Write("]");
}
// PrintReverseArray печатает массив в обратном направлении
void PrintReverseArray(int[] array, int count)
{
    if (count == 0) return;

    Console.Write($"{array[count - 1]} ");
    PrintReverseArray(array, count - 1);
}
// InputNumber вводит число из консоли
int InputNumber()
{
    Console.WriteLine("Введите натуральное число:");
    return Convert.ToInt32(Console.ReadLine());
}

int minimum = 1;
int maximum = 100;

int count = InputNumber();
while (count < 0)
{
    Console.WriteLine("Число не должно быть отрицательным!");
    count = InputNumber();
}

int[] arrayMain = CreateArrayRndInt(count, minimum, maximum);
PrintArray(arrayMain);
Console.Write(" => ");
PrintReverseArray(arrayMain, arrayMain.Length);
Console.WriteLine();