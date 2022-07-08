// 1. Напишите программу, которая на вход принимает два числа и проверяет,
//    является ли первое число квадратом второго.

Console.WriteLine("Write the first number: ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Write the second number: ");
int b = int.Parse(Console.ReadLine());

if (a == b * b)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}