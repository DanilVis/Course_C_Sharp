// Задача 4: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

void Weekend (int number)
{
    if (number == 6 || number == 7)
    Console.WriteLine("It's the weekend");
    else
    Console.WriteLine("It's not the weekend");
}


Console.WriteLine("Write a number of the day in a week (from 1 to 7):");
int a =int.Parse(Console.ReadLine());

Weekend(a);