// 2. Задайте массив. Напишите программу, которая определяет,
//    присутствует ли заданное число в массиве.


void Print(int[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

int[] MassNums(int size)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(-9, 10);
    }
    return arr;
}

void IfInNum(int[] arr, int num)
{   
    string text = "No";
    for (int i = 0; i < arr.Length; i++)
    {
        if (num == arr[i])
        {
            text = "Yes";
            break;
        }
    }
    Console.WriteLine($"The num value {num} -> {text}");    
}


int[] arr_1 = MassNums(12);
Print(arr_1);
IfInNum(arr_1, 4);

int[] arr_2 = MassNums(12);
Print(arr_2);
IfInNum(arr_2, 7);
