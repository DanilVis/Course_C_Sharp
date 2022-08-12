// 2: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

void Intersection(double k1, double b1, double k2, double b2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    Console.WriteLine($"For y = {k1} * x + {b1}, y = {k2} * x + {b2} point of intersection is ({x}, {y})");
}


Console.Write("Enter k1: ");
double k_1 = double.Parse(Console.ReadLine());
Console.Write("Enter b1: ");
double b_1 = double.Parse(Console.ReadLine());
Console.Write("Enter k2: ");
double k_2 = double.Parse(Console.ReadLine());
Console.Write("Enter b2: ");
double b_2 = double.Parse(Console.ReadLine());

Intersection(k_1, b_1, k_2, b_2);