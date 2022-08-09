// Задача 1: Задайте массив из 12 элементов, заполненный
// случайными числами из промежутка [-9, 9]. Найдите сумму
// отрицательных и положительных элементов массива.

void PrintArray(int[] arr)
{
    int count = arr.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

int[] MassNums(int size, int from, int to)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(from, to);
    }
    return arr;
}

void SumPosNeg(int[] arr)
{
    int pos, neg;
    pos = neg = 0;

    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i] >= 0)
            pos += arr[i];
        else
            neg += arr[i];
    }
    Console.WriteLine($"Positive: {pos}, negative: {neg}");
}

int[] arr_1 = MassNums(12, -9, 10);
PrintArray(arr_1);
SumPosNeg(arr_1);


