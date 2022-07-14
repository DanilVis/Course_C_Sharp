// Задача 3: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

void ThirdNumber(int number)
{
    if(number < 100)
    {
        Console.WriteLine("The number is less than 100 and doesn't have the 3rd digit");
    }
    else
    {
        while(number > 999)
        {
            number = number / 10;
        }
        Console.WriteLine(number % 10);
    }
}

Console.WriteLine("Write a number:");
int a =int.Parse(Console.ReadLine());

ThirdNumber(a);