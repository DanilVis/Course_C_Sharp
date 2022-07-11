// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Write a natural number:");
int N = int.Parse(Console.ReadLine());
int i = 2;

if (N > 1)
{
    while (i <= N)
    {
        Console.WriteLine(i);
        i = i + 2;
    }
}
else Console.WriteLine("There's no even natural numbers");