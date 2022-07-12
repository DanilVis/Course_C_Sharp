// 2. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

int MaxDigit(int number)
{
    if (number / 10 > number % 10)
    {
        return number / 10;
    }
    else 
    {
    return number % 10;
    }
}

int a = new Random().Next(10, 100);

Console.WriteLine(a);
Console.WriteLine(MaxDigit(a));

