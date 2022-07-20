// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void Cube (int a)
{
    int i = 1;
    while (i <= a)
    {
        Console.WriteLine(Math.Pow(i, 3));
        i++;
    }
}

Console.Write("Write a number: ");
int n = int.Parse(Console.ReadLine());
Cube(n);