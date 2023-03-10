// Задача 5: Определите, является ли число степенью двойки:
// N = 16 -> "Является степень двойки"
// N = 12 -> “Не является степенью двойки”

bool CheckBin(int num)
{
    if (num == 1) return true;
    return num % 2 == 0 && CheckBin(num / 2);
}

int number = 11;
Console.WriteLine($"{CheckBin(number)}");