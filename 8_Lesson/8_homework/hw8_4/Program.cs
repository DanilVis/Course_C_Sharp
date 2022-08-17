// Задача 3.* Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, сколько раз встречается 
// элемент входных данных. Значения элементов массива 0..9

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

void FrequencyCheck(int[,] arr)
{
    for (int i = 0; i < 10; i++)
    {
        int count = 0;

        foreach (int j in arr)
        {
            if (j == i) count++;
        }
        Console.WriteLine($"{i} => {count} times");
    }

}

Console.Write("Enter the number of rows: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Enter the number of columns: ");
int column = int.Parse(Console.ReadLine());

int[,] arr1 = FillArray(row, column, 0, 10);
PrintArray(arr1);
FrequencyCheck(arr1);