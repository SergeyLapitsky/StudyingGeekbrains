//Напишите программу, которая будет принимать на
//вход два числа и выводить, является ли первое число
//кратным второму. Если первое число некратно
//второму, то программа выводит остаток от деления.
//Примеры
//14, 5 => нет, 4
//16, 8 => да
//4, 3 => нет, 1

void CheckIfDevides(int num1, int num2)
{
    if(num1 % num2 == 0)
    {
        System.Console.WriteLine($"{num1}, {num2} -> yes");
    }
    else
    {
        System.Console.WriteLine($"{num1}, {num2} -> no, {num1 % num2}");
    }
}

Console.Write("Input first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

CheckIfDevides(num1, num2);