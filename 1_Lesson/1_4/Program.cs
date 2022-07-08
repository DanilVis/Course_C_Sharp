// 4. Напишите программу, которая на вход принимает одно число
//    (N), а на выходе показывает все целые числа в промежутке от -N до N.

Console.WriteLine("Write a number: ");
int n = int.Parse(Console.ReadLine());

int i = -n;

while (i <= n)
{
    Console.WriteLine(i);
    i++;
}
