// Задача 1: Напишите программу, которая перевернёт одномерный массив 
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)

void Print(int[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
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

int[] RevMass(int[] arr)
{
    int size = arr.Length - 1;

    for (int i = 0; i < size / 2 + 1; i++)
    {
        (arr[i], arr[size - i]) = (arr[size - i], arr[i]);
    }

    return arr;

}

int[] arr1 = MassNums(10, 1, 20);
Print(arr1);
int[] arr2 = RevMass(arr1);
Print(arr2);