// 3: Напишите программу, которая будет создавать копию заданного массива(вещественные числа) с помощью поэлементного копирования. 

void Print(double[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

double[] MassNums(int size)
{
    double[] arr = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        arr[i] = Math.Round(rnd.NextDouble() * (20 + 20) - 20, 2);
    }
    return arr;
}

double[] MassCopy(double[] OldArr)
{
    double[] NewArr = new double[OldArr.Length];

    for(int i = 0; i < OldArr.Length; i++)
    {
        NewArr[i] = OldArr[i];
    }
    return NewArr;
}

double[] arr1 = MassNums(10);
Print(arr1);
double[] arr2 = MassCopy(arr1);
Print(arr2);