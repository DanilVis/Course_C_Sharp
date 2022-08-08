// Задача 1: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.

int NumCount(int a)
{
    string number = a.ToString();
    return number.Length;
}

Console.WriteLine("Write a number: ");
int x = int.Parse(Console.ReadLine());

Console.WriteLine(NumCount(x));