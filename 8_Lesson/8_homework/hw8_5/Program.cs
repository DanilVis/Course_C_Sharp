// Задача 4.** Задайте двумерный массив из целых чисел. Напишите программу, 
// которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
// Результат записать в новый массив и вывести

void PrintArray(int[,] arr)
{
    int rowSize = arr.GetLength(0);
    int columnSize = arr.GetLength(1);

    for (int i = 0; i < rowSize; i++)
    {
        for (int j = 0; j < columnSize; j++)
        {
            Console.Write($"{arr[i, j], 3} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
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

int[] MinSearch(int[,] array)
{
    int row = array.GetLength(0);
    int column = array.GetLength(1);
    int min = array[0, 0];
    int[] index = new int[2];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            if (min > array[i, j])
            {
                min = array[i, j];
                index[0] = i;
                index[1] = j;
            }
        }

    }
    return index;
}

int[,] DeleteRowColumn(int[,] array, int[] index)
{
    int row = array.GetLength(0) - 1;
    int column = array.GetLength(1) - 1;
    int[,] newArray = new int[row, column];
    int oldi = 0;
    int oldj = 0;

    for (int i = 0; i < row; i++)
    {
        if (i >= index[0]) oldi = i + 1;
        else oldi = i;

        for (int j = 0; j < column; j++)
        {
            if (j >= index[1]) oldj = j + 1;
            else oldj = j;
            newArray[i, j] = array[oldi, oldj];
        }
    }
    return newArray;
}

Console.Write("Enter the number of rows: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Enter the number of columns: ");
int column = int.Parse(Console.ReadLine());

int[,] arr1 = FillArray(row, column, 1, 100);
PrintArray(arr1);

int[] minIndex = MinSearch(arr1);
int[,] newArr = DeleteRowColumn(arr1, minIndex);
PrintArray(newArr);