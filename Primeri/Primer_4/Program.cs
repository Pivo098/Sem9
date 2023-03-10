// Задача 3: Напишите программу, которая будет принимать на вход число
//  и возвращать сумму его цифр. Использовать рекурсию.
// 453 -> 12
// 45 -> 9

int SumNumbers(int num)
{
    if (num == 0) return 0;
    return num % 10 + SumNumbers(num / 10);
} 

int number = 123;
Console.WriteLine($"{SumNumbers(number)}");