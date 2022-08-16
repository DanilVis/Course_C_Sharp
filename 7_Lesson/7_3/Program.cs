// 3. Задайте двумерный массив. Найдите сумму элементов главной диагонали.

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

int SumOfDiagonail(int[,] arr)
{
    int sum = 0;
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);

    if (row < column)
    {
        column = row;
    }
    else if (column < row)
    {
        row = column;
    }

    for (int i = 0; i < row; i++)
    {
        sum = sum + arr[i, i];
    }
    return sum;
}

Console.Write("Enter the number of rows: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Enter the number of columns: ");
int column = int.Parse(Console.ReadLine());

int[,] arr1 = FillArray(row, column, 1, 10);
PrintArray(arr1);
Console.WriteLine(SumOfDiagonail(arr1));