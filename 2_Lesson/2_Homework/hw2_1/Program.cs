//Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

void SecondNum(int number)
{
    int s_n = number / 10 - number / 100 * 10;
    Console.WriteLine($"The second number of {number} is {s_n}");
}

Console.WriteLine("Write a three-digit number:");
int a =int.Parse(Console.ReadLine());

SecondNum(a);