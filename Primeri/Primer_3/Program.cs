// Задача 2: Задайте значения M и N. Напишите программу, которая рекурсивно выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"


void ShowNumber(int first, int second)
{
    if (first > second) return; // условия выхода
    Console.Write($"{first}  "); // вывод значения
    ShowNumber(first + 1, second); // вызываем рекурсию, я вызываю функцию которая делает что то там
}

int num = 4, second = 8;
ShowNumber(num, second);