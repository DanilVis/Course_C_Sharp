// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

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

string ShowElement(int[,] arr, int rowPos, int columnPos)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);

    if (rowPos > 0 && rowPos <= row && columnPos > 0 && columnPos <= column)
        return $"The element with position ({row}, {column}) is {arr[row - 1, column - 1]}";
    return $"There is no element with position ({row}, {column})";
}

Console.Write("Enter the number of rows: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Enter the number of columns: ");
int column = int.Parse(Console.ReadLine());

int[,] arr1 = FillArray(row, column, 1, 100);

Console.Write("Enter the row position of an element: ");
int rowPosition = int.Parse(Console.ReadLine());
Console.Write("Enter the column position of an element: ");
int columnPosition = int.Parse(Console.ReadLine());

PrintArray(arr1);
Console.WriteLine(ShowElement(arr1, rowPosition, columnPosition));
