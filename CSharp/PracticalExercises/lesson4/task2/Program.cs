//Задача 2: Задайте массив заполненный случайными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

using System;

class Program
{
    static void Main()
    {
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

        int CountEvenElements(int[] arr)
        {
            int i = 0;
            int count = 0;
            while (i < arr.Length)
            {
                if (arr[i] % 2 == 0)
                {
                    count++;
                }
                i = i + 1;
            }
            return count;
        }

        System.Console.WriteLine("Input array size: ");
        int size = Convert.ToInt32(Console.ReadLine());

        int[] array = CreateArray(size, 100, 999);
        PrintArray(array);
        System.Console.WriteLine(CountEvenElements(array));
    }
}