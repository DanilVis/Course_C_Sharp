// Задача 3: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

void Print(double[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

double[] MassNums(int size)
{
    double[] arr = new double[size];

    for (int i = 0; i < size; i++)
    {
        arr[i] = Math.Round(new Random().NextDouble() * 10, 2);
    }
    return arr;
}

double MinMaxDiff(double[] arr)
{
    double min = arr[0];
    double max = arr[0];

    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < min)
            min = arr[i];
        else if (arr[i] > max)
            max = arr[i];
    }

    return max - min;
}

double[] arr1 = MassNums(6);
Print(arr1);
Console.WriteLine(MinMaxDiff(arr1));