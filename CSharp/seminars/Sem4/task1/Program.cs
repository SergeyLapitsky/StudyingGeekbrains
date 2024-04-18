// Задайте одномерный массив, заполненный случайными
// числами. Определите количество простых чисел в этом
// массиве.
// Примеры
// [1 3 4 19 3] => 3
// [4 3 4 1 9 5 21 13] => 3

int[] CreateArray(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
    System.Console.WriteLine();
}

bool IsPrime(int num)
{
    if (num == 1)
    {
        return false;
    }
    for (int j = 2; j <= num / 2; j++)
    {
        if (num % j == 0)
        {
            return false;
        }
    }
    return true;
}

int CountPrime(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (IsPrime(array[i]))
        {
            count++;
        }
    }
    return count;

}

System.Console.WriteLine("Input array size: ");
int size = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input minimal value of arr element: ");
int min = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input maximal value of arr element: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = CreateArray(size, min, max);
PrintArray(array);
System.Console.WriteLine(CountPrime(array));
