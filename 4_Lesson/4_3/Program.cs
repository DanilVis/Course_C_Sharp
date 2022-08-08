// Задача 3: Напишите программу, которая выводит массив из 8 элементов, 
// заполненный нулями и единицами в случайном порядке.

void Array()
{
    int[] arr = new int[8];
    
    for(int i = 0; i < 8; i++)
    {
    arr[i] = new Random().Next(0,2);
    Console.Write($"{arr[i]} ");
    }
}

Array();


