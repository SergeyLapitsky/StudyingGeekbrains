// Назовем число "интересным" если его сумма
// цифр четная.
// Создать двумерный массив, состоящий из
// целых чисел. Вывести на экран "интересные"
// элементы массива

// Создание двумерного массива
int[,] CreateMatrix(int rowCount, int columsCount)
{
    int[,] matrix = new int[rowCount, columsCount];
    Random rnd = new Random();
    // Определение количества строк в двумерном массиве
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        // Определение количества столбцов в двумерном массиве
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 1000);
        }
    }
    return matrix;
}

// Вывод исходного массива
void ShowMatrix(int[,] matrix)
{
    // Вывод элементов двумерного массива
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        // Вывод одномерного массива
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] matrix = CreateMatrix(3, 4);
ShowMatrix(matrix);

// Вывод интересных чисел
foreach (int e in matrix)
{
    if (IsInteresting(e) is true)
    {
        Console.WriteLine(e);
    }
}

// Проверка на интересность (сумма цифр числа - четная)
bool IsInteresting(int value)
{
    int sumOfDigits = GetSumOfDigits(value);
    if (sumOfDigits % 2 == 0)
    {
        return true;
    }
    return false;
}

// Вычисление суммы цифр числа
int GetSumOfDigits(int value)
{
    int sum = 0;
    while (value > 0)
    {
        sum = sum + value % 10;
        value = value / 10;
    }
    return sum;
}