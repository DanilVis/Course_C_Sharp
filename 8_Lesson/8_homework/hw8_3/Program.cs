// Задача 3: Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.

void PrintArray(int[,] arr)
{
    int rowSize = arr.GetLength(0);
    int columnSize = arr.GetLength(1);

    for (int i = 0; i < rowSize; i++)
    {
        for (int j = 0; j < columnSize; j++)
        {
            Console.Write($"{arr[i, j],4} ");
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

int[,] MatrixMultiplication(int[,] arr1, int[,] arr2)
{
    int row1 = arr1.GetLength(0);
    int column1 = arr1.GetLength(1);
    int column2 = arr2.GetLength(1);
    int[,] matrixProduct = new int[row1, column2];

    for (int i = 0; i < row1; i++)
    {
        for (int j = 0; j < column2; j++)
        {
            for (int k = 0; k < column1; k++)
            {
                matrixProduct[i,j] += arr1[i,k] * arr2[k,j];
            }
        }
    }

    return matrixProduct;
}

Console.Write("Enter the number of rows in the first matrix: ");
int row1 = int.Parse(Console.ReadLine());
Console.Write("Enter the number of columns in the first matrix: ");
int column1 = int.Parse(Console.ReadLine());

Console.Write("Enter the number of rows in the second matrix: ");
int row2 = int.Parse(Console.ReadLine());
Console.Write("Enter the number of columns in the second matrix: ");
int column2 = int.Parse(Console.ReadLine());

int[,] arr1 = FillArray(row1, column1, 1, 10);
PrintArray(arr1);

int[,] arr2 = FillArray(row2, column2, 1, 10);
PrintArray(arr2);

if(column1 == row2)
{
int[,] newArr = MatrixMultiplication(arr1, arr2);
PrintArray(newArr);
}
else
{
Console.WriteLine("For matrix multiplication, the number of columns " 
                + "in the first matrix must be equal to the number of rows " 
                + "in the second matrix. Try again.");
}
