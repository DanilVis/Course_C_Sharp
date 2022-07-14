//Задача 2: Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

void DeleteSecond(int number)
{
    Console.WriteLine(number / 100 * 10 + number % 10);
}

int a = new Random().Next(100, 1000);

Console.WriteLine(a);
DeleteSecond(a);