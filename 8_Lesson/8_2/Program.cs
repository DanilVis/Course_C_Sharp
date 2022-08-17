// 2. Задайте двумерный массив. Напишите программу,
//    которая заменяет строки на столбцы. В случае, если это невозможно,
//    программа должна вывести сообщение для пользователя.

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

string ChangeRowsWithColumns(int[,] arr)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);

    if (row != column)
        return "Это невозможно";

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < i; j++)
            (arr[i, j], arr[j, i]) = (arr[j, i], arr[i, j]);
    }
    return "Это возможно";
}

Console.Write("Enter the number of rows: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Enter the number of columns: ");
int column = int.Parse(Console.ReadLine());

int[,] arr1 = FillArray(row, column, 1, 10);
PrintArray(arr1);

Console.WriteLine(ChangeRowsWithColumns(arr1));
PrintArray(arr1);