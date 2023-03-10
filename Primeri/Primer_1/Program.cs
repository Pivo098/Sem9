// Функция сортировки элементов в строке двумерного массива, по убыванию
// https://habr.com/ru/post/204600/
void SortMatrixByRowDesc(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        SortRow(array, i);
    }
}

void SortRow(int[,] array, int i)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int k = 0; k < array.GetLength(1) - 1; k++)
        {
            if (array[i, k] < array[i, k + 1])
            {
                Swap(array, k, i);
            }
        }
    }
}

void Swap(int[,] array, int i, int row)
{
    int temp = array[row, i + 1];
    array[row, i + 1] = array[row, i];
    array[row, i] = temp;
}

bool ValidateMultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix)
{
    if (firstMartrix.GetLength(1) == secomdMartrix.GetLength(0)) return true;
    return false;
}

// Метод произведение матриц
int[,] MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix)
{
    int[,] resultMatrix = new int[secomdMartrix.GetLength(0), secomdMartrix.GetLength(1)];
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < firstMartrix.GetLength(1); k++)
            {
                sum += firstMartrix[i, k] * secomdMartrix[k, j];
            }
            resultMatrix[i, j] = sum;
        }
    }
    return resultMatrix;
}