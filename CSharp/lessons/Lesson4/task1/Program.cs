// Создать двумерный массив с размерами
// 3 * 5, состоящий из целых чисел
// Вывести его элементы на экран

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
            matrix[i, j] = rnd.Next(1, 11);
        }
    }
    return matrix;
}

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

int[,] matrix = CreateMatrix(4, 5);
ShowMatrix(matrix);