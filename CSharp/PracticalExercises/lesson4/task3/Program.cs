// Задача 3: Напишите программу, которая перевернёт одномерный массив 
// (первый элемент станет последним, второй – предпоследним и т.д.)

using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 9, 58, 16, 65, 71, 82 }; // Исходный массив
        int currentElement;
        // Вывод исходного массива
        Console.Write("Исходный массив: ");
        foreach (int num in numbers)
        {
            Console.Write(num + " ");
        }
        // Реверсирование массива
        for (int i = 0; i < numbers.Length / 2; i++)
        {
            // Меняем местами элементы
            currentElement = numbers[i];
            numbers[i] = numbers[numbers.Length - 1 - i];
            numbers[numbers.Length - 1 - i] = currentElement;
        }
        // Вывод измененного массива
        Console.Write("\nПеревернутый массив: ");
        foreach (int num in numbers)
        {
            Console.Write(num + " ");
        }

    }
}