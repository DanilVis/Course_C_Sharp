// Задача 1: Задайте значения M и N. Напишите программу, которая 
// выведет все чётные натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> ""2, 4""
// M = 4; N = 8. -> ""4, 6, 8""

void EvenNums(int min, int max)
{
    if (max % 2 == 1) max = max - 1;

    if (max < min) return;
    EvenNums(min, max - 2);
    Console.Write($"{max} ");
}

EvenNums(1, 5);
Console.WriteLine();
EvenNums(4, 8);
Console.WriteLine();
EvenNums(3, 20);