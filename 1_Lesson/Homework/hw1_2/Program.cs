//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Write the first number: ");
int a = int.Parse(Console.ReadLine());

Console.Write("Write the second number: ");
int b = int.Parse(Console.ReadLine());

Console.Write("Write the third number: ");
int c = int.Parse(Console.ReadLine());

if (a < b) a = b;

if (a < c) a = c;

Console.WriteLine($"max = {a}");