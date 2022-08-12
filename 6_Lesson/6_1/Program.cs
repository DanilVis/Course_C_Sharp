// Задача 1: Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.

void Triangle (int x, int y, int z)
{
if ((x + y) > z && (x + z) > y && (y + z) > x)
{
Console.WriteLine("The triangle exists");
}
else
{
Console.WriteLine("The triangle doesn't exist");
}
}

Triangle (4, 2, 5);
Triangle (1, 2, 3);