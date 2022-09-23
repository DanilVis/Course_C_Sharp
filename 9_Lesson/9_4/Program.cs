// Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.

int degree (int a, int b)
{
    if (b == 0) return 1;
    return degree (a, b - 1) * a;
}

Console.WriteLine(degree(2, 3));

