// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

void Palindrome(int a)
{
    if (a / 10000 == a % 10 && a / 1000 % 10 == a / 10 % 10)
        Console.WriteLine("The number is a palindrome");
    else
        Console.WriteLine("The number is not a palindrome");
}

Console.Write("Write a number: ");
int p = int.Parse(Console.ReadLine());
Palindrome(p);