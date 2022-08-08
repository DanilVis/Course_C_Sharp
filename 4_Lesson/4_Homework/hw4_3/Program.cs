// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] EightMass()
{
    int[] arr = new int[8];

    for (int i = 0; i < 8; i++)
    {
        arr[i] = new Random().Next(1, 100);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    int count = arr.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

int[] arr1 = EightMass();
PrintArray(arr1);