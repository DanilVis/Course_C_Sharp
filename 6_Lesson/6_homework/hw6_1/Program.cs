// 1: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int[] FillArray(int num)
{
    int[] arr = new int[num];

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = int.Parse(Console.ReadLine());
    }

    return arr;
}

void Positive(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) count++;
    }
    Console.WriteLine($"You entered {count} number(s) greater than zero");
}

Console.WriteLine("How many numbers do you want to enter?");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Enter numbers one by one");
int[] arr1 = FillArray(a);
Positive(arr1);
