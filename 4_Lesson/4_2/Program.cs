// Задача 2: Напишите программу, которая принимает на вход число N 
// и выдаёт произведение чисел от 1 до N.

int Product(int x)
{
    int result = 1;
    for(int i = 1; i <= x; i++)
    result = result * i;
    return result;
}

Console.WriteLine("Write a number: ");
int n = int.Parse(Console.ReadLine());

Console.WriteLine(Product(n));