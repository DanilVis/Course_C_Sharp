// 1. Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку массива.

void PrintArray(int[,] arr)
{
    int rowSize = arr.GetLength(0);
    int columnSize = arr.GetLength(1);

    for (int i = 0; i < rowSize; i++)
    {
        for (int j = 0; j < columnSize; j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] FillArray(int row, int column, int from, int to)
{
    int[,] arr = new int[row, column];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            arr[i, j] = new Random().Next(from, to);
        }
    }
    return arr;
}

int[,] ChangeRows(int[,] arr)
{
    int row = arr.GetLength(0);

    for (int i = 0; i < arr.GetLength(1); i++)
    {
        (arr[0, i], arr[row - 1, i]) = (arr[row - 1, i], arr[0, i]);
    }
    return arr;
}

Console.Write("Enter the number of rows: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Enter the number of columns: ");
int column = int.Parse(Console.ReadLine());

int[,] arr1 = FillArray(row, column, 1, 100);
PrintArray(arr1);
Console.WriteLine();
int[,] arr2 = ChangeRows(arr1);
PrintArray(arr2);