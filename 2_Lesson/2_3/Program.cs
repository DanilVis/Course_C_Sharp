﻿// 3. Напишите программу, которая будет принимать на вход два числа и выводить,
//    является ли второе число кратным первому. Если число 2 не кратно числу 1, то
//    программа выводит остаток от деление.
//    34, 5 -> не кратно, остаток 4
//    16, 4 -> кратно

void Method1(int arg1, int arg2)
{
    if (arg1 % arg2 == 0) Console.WriteLine("Кратно");
    else Console.WriteLine($"Не кратно, остаток {arg1 % arg2}");
}

Method1(34, 5);
