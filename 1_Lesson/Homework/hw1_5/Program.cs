// Задача 7: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.

Console.WriteLine("Write a three-digit number:");
int a = int.Parse(Console.ReadLine());

if(a<100) Console.WriteLine("Wrong number");
else if(a>999) Console.WriteLine("Wrong number");
else Console.WriteLine(a % 10);