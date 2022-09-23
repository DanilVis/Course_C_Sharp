// 3. Напишите программу, которая будет принимать на вход число
//    и возвращать сумму его цифр. Использовать рекурсию.

int SumNum(int sum)

{
    if (sum == 0) return 0;
    return SumNum(sum / 10) + sum % 10;

}

Console.WriteLine(SumNum(123));


