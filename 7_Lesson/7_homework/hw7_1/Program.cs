// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

void PrintArray(double[,] arr)
{
    int rowSize = arr.GetLength(0);
    int columnSize = arr.GetLength(1);

    for (int i = 0; i < rowSize; i++)
    {
        for (int j = 0; j < columnSize; j++)
        {
            Console.Write($"{arr[i, j], 6} ");
        }
        Console.WriteLine();
    }
}

double[,] FillArray(int row, int column, double from, double to)
{
    double[,] arr = new double[row, column];
    Random rnd = new Random();

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            arr[i, j] = Math.Round(rnd.NextDouble() * (to - from) + from, 2);
        }
    }
    return arr;
}

Console.Write("Enter the number of rows: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Enter the number of columns: ");
int column = int.Parse(Console.ReadLine());

double[,] arr1 = FillArray(row, column, -10, 10);
PrintArray(arr1);
