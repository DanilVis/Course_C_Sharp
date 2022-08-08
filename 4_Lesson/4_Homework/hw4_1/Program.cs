// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Exp(int a, int b)
{
    int result = 1;

    for(int i = 1; i <= b; i++)
    result = result * a;

    return result;
}

Console.WriteLine("Write the first number: ");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Write the second number: ");
int y = int.Parse(Console.ReadLine());

Console.WriteLine(Exp(x, y));