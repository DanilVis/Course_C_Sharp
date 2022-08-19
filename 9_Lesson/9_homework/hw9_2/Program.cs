// Задача 2: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumNums(int min, int max)
{
    if (max < min) return 0;
    return SumNums(min, max - 1) + max;
}

Console.WriteLine(SumNums(1, 15));
Console.WriteLine(SumNums(4, 8));