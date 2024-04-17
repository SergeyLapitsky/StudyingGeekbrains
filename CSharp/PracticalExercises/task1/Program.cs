//Задача 1: Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

void CheckIfDevides(int num)
{
    if(num % 7 == 0 && num % 23 == 0)
    {
        System.Console.WriteLine("Number multiple 7 and 23");
    }
    else 
    {
        System.Console.WriteLine("Number not multiple 7 and 23");
    }
}

Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());

CheckIfDevides(num);